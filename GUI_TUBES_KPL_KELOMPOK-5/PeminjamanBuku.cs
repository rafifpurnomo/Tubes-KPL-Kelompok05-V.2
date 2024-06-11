using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using MAIN_TUBES_KPL_KELOMPOK_5;

namespace GUI_TUBES_KPL_KELOMPOK_5
{
    public partial class PeminjamanBuku : Form
    {
        public string filePathDataBuku = "C:\\Kuliah\\semester 4\\Konstruksi Perangkat Lunak\\Tubes\\Kelompok_5\\Tubes-KPL-Kelompok05-V.2\\GUI_TUBES_KPL_KELOMPOK-5\\Data\\DataBuku.json";
        public PeminjamanBuku(MenuPengguna menuPengguna)
        {
            InitializeComponent();
            this.menuPengguna = menuPengguna;
            dataGridView1.ReadOnly = true;
            this.akun = akun;
        }

        MenuPengguna menuPengguna;
        Akun akun;

        private void Peminjaman_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            List<Buku> daftarBuku = ReadJsonFile(filePathDataBuku);

            foreach (var buku in daftarBuku)
            {
                dataGridView1.Rows.Add(buku.kodeBuku, buku.Judul, buku.Penulis, buku.TahunTerbit, buku.stok);
            }
        }

        private List<Buku> ReadJsonFile(string filePath)
        {
            try
            {
                string json;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    json = reader.ReadToEnd();
                }

                List<Buku> daftarBuku = JsonSerializer.Deserialize<List<Buku>>(json);
                return daftarBuku;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading JSON file: {ex.Message}");
                return new List<Buku>();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Buku> daftarBuku = ReadJsonFile(filePathDataBuku);

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string kodeBuku = row.Cells[0].Value.ToString();
                Buku buku = searchBookByKode(kodeBuku, daftarBuku);
                if (buku != null)
                {
                    new DetailBuku(buku).ShowDialog();
                }
            }
        }

        public Buku searchBookByKode(string kode, List<Buku> daftarBuku)
        {
            for (int i = 0; i < daftarBuku.Count; i++)
            {
                if (daftarBuku[i].kodeBuku == kode)
                {
                    return daftarBuku[i];
                }
            }
            return null;
        }



        private void Back_Click_1(object sender, EventArgs e)
        {
            this.Close();
            menuPengguna.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            PopulateDataGridView();
        }
    }
}
