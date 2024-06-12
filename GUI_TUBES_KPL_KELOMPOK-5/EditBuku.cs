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
    public partial class EditBuku : Form
    {
        private Buku bukuToEdit;
        private string filePathDataBuku = "C:\\TubesKPL\\V2\\Tubes-KPL-Kelompok05-V.2\\GUI_TUBES_KPL_KELOMPOK-5\\Data\\DataBuku.json";

        public EditBuku(Buku bukuToEdit)
        {
            InitializeComponent();
            this.bukuToEdit = bukuToEdit;

            // Populate the form fields with the existing book data
            textBox1.Text = bukuToEdit.kodeBuku;
            textBox2.Text = bukuToEdit.Judul;
            textBox3.Text = bukuToEdit.Sinopsis;
            textBox4.Text = bukuToEdit.Penulis;
            textBox5.Text = bukuToEdit.TahunTerbit.ToString();
            numericUpDown1.Value = bukuToEdit.stok;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            List<Buku> dataBuku = ReadJsonFile(filePathDataBuku);

            // Mencegah agar Menginputkan KodeBuku yang sama ke data
            Boolean statusBuku = statusBook(dataBuku, textBox1.Text);

            if (statusBuku && textBox1.Text != bukuToEdit.kodeBuku)
            {
                MessageBox.Show("Kode buku sudah ada. Masukkan kode buku yang berbeda.");
                return;
            }

            // Konfirmasi sebelum menyimpan perubahan
            var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menyimpan perubahan?",
                                                 "Konfirmasi Simpan Perubahan",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Buku buku = dataBuku.Find(b => b.kodeBuku == bukuToEdit.kodeBuku);

                if (buku != null)
                {
                    // Update book details
                    buku.kodeBuku = textBox1.Text;
                    buku.Judul = textBox2.Text;
                    buku.Sinopsis = textBox3.Text;
                    buku.Penulis = textBox4.Text;
                    buku.TahunTerbit = int.Parse(textBox5.Text);
                    buku.stok = (int)numericUpDown1.Value;

                    // Write the updated list to the file
                    WriteJSON(dataBuku);

                    MessageBox.Show("Detail buku berhasil diperbarui.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Buku tidak ditemukan.");
                }
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

        public void WriteJSON(List<Buku> DATABUKU)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(DATABUKU, options);
            File.WriteAllText(filePathDataBuku, jsonString);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBuku_Load(object sender, EventArgs e)
        {

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

        private void EditBuku_Load_1(object sender, EventArgs e)
        {

        }
    }
}
