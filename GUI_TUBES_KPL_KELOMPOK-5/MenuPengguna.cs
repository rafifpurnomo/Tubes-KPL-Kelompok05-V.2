using MAIN_TUBES_KPL_KELOMPOK_5;
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
    public partial class MenuPengguna : Form
    {
        public MenuPengguna()
        {
            InitializeComponent();
            namaUserDisplay.Text = SesiLogin.namaUser;
        }

        private void MenuPengguna_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pinjamBukuBTN_Click(object sender, EventArgs e)
        {
            Peminjaman pinjamBuku = new Peminjaman();
            pinjamBuku.Visible = true;
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            SesiLogin.clearSession();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Dispose();
        }
    }
}
