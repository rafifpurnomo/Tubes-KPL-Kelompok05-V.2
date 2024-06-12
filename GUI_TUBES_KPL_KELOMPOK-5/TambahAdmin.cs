using MAIN_TUBES_KPL_KELOMPOK_5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_TUBES_KPL_KELOMPOK_5
{
    public partial class TambahAdmin : Form
    {
        public string filePathDataAakun = "D:\\Coding\\C#\\KPL Clone\\Tubes-KPL-Kelompok05-V.2\\GUI_TUBES_KPL_KELOMPOK-5\\Data\\DataAkun.json";
        public TambahAdmin()
        {
            InitializeComponent();
        }

        public List<Akun> ReadJson(string filePath)
        {
            List<Akun> dataAkun = new List<Akun>();
            string json;
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    json = reader.ReadToEnd();
                }

                dataAkun = JsonSerializer.Deserialize<List<Akun>>(json);
            } catch(Exception ex)
            {
                MessageBox.Show("Error reading JSON file: " + ex.Message);
            }
            return dataAkun;
        }

        public void WriteJSON(List<Akun> DATAAKUN)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(DATAAKUN, options);
            File.WriteAllText(filePathDataAakun, jsonString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Akun> dataAkun = ReadJson(filePathDataAakun);

            string noAnggota = textBox1.Text;
            string namaAnggota = textBox2.Text;
            string password = textBox3.Text;
            string confirmPass = textBox4.Text; 
            string noTelp = textBox5.Text;
            string role = "Admin";

            Boolean statusNoAnggota = validateNoAnggota(dataAkun, noAnggota);

            if (statusNoAnggota)
            {
                MessageBox.Show("Anggota sudah terdaftar");
            } else
            {
                Boolean passLength = validateLengthPass(password);
                
                if (passLength)
                {
                    Boolean confirmpass = validatePassword(password, confirmPass);

                    if (confirmpass)
                    {
                        Akun newAkun = new  Akun(namaAnggota, noAnggota, password, role, noTelp);
                        dataAkun.Add(newAkun);
                        WriteJSON(dataAkun);
                        MessageBox.Show("Admin baru berhasil di tambahkan");
                    } else
                    {
                        MessageBox.Show("konfirmasi password salah");
                    }
                } else
                {
                    MessageBox.Show("minimal password 6 huruf dan maksimal 20 huruf");
                }
            }
        }

        public Boolean validateNoAnggota(List<Akun> dataAkun,string noAnggota)
        {
            for (int i = 0; i < dataAkun.Count; i++)
            {
                if (noAnggota.Equals( dataAkun[i].No_Anggota))
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean validatePassword(string password, string confirmPass)
        {
            if (confirmPass.Equals(password))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public Boolean validateLengthPass(string password)
        {
            return password.Length >= 6 && password.Length <= 20;
        }



    }
}
