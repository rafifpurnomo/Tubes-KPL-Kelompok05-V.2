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
        public static DaftarBuku Instance;
        private List<Buku> daftarBuku = new List<Buku>();
        private string selectedKodeBuku;
        public string filePathDataBuku = "D:\\Coding\\C#\\KPL Clone\\Tubes-KPL-Kelompok05-V.2\\GUI_TUBES_KPL_KELOMPOK-5\\Data\\DataBuku.json";

        public DaftarBuku()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            Instance = this;
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

        private void WriteJsonFile(List<Buku> daftarBuku, string filePath)
        {
            string json = JsonSerializer.Serialize(daftarBuku, new JsonSerializerOptions { WriteIndented = true });
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(json);
            }
        }

        private void gettAllDataBuku()
        {
            daftarBuku = ReadJsonFile(filePathDataBuku); // Update this line to set the class variable

            dataGridView1.Rows.Clear(); // Clear existing rows
            foreach (var buku in daftarBuku)
            {
                dataGridView1.Rows.Add(buku.kodeBuku, buku.Judul, buku.Sinopsis, buku.Penulis, buku.TahunTerbit, buku.stok);
            }
        }

        public void RefreshDataGridView()
        {
            gettAllDataBuku();
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedKodeBuku = row.Cells["kodeBuku"].Value.ToString();
            }

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

        private void BTNedit_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedKodeBuku))
            {
                Buku bukuToEdit = daftarBuku.Find(b => b.kodeBuku == selectedKodeBuku);
                if (bukuToEdit != null)
                {
                    EditBuku formEditBuku = new EditBuku(bukuToEdit);
                    formEditBuku.FormClosed += (s, args) => RefreshDataGridView(); // Refresh the data grid view when form is closed
                    formEditBuku.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selected book not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a book to edit.");
            }
        }

        private void BTNhapus_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedKodeBuku))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    daftarBuku = ReadJsonFile("C:\\TubesKPL\\V2\\Tubes-KPL-Kelompok05-V.2\\GUI_TUBES_KPL_KELOMPOK-5\\Data\\DataBuku.json");
                    Buku bukuToRemove = daftarBuku.Find(b => b.kodeBuku == selectedKodeBuku);

                    if (bukuToRemove != null)
                    {
                        daftarBuku.Remove(bukuToRemove);
                        WriteJsonFile(daftarBuku, "C:\\TubesKPL\\V2\\Tubes-KPL-Kelompok05-V.2\\GUI_TUBES_KPL_KELOMPOK-5\\Data\\DataBuku.json");
                        RefreshDataGridView();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }
    }
}
