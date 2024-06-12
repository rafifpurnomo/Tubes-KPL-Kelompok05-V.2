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
    public partial class DaftarAnggota : Form
    {
        public DaftarAnggota()
        {
            InitializeComponent();
            daftarAnggota = Perpustakaan.ReadJsonFile<List<Akun>>(Perpustakaan.JsonPathAkun, "akun");
            PopulateDataGridView();
        }
        MenuAdmin menuAdmin;
        List<Akun> daftarAnggota = Perpustakaan.ReadJsonFile<List<Akun>>(Perpustakaan.JsonPathAkun, "akun");

        private void PopulateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var anggota in daftarAnggota)
            {
                dataGridView1.Rows.Add(anggota.No_Anggota, anggota.namaUser, anggota.Role, anggota.no_Telpon);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TambahAdmin tambahAdmin = new TambahAdmin();
            tambahAdmin.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TambahAnggotaPerpus tambahAnggotaPerpus = new TambahAnggotaPerpus();
            tambahAnggotaPerpus.Visible = true;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
