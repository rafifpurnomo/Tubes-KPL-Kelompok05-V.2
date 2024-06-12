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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManajemenAkun manajemenAkun = new ManajemenAkun();  
            manajemenAkun.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            new DaftarBuku().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserSession.clearSession();
            LoginPage loginPage = new LoginPage();  
            loginPage.Visible = true;
            this.Dispose();
        }
    }
}
