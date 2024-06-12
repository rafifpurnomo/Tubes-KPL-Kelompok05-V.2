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
    public partial class ManajemenPeminjaman : Form
    {
        public ManajemenPeminjaman()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            PopulateDataGridView();
        }
        List<Peminjaman> daftarPeminjaman = Perpustakaan.ReadJsonFile<List<Peminjaman>>(Perpustakaan.JsonPathPeminjaman, "peminjaman");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void PopulateDataGridView()
        {
            foreach (var peminjaman in daftarPeminjaman)
            {
                dataGridView1.Rows.Add(peminjaman.ID_Peminjaman, peminjaman.Peminjam.namaUser, peminjaman.JudulBuku, peminjaman.TanggalPinjam, peminjaman.DeadLinePengembalian, peminjaman.TanggalPengembalian, peminjaman.keteranganPenggembalian);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string idPeminjaman = row.Cells[0].Value.ToString();
                Peminjaman peminjaman = searchPeminjamanById(idPeminjaman, daftarPeminjaman);
                if (peminjaman != null)
                {
                    new DetailPengembalianBuku(peminjaman).ShowDialog();
                }
            };
        }

        private Peminjaman searchPeminjamanById(string idPeminjaman, List<Peminjaman> peminjaman)
        {
            for (int i = 0; i < peminjaman.Count; i++)
            {
                if (peminjaman[i].ID_Peminjaman == idPeminjaman)
                {
                    return peminjaman[i];
                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
