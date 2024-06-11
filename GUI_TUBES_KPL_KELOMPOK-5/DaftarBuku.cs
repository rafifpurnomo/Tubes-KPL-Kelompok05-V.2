using MAIN_TUBES_KPL_KELOMPOK_5;
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

namespace GUI_TUBES_KPL_KELOMPOK_5
{
    public partial class DaftarBuku : Form
    {
        public string filePathDataBuku = "C:\\Users\\Rafif Purnomo\\OneDrive\\Documents\\Coding\\C#\\Tubes-KPL-Kelompok05-V.2\\GUI_TUBES_KPL_KELOMPOK-5\\Data\\DataBuku.json";

        public DaftarBuku()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }

        private List<Buku> ReadJsonFile(string filePath)
        {
            List<Buku> daftarBuku = new List<Buku>();
            try
            {
                string json;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    json = reader.ReadToEnd();
                }

                daftarBuku = JsonSerializer.Deserialize<List<Buku>>(json);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading JSON file: " + ex.Message);
                
            }
            return daftarBuku;
        }

        private void gettAllDataBuku()
        {
            List<Buku> daftarBuku = ReadJsonFile(filePathDataBuku);

            foreach (var buku in daftarBuku)
            {
                dataGridView1.Rows.Add(buku.kodeBuku, buku.Judul, buku.Penulis, buku.TahunTerbit, buku.stok);
            }
        }


        private void DaftarBuku_Load(object sender, EventArgs e)
        {
            gettAllDataBuku();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNtambah_Click(object sender, EventArgs e)
        {
            TambahBuku formTambahBuku = new TambahBuku();
            formTambahBuku.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
