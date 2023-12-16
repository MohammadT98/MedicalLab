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
    public partial class frmSetting : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmSetting()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbLight.Checked == true)
                {
                    MedicalLab.Properties.Settings.Default.Theme = 'L';
                    MedicalLab.Properties.Settings.Default.Save();
                    this.BackColor = Color.White;
                    btnSave.BackColor = Color.WhiteSmoke;
                    rdbDark.ForeColor = Color.Black;
                    rdbLight.ForeColor = Color.Black;
                    btnSave.ForeColor = Color.Black;
                    label3.BackColor = Color.MintCream;
                    this.Close();
                }
                else
                {
                    MedicalLab.Properties.Settings.Default.Theme = 'D';
                    MedicalLab.Properties.Settings.Default.Save();
                    this.BackColor = Color.FromArgb(45, 45, 48);
                    btnSave.BackColor = Color.Gray;
                    rdbDark.ForeColor = Color.White;
                    rdbLight.ForeColor = Color.White;
                    btnSave.ForeColor = Color.White;
                    label3.BackColor = Color.FromArgb(45, 45, 48);
                    label3.ForeColor = Color.White;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSetting_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmSetting_Activated(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L')
            {
                rdbLight.Checked = true;
                this.BackColor = Color.White;
                btnSave.BackColor = Color.WhiteSmoke;
                rdbDark.ForeColor = Color.Black;
                rdbLight.ForeColor = Color.Black;
                btnSave.ForeColor = Color.Black;
                label3.BackColor = Color.MintCream;
            }
            else
            {
                rdbDark.Checked = true;
                this.BackColor = Color.FromArgb(45, 45, 48);
                btnSave.BackColor = Color.Gray;
                rdbDark.ForeColor = Color.White;
                rdbLight.ForeColor = Color.White;
                btnSave.ForeColor = Color.White;
                label3.BackColor = Color.FromArgb(45, 45, 48);
                label3.ForeColor = Color.White;
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmSetting_Layout(object sender, LayoutEventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L')
            {
                rdbLight.Checked = true;
                this.BackColor = Color.White;
                btnSave.BackColor = Color.WhiteSmoke;
                rdbDark.ForeColor = Color.Black;
                rdbLight.ForeColor = Color.Black;
                btnSave.ForeColor = Color.Black;
                label3.BackColor = Color.MintCream;
            }
            else
            {
                rdbDark.Checked = true;
                this.BackColor = Color.FromArgb(45, 45, 48);
                btnSave.BackColor = Color.Gray;
                rdbDark.ForeColor = Color.White;
                rdbLight.ForeColor = Color.White;
                btnSave.ForeColor = Color.White;
                label3.BackColor = Color.FromArgb(45, 45, 48);
                label3.ForeColor = Color.White;
            }
        }
    }
}
