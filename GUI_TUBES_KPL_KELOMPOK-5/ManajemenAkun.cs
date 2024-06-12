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
    public partial class ManajemenAkun : Form
    {
        public ManajemenAkun()
        {
            InitializeComponent();
        }

        private void ManajemenAkun_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TambahAdmin tambahAdmin = new TambahAdmin();
            tambahAdmin.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TambahAnggotaPerpus tambahAnggotaPerpus = new TambahAnggotaPerpus();
            tambahAnggotaPerpus.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
