using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_TUBES_KPL_KELOMPOK_5
{
    public partial class DaftarBuku : Form
    {
        public DaftarBuku()
        {
            InitializeComponent();
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
    }
}
