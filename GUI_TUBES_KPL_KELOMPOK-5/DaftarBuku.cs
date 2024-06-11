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

        public DaftarBuku()
        {
            InitializeComponent();
            Instance = this;
        }

        private void DaftarBuku_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            daftarBuku = ReadJsonFile("C:\\TubesKPL\\V2\\Tubes-KPL-Kelompok05-V.2\\API_TUBES_KPL_KELOMPOK-05\\Data\\DataBuku.json");

            dataGridView1.Rows.Clear();
            foreach (var buku in daftarBuku)
            {
                dataGridView1.Rows.Add(buku.kodeBuku, buku.Judul, buku.Sinopsis, buku.Penulis, buku.TahunTerbit, buku.stok);
            }
        }

        private List<Buku> ReadJsonFile(string filePath)
        {
            string json;
            using (StreamReader sr = new StreamReader(filePath))
            {
                json = sr.ReadToEnd();
            }

            List<Buku> daftarBuku = JsonSerializer.Deserialize<List<Buku>>(json);
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

        public void RefreshDataGridView()
        {
            PopulateDataGridView();
        }

        private void BTNtambah_Click(object sender, EventArgs e)
        {
            TambahBuku formTambahBuku = new TambahBuku();
            formTambahBuku.ShowDialog();
        }

        private void BTNrefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        //ketika menekan 
        private void BTNhapus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedKodeBuku))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    daftarBuku = ReadJsonFile("C:\\TubesKPL\\V2\\Tubes-KPL-Kelompok05-V.2\\API_TUBES_KPL_KELOMPOK-05\\Data\\DataBuku.json");
                    Buku bukuToRemove = daftarBuku.Find(b => b.kodeBuku == selectedKodeBuku);

                    if (bukuToRemove != null)
                    {
                        daftarBuku.Remove(bukuToRemove);
                        WriteJsonFile(daftarBuku, "C:\\TubesKPL\\V2\\Tubes-KPL-Kelompok05-V.2\\API_TUBES_KPL_KELOMPOK-05\\Data\\DataBuku.json");
                        RefreshDataGridView();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }


        private void BTNedit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedKodeBuku))
            {
                Buku bukuToEdit = daftarBuku.Find(b => b.kodeBuku == selectedKodeBuku);
                if (bukuToEdit != null)
                {
                    EditBuku formEditBuku = new EditBuku(bukuToEdit);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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



        public class Buku
        {
            public string kodeBuku { get; set; }
            public string Judul { get; set; }
            public string Penulis { get; set; }
            public string Sinopsis { get; set; }
            public int TahunTerbit { get; set; }
            public int stok { get; set; }
        }

        
    }
}
