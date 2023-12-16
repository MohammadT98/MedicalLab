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
    public partial class frmPatientInformation : Form
    {
        public frmPatientInformation()
        {
            InitializeComponent();
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
            adp.SelectCommand.CommandText = "select * from TBLPatientInformation";
            adp.Fill(ds, "TBLPatientInformation");

            cmbPatientSelection.DisplayMember = "PatientNationalCode";
            cmbPatientSelection.ValueMember = "PatientNationalCode";
            cmbPatientSelection.DataSource = ds.Tables["TBLPatientInformation"];

            dgvTemp.DataSource = ds;
            dgvTemp.DataMember = "TBLPatientInformation";

            DataSet ds1 = new DataSet();
            adp.SelectCommand.CommandText = "select * from TBLInsurances";
            adp.Fill(ds1, "TBLInsurances");

            cmbInsurance.DisplayMember = "InsurancesName";
            cmbInsurance.ValueMember = "InsurancesName";
            cmbInsurance.DataSource = ds1.Tables["TBLInsurances"];

            cmbInsurance.Text = string.Empty;

            cmbEditInsurance.DisplayMember = "InsurancesName";
            cmbEditInsurance.ValueMember = "InsurancesName";
            cmbEditInsurance.DataSource = ds1.Tables["TBLInsurances"];

            cmbPatientSelection.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void hideOptions()
        {
            label20.Visible = true;
            cmbPatientSelection.Visible = true;
            btnPatientSelection.Visible = true;
            txbEditName.Visible = false;
            txbEditLastName.Visible = false;
            txbEditFatherName.Visible = false;
            txbEditNationalCode.Visible = false;
            cmbEditSex.Visible = false;
            cmbEditInsurance.Visible = false;
            txbEditPhone.Visible = false;
            txbEditAddress.Visible = false;
            btnSaveChanges.Visible = false;
            btnDelete.Visible = false;
            label13.Visible = false;
            label18.Visible = false;
            label16.Visible = false;
            label1.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label2.Visible = false;
            label19.Visible = false;
            btnSelectMode.Visible = false;
        }
        void showOptions()
        {
            cmbPatientSelection.Visible = false;
            btnPatientSelection.Visible = false;
            txbEditName.Visible = true;
            txbEditLastName.Visible = true;
            txbEditFatherName.Visible = true;
            txbEditNationalCode.Visible = true;
            cmbEditSex.Visible = true;
            cmbEditInsurance.Visible = true;
            txbEditPhone.Visible = true;
            txbEditAddress.Visible = true;
            btnSaveChanges.Visible = true;
            btnDelete.Visible = true;
            label20.Visible = false;
            label13.Visible = true;
            label18.Visible = true;
            label16.Visible = true;
            label1.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label2.Visible = true;
            label19.Visible = true;
            btnSelectMode.Visible = true;
        }

        void indx()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                txbNationalCode.TabIndex = 0;
                txbName.TabIndex = 1;
                txbLastName.TabIndex = 2;
                txbFatherName.TabIndex = 3;
                cmbSex.TabIndex = 4;
                cmbInsurance.TabIndex = 5;
                txbPhone.TabIndex = 6;
                txbAddress.TabIndex = 7;
                btnSave.TabIndex = 8;
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                cmbPatientSelection.TabIndex = 0;
                btnPatientSelection.TabIndex = 1;
                txbEditName.TabIndex = 2;
                txbEditLastName.TabIndex = 3;
                txbEditFatherName.TabIndex = 4;
                cmbEditSex.TabIndex = 5;
                cmbEditInsurance.TabIndex = 6;
                txbEditPhone.TabIndex = 7;
                txbEditAddress.TabIndex = 8;
                btnSaveChanges.TabIndex = 9;
                btnDelete.TabIndex = 10;
                btnSelectMode.TabIndex = 11;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmPatientInformation_Activated(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'D')
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                pictureBox1.BackColor = Color.DimGray;
                label3.BackColor = Color.DimGray;
                btnClean.BackColor = Color.DimGray;
                tabPage1.BackColor = Color.FromArgb(45, 45, 48);
                tabPage2.BackColor = Color.FromArgb(45, 45, 48);
            }
            display();
            indx();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txbAddress.Text = string.Empty;
            txbPhone.Text = string.Empty;
            txbNationalCode.Text = string.Empty;
            txbFatherName.Text = string.Empty;
            txbLastName.Text = string.Empty;
            txbName.Text = string.Empty;
            cmbInsurance.Text = string.Empty;
            cmbSex.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool tmp = false;
                for (int i = 0; i < dgvTemp.Rows.Count; i++)
                {
                    if (dgvTemp.Rows[i].Cells[4].Value.ToString() == txbNationalCode.Text.ToString())
                    {
                        tmp = true;
                        break;
                    }
                }

                if (tmp == true)
                {
                    MessageBox.Show("اطلاعات بیمار با این کد ملی ثبت شده است", "تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txbName.Text != string.Empty && txbLastName.Text != string.Empty && txbFatherName.Text != string.Empty && txbNationalCode.Text != string.Empty && txbPhone.Text != string.Empty && cmbSex.Text != string.Empty && cmbInsurance.Text != string.Empty && txbAddress.Text != string.Empty)
                    {
                            cmd.Parameters.Clear();
                            cmd.Connection = con;
                            cmd.CommandText = "insert into TBLPatientInformation(PatientName,PatientLastName,PatientFatherName,PatientNationalCode,PatientPhone,PatientSex,PatientInsurances,PatientAddress) values (@a,@b,@c,@d,@e,@f,@g,@h)";
                            cmd.Parameters.AddWithValue("@a", txbName.Text.Trim());
                            cmd.Parameters.AddWithValue("@b", txbLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@c", txbFatherName.Text.Trim());
                            cmd.Parameters.AddWithValue("@d", txbNationalCode.Text.Trim());
                            cmd.Parameters.AddWithValue("@e", txbPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@f", cmbSex.Text.Trim());
                            cmd.Parameters.AddWithValue("@g", cmbInsurance.Text.Trim());
                            cmd.Parameters.AddWithValue("@h", txbAddress.Text.Trim());
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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbEditName.Text != string.Empty && txbEditLastName.Text != string.Empty && txbEditFatherName.Text != string.Empty && txbEditNationalCode.Text != string.Empty && txbEditPhone.Text != string.Empty && cmbEditSex.Text != string.Empty && cmbEditInsurance.Text != string.Empty && txbEditAddress.Text != string.Empty)
                {
                        DialogResult res = MessageBox.Show("آیا از انجام تغییرات مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            cmd.Parameters.Clear();
                            cmd.Connection = con;
                            cmd.CommandText = "update TBLPatientInformation set PatientName = @Name , PatientLastName= @LastName , PatientFatherName= @FatherName , PatientNationalCode= @NationalCode  , PatientPhone= @Phone , PatientSex= @Sex , PatientInsurances= @Insurances , PatientAddress= @Address where PatientNationalCode= @NationalCode";
                            cmd.Parameters.AddWithValue("@Name", txbEditName.Text.Trim());
                            cmd.Parameters.AddWithValue("@LastName", txbEditLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@FatherName", txbEditFatherName.Text.Trim());
                            cmd.Parameters.AddWithValue("@NationalCode", txbEditNationalCode.Text.Trim());
                            cmd.Parameters.AddWithValue("@Phone", txbEditPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@Sex", cmbEditSex.Text.Trim());
                            cmd.Parameters.AddWithValue("@Insurances", cmbEditInsurance.Text.Trim());
                            cmd.Parameters.AddWithValue("@Address", txbEditAddress.Text.Trim());
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            display();
                            MessageBox.Show("ویرایش اطلاعات با موفقیت انجام شد");
                            txbEditAddress.Text = string.Empty;
                            txbEditPhone.Text = string.Empty;
                            txbEditNationalCode.Text = string.Empty;
                            txbEditFatherName.Text = string.Empty;
                            txbEditLastName.Text = string.Empty;
                            txbEditName.Text = string.Empty;
                            cmbEditInsurance.Text = string.Empty;
                            cmbEditSex.Text = string.Empty;
                            cmbPatientSelection.Text = string.Empty;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbEditName.Text != string.Empty && txbEditLastName.Text != string.Empty && txbEditFatherName.Text != string.Empty && txbEditNationalCode.Text != string.Empty && txbEditPhone.Text != string.Empty && cmbEditSex.Text != string.Empty && cmbEditInsurance.Text != string.Empty && txbEditAddress.Text != string.Empty)
                {
                    DialogResult res = MessageBox.Show("آیا از حذف اطلاعات مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        cmd.Parameters.Clear();
                        cmd.Connection = con;
                        cmd.CommandText = "delete from TBLPatientInformation where PatientNationalCode= @PatientNationalCode";
                        cmd.Parameters.AddWithValue("@PatientNationalCode", txbEditNationalCode.Text.Trim());
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        display();
                        MessageBox.Show("حذف اطلاعات با موفقیت انجام شد");
                        btnClean_Click(sender, e);
                        txbEditAddress.Text = string.Empty;
                        txbEditPhone.Text = string.Empty;
                        txbEditNationalCode.Text = string.Empty;
                        txbEditFatherName.Text = string.Empty;
                        txbEditLastName.Text = string.Empty;
                        txbEditName.Text = string.Empty;
                        cmbEditInsurance.Text = string.Empty;
                        cmbEditSex.Text = string.Empty;
                        cmbPatientSelection.Text = string.Empty;
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

        private void btnPatientSelection_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTemp.ClearSelection();

                int temp = 0;
                bool temp1 = false;
                for (int i = 0; i < dgvTemp.Rows.Count; i++)
                {
                    if (dgvTemp.Rows[i].Cells[4].Value.ToString() == cmbPatientSelection.Text.ToString().Trim())
                    {
                        dgvTemp.Rows[i].Selected = true;
                        temp = i;
                        temp1 = true;
                        break;
                    }
                }
                if (temp1 == true)
                {
                    txbEditName.Text = dgvTemp[1, temp].Value.ToString();
                    txbEditLastName.Text = dgvTemp[2, temp].Value.ToString();
                    txbEditFatherName.Text = dgvTemp[3, temp].Value.ToString();
                    txbEditNationalCode.Text = dgvTemp[4, temp].Value.ToString();
                    txbEditPhone.Text = dgvTemp[5, temp].Value.ToString();
                    cmbEditSex.Text = dgvTemp[6, temp].Value.ToString();
                    cmbEditInsurance.Text = dgvTemp[7, temp].Value.ToString();
                    txbEditAddress.Text = dgvTemp[8, temp].Value.ToString();

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

        private void btnSelectMode_Click(object sender, EventArgs e)
        {
            hideOptions();
            indx();
        }

        private void tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
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

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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

        private void cmbSex_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cmbInsurance_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbIllness_KeyDown(object sender, KeyEventArgs e)
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

        private void txbEditLastName_KeyDown(object sender, KeyEventArgs e)
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

        private void txbEditNationalCode_KeyDown(object sender, KeyEventArgs e)
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

        private void cmbEditSex_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cmbEditInsurance_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbEditIllness_KeyDown(object sender, KeyEventArgs e)
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

        private void cmbEditSex_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(cmbEditSex);
        }

        private void cmbSex_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(cmbSex);
        }

        private void txbEditPhone_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbEditPhone);
        }

        private void txbPhone_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbPhone);
        }

        private void txbAddress_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersian(txbAddress);
        }

        private void txbEditAddress_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersian(txbEditAddress);
        }
    }
}
