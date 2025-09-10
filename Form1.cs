using System.Text.RegularExpressions;

namespace Kasir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusn.Text.Trim();
            string password = txtpw.Text;

            // ✅ Validasi Username tidak boleh kosong
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username tidak boleh kosong!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Validasi Password minimal 5 karakter + campuran huruf & angka
            if (password.Length < 5)
            {
                MessageBox.Show("Password minimal 5 karakter!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(password, @"[A-Za-z]")) // cek ada huruf
            {
                MessageBox.Show("Password harus mengandung huruf!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(password, @"[0-9]")) // cek ada angka
            {
                MessageBox.Show("Password harus mengandung angka!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Kalau semua syarat lolos → login dianggap berhasil
            MessageBox.Show("Login berhasil!\nSelamat datang, " + username,
                "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form2 kasir = new Form2();
            kasir.Show();
            this.Hide();
        }
        private void btnlogin_MouseEnter(object sender, EventArgs e)
        {
            btnlogin.BackColor = Color.RoyalBlue;  // warna saat mouse di atas tombol
        }
        private void btnlogin_MouseLeave(object sender, EventArgs eventArgs)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnlogin.BackColor = Color.DodgerBlue; // warna balik ke semula
        }
    }
}
