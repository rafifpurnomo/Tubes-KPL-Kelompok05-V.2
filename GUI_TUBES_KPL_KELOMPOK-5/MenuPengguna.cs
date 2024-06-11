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
            label2.Text = UserSession.namaUser;
        }
        public static PeminjamanBuku peminjamanBuku;

        private void button1_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            PeminjamanBuku peminjamanBuku = new PeminjamanBuku(this);
            peminjamanBuku.Show();
        }

        private void daftarPinjaman_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            DaftarPeminjamanPengguna daftarPeminjamanPengguna = new DaftarPeminjamanPengguna(this);
            daftarPeminjamanPengguna.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserSession.clearSession();
            LoginPage newLogin = new LoginPage();
            newLogin.Visible = true;
            this.Dispose();
        }
    }
}
