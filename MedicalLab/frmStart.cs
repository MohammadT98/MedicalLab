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
using System.Data.OleDb;

namespace MedicalLab
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
            display();

            txbUserPass.PasswordChar = '*';
        }

        bool tempPass = true;

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=MedicalLabDBAccess.mdb");
        OleDbCommand cmd = new OleDbCommand();

        void display()
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter();
            adp.SelectCommand = new OleDbCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "select * from TBLUser";
            adp.Fill(ds, "TBLUser");

            dgvTemp.DataSource = ds;
            dgvTemp.DataMember = "TBLUser";
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                bool temp = false;

                for (int i = 0; i < dgvTemp.Rows.Count - 1; i++)
                {
                    if (dgvTemp.Rows[i].Cells[1].Value.ToString().Trim() == txbUserName.Text.Trim() && dgvTemp.Rows[i].Cells[2].Value.ToString().Trim() == txbUserPass.Text)
                    {
                        temp = true;
                        break;
                    }
                }

                if (temp == true)
                {
                    frmMain form2 = new frmMain();
                    form2.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("لطفا نام کاربری یا رمز خود را به درستی وارد کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnter_MouseEnter(object sender, EventArgs e)
        {
            btnEnter.BackColor = Color.FromArgb(39, 46, 59);
            btnEnter.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnEnter_MouseLeave(object sender, EventArgs e)
        {
            btnEnter.BackColor = Color.FromArgb(255, 255, 255);
            btnEnter.ForeColor = Color.Black;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.DarkRed;
            btnClose.ForeColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
            btnClose.ForeColor = Color.DarkRed;
        }

        private void btnPassChar_Click(object sender, EventArgs e)
        {
            if (tempPass == true)
            {
                txbUserPass.PasswordChar = '\0';
                tempPass = false;
            }
            else if (tempPass == false)
            {
                txbUserPass.PasswordChar = '*';
                tempPass = true;
            }
        }

        private void txbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbUserPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmStart_Activated(object sender, EventArgs e)
        {
            txbUserName.Focus();
        }
    }
}
