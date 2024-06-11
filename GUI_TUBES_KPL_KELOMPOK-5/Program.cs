using MAIN_TUBES_KPL_KELOMPOK_5;

namespace GUI_TUBES_KPL_KELOMPOK_5
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Perpustakaan perpustakaan = new Perpustakaan();
            List<Buku> listBuku = perpustakaan.GetBuku();
            List<Akun> listAkun  = perpustakaan.GetAkun();
            Application.Run(new MenuPengguna());


        }
    }
}