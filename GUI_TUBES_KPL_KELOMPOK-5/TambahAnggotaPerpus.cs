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
    public partial class TambahAnggotaPerpus : Form
    {
        public string filePathDataAakun = "D:\\Coding\\C#\\KPL Clone\\Tubes-KPL-Kelompok05-V.2\\GUI_TUBES_KPL_KELOMPOK-5\\Data\\DataAkun.json";
        public TambahAnggotaPerpus()
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
            }
            catch (Exception ex)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Akun> dataAkun = ReadJson(filePathDataAakun);

            string noAnggota = tbNoAnggota.Text;
            string nama = tbNama.Text;
            string password = tbPassword.Text;
            string confirmPass = tbConfirmPass.Text;
            string role = "Anggota Perpustakaan";
            string noTelpon = tbNoTelpon.Text;
            //int status = 0;

            // Memvalidasi input
            bool isValid = true;
            string errorMessage = "";

            // Validasi TextBox tidak boleh kosong
            if (string.IsNullOrWhiteSpace(noAnggota) || string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPass) || string.IsNullOrWhiteSpace(noTelpon))
            {
                isValid = false;
                errorMessage += "Semua field harus diisi.\n";
            }

            // Validasi no anggota tidak boleh sama
            if (dataAkun.Any(a => a.No_Anggota == noAnggota))
            {
                isValid = false;
                errorMessage += "No Anggota sudah ada.\n";
            }

            // Validasi panjang password
            if (password.Length < 6 || password.Length > 20)
            {
                isValid = false;
                errorMessage += "Password harus terdiri dari 6-20 karakter.\n";
            }

            // Validasi password dan confirm password harus sama
            if (password != confirmPass)
            {
                isValid = false;
                errorMessage += "Password dan Confirm Password tidak sama.\n";
            }

            if (isValid)
            {
                // Membuat objek Akun baru
                Akun akun = new Akun(nama, noAnggota, password, role, noTelpon)
                {
                    namaUser = nama,
                    password = password,
                    No_Anggota = noAnggota,
                    Role = role,
                    no_Telpon = noTelpon,
                };

                // Menambahkan objek Akun baru ke daftar dataAkun
                dataAkun.Add(akun);
                // Menulis kembali daftar dataAkun ke file JSON
                WriteJSON(dataAkun);
                // Membersihkan TextBox setelah berhasil menyimpan
                tbNoAnggota.Clear();
                tbNama.Clear();
                tbPassword.Clear();
                tbConfirmPass.Clear();
                tbNoTelpon.Clear();

                MessageBox.Show("Data anggota baru berhasil disimpan.");
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
