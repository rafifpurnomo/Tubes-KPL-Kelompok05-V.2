using MAIN_TUBES_KPL_KELOMPOK_5;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GUI_TUBES_KPL_KELOMPOK_5
{
    public partial class LoginPage : Form
    {
        private List<Akun> dataAkun;

        public LoginPage()
        {
            InitializeComponent();

            dataAkun = new List<Akun>();
            string filePath = "C:\\TubesKPL\\V2\\Tubes-KPL-Kelompok05-V.2\\API_TUBES_KPL_KELOMPOK-05\\Data\\DataAkun.json";
            readAkunJson(filePath);
        }


        private List<Akun> readAkunJson(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                this.dataAkun = JsonSerializer.Deserialize<List<Akun>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error reading JSON file: " + ex.Message);
            }
            return dataAkun;
        }

        private Akun validateLogin(string noAnggota, string password)
        {
            for (int i = 0; i < dataAkun.Count; i++)
            {
                if ((noAnggota == dataAkun[i].No_Anggota) && (password == dataAkun[i].password))
                {
                    return dataAkun[i];
                }
            }
            return null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string noAnggota = usernameInput.Text;
            string password = passInput.Text;
            
            try
            {
               
                Akun userLogin = validateLogin(noAnggota, password);
                if (userLogin != null)
                {
                    if (userLogin.Role.Equals("Admin"))
                    {
                        MenuAdmin menuadmin = new MenuAdmin();
                        menuadmin.Visible = true;
                        this.Visible = false;
                    } else if (userLogin.Role.Equals("Anggota Perpustakaan"))
                    {
                        MenuPengguna menuPengguna = new MenuPengguna();
                        menuPengguna.Visible = true;
                        this.Visible = false;
                    }
                } else
                {
                    MessageBox.Show("no anggota atau password salah");
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
