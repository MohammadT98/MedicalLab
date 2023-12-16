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
    public partial class frmReceptioners : Form
    {
        public frmReceptioners()
        {
            InitializeComponent();
            dgvReceptioners.ColumnHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvReceptioners.DefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvReceptioners.RowHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
            display();
            hideOptions();
            indx();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=MedicalLabDBAccess.mdb");
        OleDbCommand cmd = new OleDbCommand();

        void display()
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter();
            adp.SelectCommand = new OleDbCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "select * from TBLReceptioners";
            adp.Fill(ds, "TBLReceptioners");

            cmbPatientSelection.DisplayMember = "ReceptionersNationalCode";
            cmbPatientSelection.ValueMember = "ReceptionersNationalCode";
            cmbPatientSelection.DataSource = ds.Tables["TBLReceptioners"];

            cmbSearch.DisplayMember = "ReceptionersNationalCode";
            cmbSearch.ValueMember = "ReceptionersNationalCode";
            cmbSearch.DataSource = ds.Tables["TBLReceptioners"];

            dgvReceptioners.DataSource = ds;
            dgvReceptioners.DataMember = "TBLReceptioners";

            dgvReceptioners.Columns[0].HeaderText = "شناسه";
            dgvReceptioners.Columns[1].HeaderText = "نام";
            dgvReceptioners.Columns[2].HeaderText = "نام خانوادگی";
            dgvReceptioners.Columns[3].HeaderText = "کد ملی";
            dgvReceptioners.Columns[4].HeaderText = "نام پدر";
            dgvReceptioners.Columns[5].HeaderText = "تلفن";
            dgvReceptioners.Columns[6].HeaderText = "آدرس";

            cmbPatientSelection.SelectedIndex = -1;
            cmbSearch.SelectedIndex = -1;
        }

        void hideOptions()
        {
            txbEditName.Visible = false;
            txbEditLastName.Visible = false;
            txbEditAddress.Visible = false;
            txbEditPhone.Visible = false;
            txbEditNationalCode.Visible = false;
            txbEditFatherName.Visible = false;
            lblEditAddress.Visible = false;
            lblEditFatherName.Visible = false;
            lblEditLastName.Visible = false;
            lblEditName.Visible = false;
            lblEditNC.Visible = false;
            lblEditPhone.Visible = false;
            btnSelectMode.Visible = false;
            btnSaveChanges.Visible = false;
            btnDelete.Visible = false;
            label20.Visible = true;
            cmbPatientSelection.Visible = true;
            btnPatientSelection.Visible = true;
        }
        void showOptions()
        {
            txbEditName.Visible = true;
            txbEditLastName.Visible = true;
            txbEditAddress.Visible = true;
            txbEditPhone.Visible = true;
            txbEditNationalCode.Visible = true;
            txbEditFatherName.Visible = true;
            lblEditAddress.Visible = true;
            lblEditFatherName.Visible = true;
            lblEditLastName.Visible = true;
            lblEditName.Visible = true;
            lblEditNC.Visible = true;
            lblEditPhone.Visible = true;
            btnSelectMode.Visible = true;
            btnSaveChanges.Visible = true;
            btnDelete.Visible = true;
            label20.Visible = false;
            cmbPatientSelection.Visible = false;
            btnPatientSelection.Visible = false;
        }

        void indx()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                txbNationalCode.TabIndex = 0;
                txbName.TabIndex = 1;
                txbLastName.TabIndex = 2;
                txbFatherName.TabIndex = 3;
                txbPhone.TabIndex = 4;
                txbAddress.TabIndex = 5;
                btnSave.TabIndex = 6;
                txbNationalCode.Focus();
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                cmbPatientSelection.TabIndex = 0;
                btnPatientSelection.TabIndex = 1;
                txbEditName.TabIndex = 2;
                txbEditLastName.TabIndex = 3;
                txbEditFatherName.TabIndex = 4;
                txbEditPhone.TabIndex = 5;
                txbEditAddress.TabIndex = 6;
                btnSave.TabIndex = 7;
                btnDelete.TabIndex = 8;
                btnSelectMode.TabIndex = 9;

                if (cmbPatientSelection.Visible == true)
                {
                    cmbPatientSelection.Focus();
                }
                else
                {
                    txbEditName.Focus();
                }
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                cmbSearch.TabIndex = 0;
                btnSelection.TabIndex = 1;
                cmbSearch.Focus();
            }
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

        private void frmReceptioners_Activated(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'D')
            {
                this.BackColor = Color.Gray;
                pictureBox1.BackColor = Color.DimGray;
                tabPage1.BackColor = Color.FromArgb(45, 45, 48);
                tabPage2.BackColor = Color.FromArgb(45, 45, 48);
                tabPage3.BackColor = Color.FromArgb(45, 45, 48);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                btnSave.BackColor = Color.DimGray;
                label7.BackColor = Color.DimGray;
                btnClean.BackColor = Color.DimGray;
                dgvReceptioners.BackgroundColor = Color.Gray;
            }
            display();
            lblTotal.Text = dgvReceptioners.Rows.Count.ToString();
            indx();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txbName.Text = string.Empty;
            txbLastName.Text = string.Empty;
            txbAddress.Text = string.Empty;
            txbPhone.Text = string.Empty;
            txbNationalCode.Text = string.Empty;
            txbFatherName.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool tmp = false;
                for (int i = 0; i < dgvReceptioners.Rows.Count; i++)
                {
                    if (dgvReceptioners.Rows[i].Cells[3].Value.ToString() == txbNationalCode.Text.ToString())
                    {
                        tmp = true;
                        break;
                    }
                }

                if (tmp == true)
                {
                    MessageBox.Show("اطلاعات پذیرش کننده با این کد ملی ثبت شده است", "تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txbName.Text != string.Empty && txbLastName.Text != string.Empty && txbNationalCode.Text != string.Empty && txbFatherName.Text != string.Empty && txbPhone.Text != string.Empty && txbAddress.Text != string.Empty)
                    {
                            cmd.Parameters.Clear();
                            cmd.Connection = con;
                            cmd.CommandText = "insert into TBLReceptioners(ReceptionersName,ReceptionersLastName,ReceptionersNationalCode,ReceptionersFatherName,ReceptionersPhone,ReceptionersAddress) values (@a,@b,@c,@d,@e,@f)";
                            cmd.Parameters.AddWithValue("@a", txbName.Text.Trim());
                            cmd.Parameters.AddWithValue("@b", txbLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@c", txbNationalCode.Text.Trim());
                            cmd.Parameters.AddWithValue("@d", txbFatherName.Text.Trim());
                            cmd.Parameters.AddWithValue("@e", txbPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@f", txbAddress.Text.Trim());
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("اطلاعات با موفقیت ثبت شد");
                            btnClean_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("لطفا فیلد های خالی را تکمیل نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbEditName.Text != string.Empty && txbEditLastName.Text != string.Empty && txbEditNationalCode.Text != string.Empty && txbEditFatherName.Text != string.Empty && txbEditPhone.Text != string.Empty && txbEditAddress.Text != string.Empty)
                {
                    DialogResult res = MessageBox.Show("آیا از حذف اطلاعات مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        cmd.Parameters.Clear();
                        cmd.Connection = con;
                        cmd.CommandText = "delete from TBLReceptioners where ReceptionersNationalCode=@NC";
                        cmd.Parameters.AddWithValue("@NC", txbEditNationalCode.Text.Trim());
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        display();
                        MessageBox.Show("حذف اطلاعات با موفقیت انجام شد");
                        btnClean_Click(sender, e);
                        txbEditName.Text = string.Empty;
                        txbEditLastName.Text = string.Empty;
                        txbEditAddress.Text = string.Empty;
                        txbEditPhone.Text = string.Empty;
                        txbEditNationalCode.Text = string.Empty;
                        txbEditFatherName.Text = string.Empty;
                        btnSelectMode_Click(sender, e);
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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbEditName.Text != string.Empty && txbEditLastName.Text != string.Empty && txbEditNationalCode.Text != string.Empty && txbEditFatherName.Text != string.Empty && txbEditPhone.Text != string.Empty && txbEditAddress.Text != string.Empty)
                {
                        DialogResult res = MessageBox.Show("آیا از انجام تغییرات مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            cmd.Parameters.Clear();
                            cmd.Connection = con;
                            cmd.CommandText = "update TBLReceptioners set ReceptionersName=@N,ReceptionersLastName=@LN,ReceptionersNationalCode=@NC,ReceptionersFatherName=@FN,ReceptionersPhone=@PH,ReceptionersAddress=@AD where ReceptionersNationalCode=@NC";
                            cmd.Parameters.AddWithValue("@N", txbEditName.Text.Trim());
                            cmd.Parameters.AddWithValue("@LN", txbEditLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@NC", txbEditNationalCode.Text.Trim());
                            cmd.Parameters.AddWithValue("@FN", txbEditFatherName.Text.Trim());
                            cmd.Parameters.AddWithValue("@PH", txbEditPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@AD", txbEditAddress.Text.Trim());
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            display();
                            MessageBox.Show("ویرایش اطلاعات با موفقیت انجام شد");

                            txbEditName.Text = string.Empty;
                            txbEditLastName.Text = string.Empty;
                            txbEditAddress.Text = string.Empty;
                            txbEditPhone.Text = string.Empty;
                            txbEditNationalCode.Text = string.Empty;
                            txbEditFatherName.Text = string.Empty;
                            btnSelectMode_Click(sender, e);
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

        private void btnSelectMode_Click(object sender, EventArgs e)
        {
            hideOptions();
        }

        private void btnPatientSelection_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReceptioners.ClearSelection();

                int temp = 0;
                bool temp1 = false;
                for (int i = 0; i < dgvReceptioners.Rows.Count; i++)
                {
                    if (dgvReceptioners.Rows[i].Cells[3].Value.ToString() == cmbPatientSelection.Text.ToString().Trim())
                    {
                        dgvReceptioners.Rows[i].Selected = true;
                        temp = i;
                        temp1 = true;
                        break;
                    }
                }
                if (temp1 == true)
                {
                    txbEditName.Text = dgvReceptioners[1, temp].Value.ToString();
                    txbEditLastName.Text = dgvReceptioners[2, temp].Value.ToString();
                    txbEditNationalCode.Text = dgvReceptioners[3, temp].Value.ToString();
                    txbEditFatherName.Text = dgvReceptioners[4, temp].Value.ToString();
                    txbEditPhone.Text = dgvReceptioners[5, temp].Value.ToString();
                    txbEditAddress.Text = dgvReceptioners[6, temp].Value.ToString();

                    showOptions();
                }
                else
                {
                    MessageBox.Show("لطفا مقدار فیلد را به درستی وارد نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            dgvReceptioners.ClearSelection();

            int temp = 0;
            bool temp1 = false;
            for (int i = 0; i < dgvReceptioners.Rows.Count; i++)
            {

                if (dgvReceptioners.Rows[i].Cells[3].Value.ToString() == cmbSearch.Text.ToString().Trim())
                {
                    dgvReceptioners.Rows[i].Selected = true;
                    temp = i;
                    temp1 = true;
                    break;
                }
            }
            if (temp1 == true)
            {
                dgvReceptioners.FirstDisplayedScrollingRowIndex = temp;
            }
            else
            {
                MessageBox.Show("لطفا مقدار فیلد را به درستی وارد نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                btnClean.Visible = true;
            }
            else
            {
                btnClean.Visible = false;
            }
            indx();
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

        private void txbFatherName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbNationalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbEditName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cmbPatientSelection_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbEditNationalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbEditLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbEditPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbEditFatherName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cmbSearch_KeyDown(object sender, KeyEventArgs e)
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

        private void txbEditAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbNationalCode_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbNationalCode);
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbName);
        }

        private void txbEditName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbEditName);
        }

        private void txbEditLastName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbEditLastName);
        }

        private void txbLastName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbLastName);
        }

        private void txbFatherName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbFatherName);
        }

        private void txbEditFatherName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbEditFatherName);
        }

        private void txbPhone_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbPhone);
        }

        private void txbEditPhone_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbEditPhone);
        }

        private void txbEditAddress_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersian(txbEditAddress);
        }

        private void txbAddress_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersian(txbAddress);
        }
    }
}
