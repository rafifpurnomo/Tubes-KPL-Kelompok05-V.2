using System.Windows.Forms;
using MAIN_TUBES_KPL_KELOMPOK_5;

namespace GUI_TUBES_KPL_KELOMPOK_5
{
    public partial class DetailBuku : Form
    {
        private Buku buku;

        public DetailBuku(Buku buku)
        {
            InitializeComponent();
            this.buku = buku;
            TampilkanDetailBuku();
        }

        private void TampilkanDetailBuku()
        {
            labelKodeBuku.Text = buku.kodeBuku;
            labelJudul.Text = buku.Judul;
            labelPenulis.Text = buku.Penulis;
            labelTahunTerbit.Text = buku.TahunTerbit.ToString();
            labelStok.Text = buku.stok.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelJudul_Click(object sender, EventArgs e)
        {

        }

        private void labelKodeBuku_Click(object sender, EventArgs e)
        {

        }

        private void labelTahunTerbit_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Pinjam_Click(object sender, EventArgs e)
        {

        }
    }
}
