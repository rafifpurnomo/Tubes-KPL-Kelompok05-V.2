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
using System.Diagnostics.Eventing.Reader;

namespace GUI_TUBES_KPL_KELOMPOK_5
{
    public partial class DaftarPeminjamanPengguna : Form
    {
        public DaftarPeminjamanPengguna(MenuPengguna menuPengguna)
        {
            InitializeComponent();
            this.menuPengguna = menuPengguna;
            PopulateDataGridView();
        }
        MenuPengguna menuPengguna;
        List<Peminjaman> daftarPeminjaman = Perpustakaan.ReadJsonFile<List<Peminjaman>>(Perpustakaan.JsonPathPeminjaman, "peminjaman");

        public void PopulateDataGridView()
        {
            

            foreach (var peminjaman in daftarPeminjaman)
            {
                if (peminjaman.Peminjam.namaUser == UserSession.namaUser && peminjaman.statusPengembalian)
                {
                    dataGridView1.Rows.Add(peminjaman.ID_Peminjaman, UserSession.namaUser, peminjaman.JudulBuku, peminjaman.TanggalPinjam, peminjaman.DeadLinePengembalian, peminjaman.TanggalPengembalian, "Sudah Dikembalikan");
                }
                else if (peminjaman.Peminjam.namaUser == UserSession.namaUser && !peminjaman.statusPengembalian)
                {
                    dataGridView1.Rows.Add(peminjaman.ID_Peminjaman, UserSession.namaUser, peminjaman.JudulBuku, peminjaman.TanggalPinjam, peminjaman.DeadLinePengembalian, peminjaman.TanggalPengembalian, peminjaman.keteranganPenggembalian);
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            menuPengguna.Show();
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
                    new DetailPeminjamanBuku(peminjaman).ShowDialog();
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

        private void DaftarPeminjamanPengguna_Load(object sender, EventArgs e)
        {

        }
    }
}
