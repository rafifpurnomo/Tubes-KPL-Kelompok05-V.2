using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_TUBES_KPL_KELOMPOK_5
{
    public class UserSession
    {
        public static string namaUser { get; set; }
        public static string No_Anggota { get; set; }
        public static string password { get; set; }
        public static string Role { get; set; }
        public static string no_telpon { get; set; }
        public static int status { get; set; }

        public static void clearSession()
        {
            namaUser = null;
            No_Anggota = null;
            password = null;
            Role = null;
            no_telpon = null;
            status = 0;
        }
    }
}
