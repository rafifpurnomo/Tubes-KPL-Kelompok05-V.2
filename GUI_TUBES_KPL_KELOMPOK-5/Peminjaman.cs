using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GUI_TUBES_KPL_KELOMPOK_5
{
    public partial class Peminjaman : Form
    {
        public Peminjaman()
        {
            InitializeComponent();
        }

        private void Peminjaman_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            List<Buku> daftarBuku = ReadJsonFile("C:\\Users\\Rafif Purnomo\\OneDrive\\Documents\\Coding\\C#\\Tubes-KPL-Kelompok05-V.2\\GUI_TUBES_KPL_KELOMPOK-5\\Data\\DataBuku.json");

            foreach (var buku in daftarBuku)
            {
                tableDaftarBuku.Rows.Add(buku.kodeBuku, buku.Judul, buku.Penulis, buku.TahunTerbit, buku.stok);
            }
        }

        private List<Buku> ReadJsonFile(string filePath)
        {
            string json;
            using (StreamReader reader = new StreamReader(filePath))
            {
                json = reader.ReadToEnd();
            }

            List<Buku> daftarBuku = JsonSerializer.Deserialize<List<Buku>>(json);

            return daftarBuku;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implement your logic here if needed
        }

        private class Buku
        {
            public string kodeBuku { get; set; }
            public string Judul { get; set; }
            public string Penulis { get; set; }
            public int TahunTerbit { get; set; }
            public int stok { get; set; }
        }

        private void kembaliBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
