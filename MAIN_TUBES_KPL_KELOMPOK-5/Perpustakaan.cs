
﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LIBRARY_TUBES_KPL_KELOMPOK_05;

namespace MAIN_TUBES_KPL_KELOMPOK_5
{
    public class Perpustakaan
    {
        public Perpustakaan()
        {
            DaftarPeminjaman = new List<Peminjaman>();
            listAkun = ReadJsonFile<List<Akun>>(JsonPathAkun, "akun");
            buku = ReadJsonFile<List<Buku>>(JsonPathBuku, "buku"); 
        }

        public const string JsonPathBuku = "C:\\Kuliah\\semester 4\\Konstruksi Perangkat Lunak\\Tubes\\Kelompok_5\\Tubes-KPL-Kelompok05-V.2\\GUI_TUBES_KPL_KELOMPOK-5\\Data\\DataBuku.json";
        public const string JsonPathPeminjaman  = "";
        public const string JsonPathAkun = "C:\\Kuliah\\semester 4\\Konstruksi Perangkat Lunak\\Tubes\\Kelompok_5\\Tubes-KPL-Kelompok05-V.2\\GUI_TUBES_KPL_KELOMPOK-5\\Data\\DataAkun.json";

        private List<Buku> buku = new List<Buku>();

        private Buku[] bukuArray;

        private List<Peminjaman> DaftarPeminjaman;

        private List<Akun> listAkun = new List<Akun>();
        
        ConfigManager configManager = new ConfigManager();
        
        
        public void toArray()
        {
            bukuArray = buku.ToArray();
        }

        public List<Peminjaman> GetPeminjamen()
        {
            return DaftarPeminjaman;
        }

        public List<Buku> GetBuku()
        {
            return buku;
        }

        public List<Akun> GetAkun()
        {
            return listAkun;
        }

        // Implementasikan Method 
        public void PeminjamanBuku(List<Buku> rakBuku, Akun pengguna)
        {
            Console.Write("Masukkan judul buku yang ingin dipinjam : ");
            string judulYangDipinjam = Console.ReadLine();


            int idx_buku = -1;

            for (int i = 0; i < rakBuku.Count; i++)
            {
                if (rakBuku[i].Judul == judulYangDipinjam)
                {
                    idx_buku = i;
                    break;


                }
            }

            if (idx_buku == -1)
            {
                Console.WriteLine("Buku tidak ada");
            }

            else if (rakBuku[idx_buku].stok == 0) // cek ketersediaan buku
            {
                Console.WriteLine("Stok BUku Kosong");
            }

            else
            {
                DateTime sekarang = DateTime.Now;
                string peminjaman = StringLibrary.KonversiDateKeString(sekarang);
                string deadlinePengembalian = StringLibrary.KonversiDateKeString(sekarang.AddDays(configManager.BatasWaktuPeminjaman));

                Peminjaman peminjamanBaru = new Peminjaman(Peminjaman.ID_count.ToString(), rakBuku[idx_buku].Judul, pengguna, peminjaman, deadlinePengembalian);
                DaftarPeminjaman.Add(peminjamanBaru);
                Console.WriteLine("Berhasil melakukan peminjaman");
                rakBuku[idx_buku].stok--;
            }
        }
        public void cariByJudul(string judul)
        {

            for (int i = 0; i < bukuArray.Length; i++)
            {
                if (judul == bukuArray[i].Judul)
                {
                    Console.WriteLine("Kode buku: " + bukuArray[i].kodeBuku);
                    Console.WriteLine("Judul Buku" + bukuArray[i].Judul);
                    Console.WriteLine("Sinopsis: " + bukuArray[i].Sinopsis);
                    Console.WriteLine("Penulis: " + bukuArray[i].Penulis);
                    Console.WriteLine("Tahun Terbit: " + bukuArray[i].TahunTerbit);
                }
            }
        }

        public int returnIndex(string judul)
        {
            int index = -1;

            for (int i = 0; i < bukuArray.Length; i++)
            {
                if (judul == bukuArray[i].Judul)
                {
                    return index = i;
                    break;
                }
            }

            return index;
        }

        public void PerpanjangPeminjaman(List<Peminjaman> daftarPeminjam)
        {
            Console.Write("Masukan id peminjaman buku: ");
            string ID_peminjaman = Console.ReadLine();

            foreach (Peminjaman peminjaman in daftarPeminjam)
            {
                if (peminjaman.ID_Peminjaman == ID_peminjaman)
                {
                    DateTime pengembalianBaru = StringLibrary.KonversiStringKeDate(peminjaman.TanggalPengembalian).AddDays(configManager.BatasWaktuMaksimumPerpanjangan);
                    peminjaman.TanggalPengembalian = StringLibrary.KonversiDateKeString(pengembalianBaru);
                    Console.WriteLine("Waktu peminjaman buku Anda sudah dipepanjang selama " + configManager.JumlahMaksimumPerpanjangan + "hari");
                    break;
                }
            }

            Console.WriteLine("Peminjaman dengan ID " + ID_peminjaman + "tidak ditemukan");
        }

        public void PengembalianBuku(List<Peminjaman> daftarPeminjam)
        {
            Console.Write("Masukan id peminjaman buku: ");
            string ID_peminjaman = Console.ReadLine();

            foreach (Peminjaman peminjaman in daftarPeminjam)
            {
                if ((peminjaman.ID_Peminjaman == ID_peminjaman) && (!peminjaman.statusPengembalian))
                {
                    DateTime jadwalPengembalian = StringLibrary.KonversiStringKeDate(peminjaman.TanggalPengembalian);
                    if (DateTime.Now <= jadwalPengembalian)
                    {
                        peminjaman.statusPengembalian = true;
                        Console.WriteLine("Terimakasih sudah mengembalikan buku tepat waktu");
                    }
                    else
                    {
                        Console.WriteLine("Anda perlu membayar denda karena keterlambatan pengembalian");
                        FineManager bayarDenda = new FineManager(peminjaman.TanggalPengembalian, StringLibrary.KonversiDateKeString(DateTime.Now));
                        bayarDenda.PembayaranDenda();
                        Console.WriteLine("Terimakasih sudah mengembalikan buku");
                        peminjaman.statusPengembalian = true;
                    }
                }
                else if (!peminjaman.statusPengembalian)
                {
                    Console.WriteLine("Buku pada ID peminjaman tersebut sudah dikembalikan ");
                }
                else
                {
                    Console.WriteLine("ID peminjaman tidak ditemukan");
                }
            }
        }

        public T ReadJsonFile<T>(string filePath, string flag)
        {
            try
            {
                string json;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    json = reader.ReadToEnd();
                }

                if (flag == "buku")
                {
                    List<Buku> listData = JsonSerializer.Deserialize<List<Buku>>(json);
                    return (T)(object)listData; // Konversi ke List<Buku>
                }
                else if (flag == "akun")
                {
                    List<Akun> listData = JsonSerializer.Deserialize<List<Akun>>(json);
                    return (T)(object)listData; // Konversi ke List<Akun>
                }
                else if (flag == "peminjaman")
                {
                    List<Peminjaman> listData = JsonSerializer.Deserialize<List<Peminjaman>>(json);
                    return (T)(object)listData; // Konversi ke List<Peminjaman>
                }
                else
                {
                    throw new ArgumentException("Invalid flag value.");
                }
            }
            catch (Exception ex)
            {
                // Logging the error
                Debug.WriteLine($"Error reading JSON file: {ex.Message}");
                // Alternatively, you could use Console.WriteLine
                Console.WriteLine($"Error reading JSON file: {ex.Message}");

                if (flag == "buku")
                {
                    return (T)(object)new List<Buku>();
                }
                else if (flag == "akun")
                {
                    return (T)(object)new List<Akun>();
                }
                else if (flag == "peminjaman")
                {
                    return (T)(object)new List<Peminjaman>();
                }
                else
                {
                    return default(T);
                }
            }
        }
    }
}
