using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using MAIN_TUBES_KPL_KELOMPOK_5;

namespace GUI_TUBES_KPL_KELOMPOK_5
{
    public partial class Peminjaman : Form
    {
        private string fileDataBuku = "Data\\DataBuku.json";
        public Peminjaman()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }

        private void Peminjaman_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            List<Buku> daftarBuku = ReadJsonFile(fileDataBuku);

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
            List<Buku> daftarBuku = ReadJsonFile(fileDataBuku);

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

        private void Pinjam_Click(object sender, EventArgs e)
        {
            // Implement your logic here if needed
        }

        private void kembaliBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
