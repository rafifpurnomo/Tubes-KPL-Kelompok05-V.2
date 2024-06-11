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

    }
}
