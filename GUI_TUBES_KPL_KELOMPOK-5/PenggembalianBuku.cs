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
    public partial class PenggembalianBuku : Form
    {
        public PenggembalianBuku(Peminjaman peminjamanBuku)
        {
            InitializeComponent();
            this.peminjamanBuku = peminjamanBuku;
            setTextPenggembalianBuku();
        }

        Peminjaman peminjamanBuku;

        private void setTextPenggembalianBuku()
        {

            label_id.Text = peminjamanBuku.ID_Peminjaman;
            label_nama.Text = peminjamanBuku.Peminjam.namaUser;
            label_buku.Text = peminjamanBuku.JudulBuku;
            label_tglPeminjaman.Text = peminjamanBuku.TanggalPinjam;
            label_tenggatWaktu.Text = peminjamanBuku.DeadLinePengembalian;
            label_statusPengembalian.Text = peminjamanBuku.keteranganPenggembalian;
        }
    }
}
