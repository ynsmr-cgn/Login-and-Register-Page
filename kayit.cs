using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace LoginPage
{
    public partial class formKayit : Form
    {
        public formKayit()
        {
            InitializeComponent();
        }

        loginClasses c = new loginClasses();

        private void txtboxMail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtboxMail.Text;
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Geçerli bir e posta adresi giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBehind_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void Clear()
        {
            txtboxisim.Text = string.Empty;
            txtboxSoyisim.Text = string.Empty;
            txtboxKullanici.Text = string.Empty;
            txtboxMail.Text = string.Empty;
            txtboxSifre.Text = string.Empty;
            txtboxSifreOnay.Text = string.Empty;
            txtboxNumber.Text = string.Empty;
            chckboxOnayliyorum.Checked = false;
            chckboxYDizin.Checked = false;
            chckboxHaberizin.Checked = true;
        }

        public string haber_izin = "Onaylıyorum";
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if(chckboxHaberizin.Checked == true)
            {
                haber_izin = "Onaylıyorum";
            }
            else
            {
                haber_izin = "Onaylamıyorum";
            }

            if (txtboxisim.Text == "" || txtboxSoyisim.Text == "" || txtboxKullanici.Text == "" || txtboxMail.Text == "" || txtboxSifre.Text == "" || txtboxSifreOnay.Text == "" || txtboxNumber.Text == "")
            {
                MessageBox.Show("Lütfen boş yer bırakmayınız!");
            }
            else
            {
                c.name = txtboxisim.Text;
                c.lastname = txtboxSoyisim.Text.ToUpper();
                c.username = txtboxKullanici.Text;
                c.mail = txtboxMail.Text;
                c.password = txtboxSifre.Text;
                c.tel_number = txtboxNumber.Text;
                c.gender = cmbCinsiyet.Text;
                c.news = haber_izin;

                if (txtboxSifre.Text != txtboxSifreOnay.Text)
                {
                    MessageBox.Show("Lütfen şifreleri kontrol edip tekrar deneyiniz.");
                }
                else
                {
                    if (chckboxOnayliyorum.Checked == false || chckboxYDizin.Checked == false)
                    {
                        MessageBox.Show("Aydınlatma iznini ve yurt dışı iznini onaylamanız gerekmektedir.");
                    }
                    else
                    {
                        bool success = c.Insert(c);
                        if (success == true)
                        {
                            MessageBox.Show("Başarıyla kayıt olundu!");
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt olurken bir hatayla karşılaşıldı, lütfen bilgileri kontrol edip tekrar deneyiniz.");
                        }

                    }

                }

            } 

        }

        private void txtboxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\x03' && e.KeyChar != '\x16' && e.KeyChar != '\x18' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private bool ContainsSpecialCharacters(string s)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]");
            return regex.IsMatch(s);
        }

        private void txtboxSifre_MouseHover(object sender, EventArgs e)
        {
            ttipSifreBilgiGoster.SetToolTip(txtboxSifre, "-Şifre en az 5 karakter uzunluğunda olmalı");
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

        private void txtboxSifre_Leave(object sender, EventArgs e)
        {
            string sifre = txtboxSifre.Text;

            if (sifre.Length < 5)
            {
                MessageBox.Show("Şifre minimum 5 karakter uzunluğunda olmalı.");
                return;
            }
        }
    }
}
