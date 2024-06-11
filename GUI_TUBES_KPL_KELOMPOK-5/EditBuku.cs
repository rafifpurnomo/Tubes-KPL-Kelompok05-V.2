using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAIN_TUBES_KPL_KELOMPOK_5;

namespace GUI_TUBES_KPL_KELOMPOK_5
{
    public partial class EditBuku : Form
    {
        private DaftarBuku.Buku buku;

        public EditBuku(DaftarBuku.Buku buku)
        {
            InitializeComponent();
            this.buku = buku;
            FillForm();
        }

        private void FillForm()
        {
            textBox1.Text = buku.kodeBuku;
            textBox2.Text = buku.Judul;
            textBox3.Text = buku.Penulis;
            textBox4.Text = buku.Sinopsis;
            textBox5.Text = buku.TahunTerbit.ToString();
            textBox6.Text = buku.stok.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox5.Text, out int tahunTerbit) && int.TryParse(textBox6.Text, out int stok))
            {
                buku.Judul = textBox2.Text;
                buku.Penulis = textBox3.Text;
                buku.Sinopsis = textBox4.Text;
                buku.TahunTerbit = tahunTerbit;
                buku.stok = stok;

                DaftarBuku.Instance.RefreshDataGridView();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for Tahun Terbit and Stok.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveChanges()
        {
            // Save changes to JSON file
            //string filePath = "C:\\TubesKPL\\V2\\Tubes-KPL-Kelompok05-V.2\\API_TUBES_KPL_KELOMPOK-05\\Data\\DataBuku.json";
            //List<DaftarBuku.Buku> daftarBuku = DaftarBuku.Instance.ReadJsonFile(filePath);

            // Find and update the book in the list
            //int index = daftarBuku.FindIndex(b => b.kodeBuku == buku.kodeBuku);
            //if (index != -1)
            //{
            //    daftarBuku[index] = buku;
            //}

            //DaftarBuku.Instance.WriteJsonFile(daftarBuku, filePath);
        }
    }
}
