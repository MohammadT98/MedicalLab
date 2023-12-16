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

namespace MedicalLab
{
    public partial class frmMessageBox1 : Form
    {
        public frmMessageBox1()
        {
            InitializeComponent();

            if (MedicalLab.Properties.Settings.Default.Theme == 'L') this.BackColor = Color.White;
            else
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                label1.ForeColor = Color.White;
                btnYes.ForeColor = Color.White;
                btnNo.ForeColor = Color.White;
                btnYes.BackColor = Color.Gray;
                btnNo.BackColor = Color.Gray;
                pictureBox1.BackColor = Color.Gray;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnYes.BackColor = Color.SlateGray;
            else
            {
                btnYes.BackColor = Color.LightGray;
                btnYes.ForeColor = Color.Black;
            }
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnYes.BackColor = Color.White;
            else
            {
                btnYes.BackColor = Color.Gray;
                btnYes.ForeColor = Color.White;
            }
        }

        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnNo.BackColor = Color.SlateGray;
            else
            {
                btnNo.BackColor = Color.LightGray;
                btnNo.ForeColor = Color.Black;
            }
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnNo.BackColor = Color.White;
            else
            {
                btnNo.BackColor = Color.Gray;
                btnNo.ForeColor = Color.White;
            }
        }
    }
}
