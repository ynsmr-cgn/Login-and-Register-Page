using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Data.SqlClient;

namespace LoginPage
{
    public partial class formGiris : Form
    {
        public formGiris()
        {
            InitializeComponent();
        }
        //Here
        loginClasses c = new loginClasses();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBehind_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private formKayit kayit_ = null;
        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (kayit_ != null && !kayit_.IsDisposed)
            {
                kayit_.WindowState = FormWindowState.Normal;
                kayit_.Focus();
            }
            else
            {
                kayit_ = new formKayit();
                kayit_.Show();
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void txtboxBackground_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
        }

        private void lblHesapMerkezi_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
        }

        static string login_dt = ConfigurationManager.ConnectionStrings["login_database"].ConnectionString;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtboxKullanici.Text;
            string sifre = txtboxSifre.Text;

            string sql = "SELECT COUNT(*) FROM login_table WHERE username = @username AND password = @password";
            SqlConnection sc = new SqlConnection(login_dt);
            SqlCommand cmd = new SqlCommand(sql, sc);

            cmd.Parameters.AddWithValue("@username", kullaniciadi);
            cmd.Parameters.AddWithValue("@password", sifre);

            sc.Open();

            int result = (int)cmd.ExecuteScalar();
            if (result > 0)
            {
                MessageBox.Show("Giriş başarılı!");

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
        }
    }
}
