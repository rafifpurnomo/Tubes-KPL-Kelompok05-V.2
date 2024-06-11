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
    public partial class DaftarPeminjamanPengguna : Form
    {
        public DaftarPeminjamanPengguna(MenuPengguna menuPengguna)
        {
            InitializeComponent();
            this.menuPengguna = menuPengguna;
        }
        MenuPengguna menuPengguna;

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            menuPengguna.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
