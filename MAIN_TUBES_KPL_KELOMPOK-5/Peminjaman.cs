using LIBRARY_TUBES_KPL_KELOMPOK_05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_TUBES_KPL_KELOMPOK_5
{
    public class Peminjaman
    {
        public static int ID_count = 1;

        public string ID_Peminjaman { get; set; }
        public Akun Peminjam { get; set; }
        public string JudulBuku { get; set; }
        public string TanggalPinjam { get; set; }
        public string DeadLinePengembalian { get; set; }
        public string TanggalPengembalian { get; set; }
        public string keteranganPenggembalian { get; set; }
        public bool statusPengembalian { get; set; }
        private FineManager FineManager { get; set; }

        public Peminjaman(string JudulBuku, Akun Peminjam, string TanggalPinjam, string DeadLinePengembalian)
        {
            this.ID_Peminjaman = ID_count.ToString();
            this.JudulBuku = JudulBuku;
            this.Peminjam = Peminjam;
            this.TanggalPinjam = TanggalPinjam;
            DateTime dateTime =  StringLibrary.KonversiStringKeDate(TanggalPinjam).AddDays(7);
            this.DeadLinePengembalian = StringLibrary.KonversiDateKeString(dateTime);
            this.statusPengembalian = false;
            this.keteranganPenggembalian = "Belum Dikembalikan";
            ID_count++;
        }

        public FineManager GetFineManager()
        {
            if (!statusPengembalian)
            {
                string tglPengembalian = StringLibrary.KonversiDateKeString(DateTime.Now.AddDays(30));
                FineManager fineManagerBaru = new FineManager(DeadLinePengembalian,tglPengembalian );
                this.FineManager = fineManagerBaru;
                return fineManagerBaru;
            }
            else
            {
                return null;
            }
        }

        public void setStatusPengembalian()
        {
            statusPengembalian = true;
            keteranganPenggembalian = "Sudah Dikembalikan";
            TanggalPengembalian = StringLibrary.KonversiDateKeString(DateTime.Now);
        }
    }
}
