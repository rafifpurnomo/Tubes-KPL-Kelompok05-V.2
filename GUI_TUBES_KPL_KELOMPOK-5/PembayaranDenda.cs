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
    public partial class PembayaranDenda : Form
    {
        public PembayaranDenda(FineManager denda)
        {
            InitializeComponent();
            this.denda = denda;
            label3.Text = "Rp. " + denda.TotalDenda.ToString();
        }

        FineManager denda;


        private void PembayaranDenda_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
