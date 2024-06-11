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
    public partial class TambahBuku : Form
    {
        public string filePathDataBuku = "C:\\Users\\Rafif Purnomo\\OneDrive\\Documents\\Coding\\C#\\Tubes-KPL-Kelompok05-V.2\\GUI_TUBES_KPL_KELOMPOK-5\\Data\\DataBuku.json";

        public Buku newBuku;

        public TambahBuku()
        {
            InitializeComponent();
            ReadJsonFile(filePathDataBuku);
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

        public void WriteJSON(List<Buku> DATABUKU)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(DATABUKU, options);
            File.WriteAllText(filePathDataBuku, jsonString);
        }

        private void TambahBuku_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Buku> dataBuku = ReadJsonFile(filePathDataBuku);

            string kodeBuku = textBox1.Text;
            string judulBuku = textBox2.Text;
            string sinopsis = textBox3.Text;
            string penulis = textBox4.Text;
            int tahunTerbit = int.Parse(textBox5.Text);
            int jumlahBuku = (int)numericUpDown1.Value;

            Boolean statusBuku = statusBook(dataBuku, kodeBuku);

            if (statusBuku)
            {
                MessageBox.Show("kode buku sudah ada");
            }
            else
            {
                newBuku = new Buku(kodeBuku, judulBuku, sinopsis, penulis, tahunTerbit, jumlahBuku);
                dataBuku.Add(newBuku);
                WriteJSON(dataBuku);
                MessageBox.Show("Buku baru berhasil di tambahkan");
            }
        }

        public Boolean statusBook(List<Buku> DATABUKU, string kodeBuku)
        {
            for (int i = 0; i < DATABUKU.Count; i++)
            {
                if (DATABUKU[i].kodeBuku.Equals(kodeBuku))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
