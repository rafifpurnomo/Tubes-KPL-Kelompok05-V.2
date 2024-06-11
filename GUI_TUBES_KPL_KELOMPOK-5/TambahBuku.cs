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
    public partial class TambahBuku : Form
    {
        public TambahBuku()
        {
            InitializeComponent();
        }

        private void TambahBuku_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            Buku newBook = new Buku(
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                int.Parse(textBox5.Text),
                int.Parse(textBox6.Text)
            );

            List<Buku> daftarBuku = ReadJsonFile("C:\\TubesKPL\\V2\\Tubes-KPL-Kelompok05-V.2\\API_TUBES_KPL_KELOMPOK-05\\Data\\DataBuku.json");
            daftarBuku.Add(newBook);
            WriteJsonFile(daftarBuku, "C:\\TubesKPL\\V2\\Tubes-KPL-Kelompok05-V.2\\API_TUBES_KPL_KELOMPOK-05\\Data\\DataBuku.json");

            DaftarBuku.Instance.RefreshDataGridView();
            this.Close();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
