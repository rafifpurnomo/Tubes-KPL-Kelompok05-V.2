using System.Text.Json;
using System.Windows.Forms;
using LIBRARY_TUBES_KPL_KELOMPOK_05;
using MAIN_TUBES_KPL_KELOMPOK_5;

namespace GUI_TUBES_KPL_KELOMPOK_5
{
    public partial class DetailBuku : Form
    {
        private Akun akun;
        private Buku buku;
        Perpustakaan perpustakaan;
        List<Peminjaman> dataPeminjaman = Perpustakaan.ReadJsonFile<List<Peminjaman>>(Perpustakaan.JsonPathPeminjaman, "peminjaman");
        List<Akun> daftarAkun = Perpustakaan.ReadJsonFile<List<Akun>>(Perpustakaan.JsonPathAkun, "akun");
        List<Buku> daftarBuku = Perpustakaan.ReadJsonFile<List<Buku>>(Perpustakaan.JsonPathBuku, "buku");

        public DetailBuku(Buku buku)
        {
            InitializeComponent();
            this.buku = buku;
            TampilkanDetailBuku();
            this.perpustakaan = new Perpustakaan();
            this.akun = getAkun();
        }

        public void updateStockBuku()
        {
            int idxBuku = -1;
            for (int i = 0; i < daftarBuku.Count; i++) 
            {
                if (daftarBuku[i].kodeBuku == this.buku.kodeBuku)
                {
                    daftarBuku[i].stok -= 1;
                    idxBuku = i;
                }

                if(idxBuku > -1)
                {
                    WriteJSON2(daftarBuku);
                }
            }

        }

        public Akun getAkun()
        {
            foreach (Akun akun in daftarAkun)
            {
                if(akun.namaUser == UserSession.namaUser)
                {
                    return akun;
                }
            }
            return null;
        }

        private void TampilkanDetailBuku()
        {
            labelKodeBuku.Text = buku.kodeBuku;
            labelJudul.Text = buku.Judul;
            labelPenulis.Text = buku.Penulis;
            labelTahunTerbit.Text = buku.TahunTerbit.ToString();
            labelStok.Text = buku.stok.ToString();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelJudul_Click(object sender, EventArgs e)
        {

        }

        private void labelKodeBuku_Click(object sender, EventArgs e)
        {

        }

        private void labelTahunTerbit_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Pinjam_Click(object sender, EventArgs e)
        {
            if(buku.stok > 0)
            {
                string tanggalPinjam = StringLibrary.KonversiDateKeString(DateTime.Now);
                string tanggalPengembalian = StringLibrary.KonversiDateKeString(DateTime.Now.AddDays(7));
                Peminjaman peminjamanBaru = new Peminjaman(buku.Judul, akun, tanggalPinjam, tanggalPengembalian);
                dataPeminjaman.Add(peminjamanBaru);
                WriteJSON(dataPeminjaman);
                updateStockBuku();


                MessageBox.Show("Anda berhasil melakukan peminjaman buku");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Stock buku tidak tersedia");
                this.Dispose();
            }
           
        }
    }
}
