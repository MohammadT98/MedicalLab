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
using System.Text.RegularExpressions;

namespace MedicalLab
{
    public partial class frmCenterSpecifications : Form
    {
        public frmCenterSpecifications()
        {
            InitializeComponent();

            btnSave.Visible = false;

            display();

            txbCode.Text = dgvCenterSpecifications[1, 0].Value.ToString();
            txbName.Text = dgvCenterSpecifications[2, 0].Value.ToString();
            txbPhone1.Text = dgvCenterSpecifications[3, 0].Value.ToString();
            txbPhone2.Text = dgvCenterSpecifications[4, 0].Value.ToString();
            txbPhone3.Text = dgvCenterSpecifications[5, 0].Value.ToString();
            txbState.Text = dgvCenterSpecifications[6, 0].Value.ToString();
            txbCity.Text = dgvCenterSpecifications[7, 0].Value.ToString();
            txbAddress.Text = dgvCenterSpecifications[8, 0].Value.ToString();
        }

        //capability of moving the form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        //Represents an open connection to a data source
        OleDbConnection con1 = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=MedicalLabDBAccess.mdb");
        //for execute actions on database
        OleDbCommand cmd1 = new OleDbCommand();


        //display data from access database
        void display()
        {
            //Represents an in-memory cache of data
            DataSet ds = new DataSet();
            //Represents a set of data commands and a database connection that are used to fill the DataSet and update the data source
            OleDbDataAdapter adp = new OleDbDataAdapter();
            adp.SelectCommand = new OleDbCommand();
            adp.SelectCommand.Connection = con1;
            adp.SelectCommand.CommandText = "select * from TBLCenterSpecifications";
            //fill the dataset from tabel of database
            adp.Fill(ds, "TBLCenterSpecifications");

            dgvCenterSpecifications.DataSource = ds;
            dgvCenterSpecifications.DataMember = "TBLCenterSpecifications";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //capability of moving the form
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            btnChange.Visible = false;
            btnSave.Visible = true;
            txbAddress.ReadOnly = false;
            txbCity.ReadOnly = false;
            txbCode.ReadOnly = false;
            txbName.ReadOnly = false;
            txbPhone1.ReadOnly = false;
            txbPhone2.ReadOnly = false;
            txbPhone3.ReadOnly = false;
            txbState.ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbCode.Text != string.Empty && txbName.Text != string.Empty && txbPhone1.Text != string.Empty && txbState.Text != string.Empty && txbCity.Text != string.Empty && txbAddress.Text != string.Empty)
                {
                    DialogResult res = MessageBox.Show("آیا از انجام تغییرات مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        ToPersian.EngNumToPrs(txbCode);
                        cmd1.Parameters.Clear();
                        cmd1.Connection = con1;
                        cmd1.CommandText = "update TBLCenterSpecifications set CenterCode = @Code, CenterName = @Name, CenterPhone1 = @Phone1, CenterPhone2= @Phone2, CenterPhone3= @Phone3, CenterState = @State , CenterCity = @City, CenterAddress = @Address where CenterCode = @CenterCode";
                        cmd1.Parameters.AddWithValue("@Code", txbCode.Text.Trim());
                        cmd1.Parameters.AddWithValue("@Name", txbName.Text.Trim());
                        cmd1.Parameters.AddWithValue("@Phone1", txbPhone1.Text.Trim());
                        cmd1.Parameters.AddWithValue("@Phone2", txbPhone2.Text.Trim());
                        cmd1.Parameters.AddWithValue("@Phone3", txbPhone3.Text.Trim());
                        cmd1.Parameters.AddWithValue("@State", txbState.Text.Trim());
                        cmd1.Parameters.AddWithValue("@City", txbCity.Text.Trim());
                        cmd1.Parameters.AddWithValue("@Address", txbAddress.Text.Trim());
                        cmd1.Parameters.AddWithValue("@CenterCode", dgvCenterSpecifications[1, 0].Value.ToString().Trim());
                        con1.Open();
                        cmd1.ExecuteNonQuery();
                        con1.Close();
                        display();
                        MessageBox.Show("ویرایش اطلاعات با موفقیت انجام شد");

                        btnChange.Visible = true;
                        btnSave.Visible = false;
                        txbAddress.ReadOnly = true;
                        txbCity.ReadOnly = true;
                        txbCode.ReadOnly = true;
                        txbName.ReadOnly = true;
                        txbPhone1.ReadOnly = true;
                        txbPhone2.ReadOnly = true;
                        txbPhone3.ReadOnly = true;
                        txbState.ReadOnly = true;
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

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmCenterSpecifications_Activated(object sender, EventArgs e)
        {
            //dark mode
            if (MedicalLab.Properties.Settings.Default.Theme == 'D')
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                pictureBox1.BackColor = Color.DimGray;
                label3.BackColor = Color.DimGray;
                btnSave.BackColor = Color.DimGray;
                btnChange.BackColor = Color.DimGray;
            }
            //light mode
            else if (MedicalLab.Properties.Settings.Default.Theme == 'L')
            {
                this.BackColor = Color.Maroon;
                pictureBox1.BackColor = Color.Azure;
                label3.BackColor = Color.Azure;
                btnSave.BackColor = Color.Azure;
                btnChange.BackColor = Color.Azure;
            }
            txbCode.Focus();
        }

        private void txbCode_KeyDown(object sender, KeyEventArgs e)
        {
            //next textbox by enter
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
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

        private void txbPhone1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbPhone2_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbPhone3_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbState_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbState_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbState);
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersian(txbName);
        }

        private void txbAddress_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersian(txbAddress);
        }

        private void txbCode_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbCode);
        }

        private void txbPhone1_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbPhone1);
        }

        private void txbPhone2_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbPhone2);
        }

        private void txbPhone3_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbPhone3);
        }

        private void txbCity_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersian(txbCity);
        }
    }
}
