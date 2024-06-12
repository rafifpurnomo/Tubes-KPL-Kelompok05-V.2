using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAIN_TUBES_KPL_KELOMPOK_5;

namespace GUI_TUBES_KPL_KELOMPOK_5
{
    public partial class DetailPeminjamanBuku : Form
    {
        public DetailPeminjamanBuku(Peminjaman peminjamanBuku)
        {
            InitializeComponent();
            this.peminjamanBuku = peminjamanBuku;
            setTextPenggembalianBuku();
        }

        Peminjaman peminjamanBuku;
        List<Peminjaman> daftarPinjaman = Perpustakaan.ReadJsonFile<List<Peminjaman>>(Perpustakaan.JsonPathPeminjaman, "peminjaman");
        List<Buku> daftarBuku = Perpustakaan.ReadJsonFile<List<Buku>>(Perpustakaan.JsonPathBuku, "buku");
        private void setTextPenggembalianBuku()
        {

            label_id.Text = peminjamanBuku.ID_Peminjaman;
            label_nama.Text = peminjamanBuku.Peminjam.namaUser;
            label_buku.Text = peminjamanBuku.JudulBuku;
            label_tglPeminjaman.Text = peminjamanBuku.TanggalPinjam;
            label_tenggatWaktu.Text = peminjamanBuku.DeadLinePengembalian;
            label_statusPengembalian.Text = peminjamanBuku.keteranganPenggembalian;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FineManager denda = peminjamanBuku.GetFineManager();
            if (denda.TotalDenda == 0)
            {
                int idxPeminjamanBaru = searchPeminjamanById(peminjamanBuku.ID_Peminjaman,daftarPinjaman);
                if(idxPeminjamanBaru >= 0)
                {
                    daftarPinjaman[idxPeminjamanBaru].keteranganPenggembalian = "Sedang Dikembalikan";
                }
                int idxBukuBaru = searchBukuByNama(peminjamanBuku.JudulBuku,daftarBuku);
                if(idxBukuBaru >= 0)
                {
                    daftarBuku[idxBukuBaru].stok++;
                }
                WriteJSON(daftarPinjaman);
                WriteJSON2(daftarBuku);
                MessageBox.Show("Request pengembalian buku berhasil");
                this.Close();
            } 
            else
            {
                new PembayaranDenda(denda).ShowDialog();
                int idxPeminjamanBaru = searchPeminjamanById(peminjamanBuku.ID_Peminjaman, daftarPinjaman);
                if (idxPeminjamanBaru >= 0)
                {
                    daftarPinjaman[idxPeminjamanBaru].keteranganPenggembalian = "Sedang Dikembalikan";
                }
                int idxBukuBaru = searchBukuByNama(peminjamanBuku.JudulBuku, daftarBuku);
                if (idxBukuBaru >= 0)
                {
                    daftarBuku[idxBukuBaru].stok++;
                }
                WriteJSON(daftarPinjaman);
                WriteJSON2(daftarBuku);
                this.Close();

            }
        }

        private int searchPeminjamanById(string idPeminjaman, List<Peminjaman> peminjaman)
        {
            for (int i = 0; i < peminjaman.Count; i++)
            {
                if (peminjaman[i].ID_Peminjaman == idPeminjaman)
                {
                    return i;
                }
            }
            return -1;
        }

        private int searchBukuByNama(string namaBuku, List<Buku> daftarbuku)
        {
            for(int i = 0; i < daftarbuku.Count; i++)
            {
                if (daftarbuku[i].Judul == namaBuku)
                {
                    return i;
                }
            }
            return -1;
        }

        public void WriteJSON(List<Peminjaman> dataPeminjaman)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            try
            {
                string jsonString = JsonSerializer.Serialize(dataPeminjaman, options);
                File.WriteAllText(Perpustakaan.JsonPathPeminjaman, jsonString);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Direktori tidak ditemukan: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan: " + ex.Message);
            }
        }

        public void WriteJSON2(List<Buku> daftarBuku)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            try
            {
                string jsonString = JsonSerializer.Serialize(daftarBuku, options);
                File.WriteAllText(Perpustakaan.JsonPathBuku, jsonString);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Direktori tidak ditemukan: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}
