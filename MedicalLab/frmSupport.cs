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
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace MedicalLab
{
    public partial class frmSupport : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmSupport()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txbDetails.Text = string.Empty;
            txbEmail.Text = string.Empty;
            txbLastName.Text = string.Empty;
            txbName.Text = string.Empty;
            txbSubject.Text = string.Empty;
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmSupport_Activated(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'D')
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                btnSend.BackColor = Color.DimGray;
                btnClean.BackColor = Color.DimGray;
                pictureBox1.BackColor = Color.DimGray;
                label6.BackColor = Color.DimGray;
            }
            else if (MedicalLab.Properties.Settings.Default.Theme == 'L')
            {
                this.BackColor = Color.Teal;
                btnSend.BackColor = Color.Azure;
            }
            txbName.Focus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                bool temp = false;

                if (txbName.Text != string.Empty && txbLastName.Text != string.Empty && txbEmail.Text != string.Empty)
                {
                    try
                    {
                        MailAddress m = new MailAddress(txbEmail.Text);
                        temp = true;
                    }
                    catch (FormatException)
                    {
                        temp = false;
                    }

                    if (temp ==true)
                    {
                        //try
                        //{
                        //    MailMessage mail = new MailMessage();
                        //    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                        //    mail.From = new MailAddress(txbEmail.Text);
                        //    mail.To.Add("my mail");
                        //    mail.Subject = txbSubject.Text;
                        //    mail.Body = txbDetails.Text;

                        //    SmtpServer.Port = 587;
                        //    SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                        //    SmtpServer.EnableSsl = true;

                        //    SmtpServer.Send(mail);
                        //    MessageBox.Show("پیام شما به درستی ارسال شد");
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.ToString());
                        //}
                        MessageBox.Show("در حال حاضر به دلیل وجود نداشتن مقصدی برای دریافت پیام شما امکان ارسال ایمیل وجود ندارد", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    else
                    {
                        MessageBox.Show("لطفا مقادیر را به درستی وارد نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("لطفا فیلد های خالی را تکمیل نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbName);
        }

        private void txbLastName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbLastName);
        }
    }
}
