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
    public partial class frmSamplingPhysician : Form
    {
        public frmSamplingPhysician()
        {
            InitializeComponent();
            dgvSamplingPhysician.ColumnHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvSamplingPhysician.DefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvSamplingPhysician.RowHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
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
            adp.SelectCommand.CommandText = "select * from TBLSamplingPhysician";
            adp.Fill(ds, "TBLSamplingPhysician");

            cmbExperimentSelection.DisplayMember = "SamplingPhysicianNationalCode";
            cmbExperimentSelection.ValueMember = "SamplingPhysicianNationalCode";
            cmbExperimentSelection.DataSource = ds.Tables["TBLSamplingPhysician"];

            cmbSearch.DisplayMember = "SamplingPhysicianNationalCode";
            cmbSearch.ValueMember = "SamplingPhysicianNationalCode";
            cmbSearch.DataSource = ds.Tables["TBLSamplingPhysician"];

            dgvSamplingPhysician.DataSource = ds;
            dgvSamplingPhysician.DataMember = "TBLSamplingPhysician";

            dgvSamplingPhysician.Columns[0].HeaderText = "شناسه";
            dgvSamplingPhysician.Columns[1].HeaderText = "نام";
            dgvSamplingPhysician.Columns[2].HeaderText = "نام خانوادگی";
            dgvSamplingPhysician.Columns[3].HeaderText = "نام پدر";
            dgvSamplingPhysician.Columns[4].HeaderText = "کد ملی";
            dgvSamplingPhysician.Columns[5].HeaderText = "مدرک";
            dgvSamplingPhysician.Columns[6].HeaderText = "تخصص";
            dgvSamplingPhysician.Columns[7].HeaderText = "شناسه نظام پزشکی";
            dgvSamplingPhysician.Columns[8].HeaderText = "تلفن";
            dgvSamplingPhysician.Columns[9].HeaderText = "آدرس";

            cmbExperimentSelection.SelectedIndex = -1;
            cmbSearch.SelectedIndex = -1;
        }

        void hideOptions()
        {
            txbEditAddress.Visible = false;
            txbEditDegree.Visible = false;
            txbEditFatherName.Visible = false;
            txbEditLastName.Visible = false;
            txbEditMedicalSystemID.Visible = false;
            txbEditName.Visible = false;
            txbEditNationalCode.Visible = false;
            txbEditPhone.Visible = false;
            txbEditSpecialty.Visible = false;
            label18.Visible = false;
            label17.Visible = false;
            label12.Visible = false;
            label16.Visible = false;
            label15.Visible = false;
            label19.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label11.Visible = false;
            btnSelectMode.Visible = false;
            btnSaveChanges.Visible = false;
            btnDelete.Visible = false;
            cmbExperimentSelection.Visible = true;
            btnPatientSelection.Visible = true;
            label20.Visible = true;
        }
        void showOptions()
        {
            txbEditAddress.Visible = true;
            txbEditDegree.Visible = true;
            txbEditFatherName.Visible = true;
            txbEditLastName.Visible = true;
            txbEditMedicalSystemID.Visible = true;
            txbEditName.Visible = true;
            txbEditNationalCode.Visible = true;
            txbEditPhone.Visible = true;
            txbEditSpecialty.Visible = true;
            label18.Visible = true;
            label17.Visible = true;
            label12.Visible = true;
            label16.Visible = true;
            label15.Visible = true;
            label19.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label11.Visible = true;
            btnSelectMode.Visible = true;
            btnSaveChanges.Visible = true;
            btnDelete.Visible = true;
            cmbExperimentSelection.Visible = false;
            btnPatientSelection.Visible = false;
            label20.Visible = false;
        }

        void indx()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                txbNationalCode.TabIndex = 0;
                txbName.TabIndex = 1;
                txbLastName.TabIndex = 2;
                txbFatherName.TabIndex = 3;
                txbSpecialty.TabIndex = 4;
                txbMedicalSystemID.TabIndex = 5;
                txbDegree.TabIndex = 6;
                txbPhone.TabIndex = 7;
                txbAddress.TabIndex = 8;
                btnSave.TabIndex = 9;
                txbNationalCode.Focus();
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                cmbExperimentSelection.TabIndex = 0;
                btnPatientSelection.TabIndex = 1;
                txbEditName.TabIndex = 2;
                txbEditLastName.TabIndex = 3;
                txbEditFatherName.TabIndex = 4;
                txbEditSpecialty.TabIndex = 5;
                txbEditMedicalSystemID.TabIndex = 6;
                txbEditDegree.TabIndex = 7;
                txbEditPhone.TabIndex = 8;
                txbEditAddress.TabIndex = 9;
                btnSave.TabIndex = 10;
                btnDelete.TabIndex = 11;
                btnSelectMode.TabIndex = 12;

                if (cmbExperimentSelection.Visible == true)
                {
                    cmbExperimentSelection.Focus();
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

        private void frmSamplingPhysician_Activated(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'D')
            {
                this.BackColor = Color.Gray;
                pictureBox1.BackColor = Color.DimGray;
                tabPage1.BackColor = Color.FromArgb(45, 45, 48);
                tabPage2.BackColor = Color.FromArgb(45, 45, 48);
                tabPage3.BackColor = Color.FromArgb(45, 45, 48);
                btnSave.BackColor = Color.DimGray;
                label10.BackColor = Color.DimGray;
                btnClean.BackColor = Color.DimGray;
                dgvSamplingPhysician.BackgroundColor = Color.Gray;
            }
            display();
            lblTotal.Text = dgvSamplingPhysician.Rows.Count.ToString();
            indx();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool tmp = false;
                for (int i = 0; i < dgvSamplingPhysician.Rows.Count; i++)
                {
                    if (dgvSamplingPhysician.Rows[i].Cells[4].Value.ToString() == txbNationalCode.Text.ToString())
                    {
                        tmp = true;
                        break;
                    }
                }

                if (tmp == true)
                {
                    MessageBox.Show("اطلاعات پزشک با این کد ملی ثبت شده است", "تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (txbName.Text != string.Empty && txbLastName.Text != string.Empty && txbFatherName.Text != string.Empty && txbNationalCode.Text != string.Empty && txbDegree.Text != string.Empty && txbSpecialty.Text != string.Empty && txbMedicalSystemID.Text != string.Empty && txbPhone.Text != string.Empty && txbAddress.Text != string.Empty)
                    {
                            cmd.Parameters.Clear();
                            cmd.Connection = con;
                            cmd.CommandText = "insert into TBLSamplingPhysician(SamplingPhysicianName,SamplingPhysicianLastName,SamplingPhysicianFatherName,SamplingPhysicianNationalCode,SamplingPhysicianDegree,SamplingPhysicianSpecialty,SamplingPhysicianMedicalSystemID,SamplingPhysicianPhone,SamplingPhysicianAddress) values (@a,@b,@c,@d,@e,@f,@g,@h,@i)";
                            cmd.Parameters.AddWithValue("@a", txbName.Text.Trim());
                            cmd.Parameters.AddWithValue("@b", txbLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@c", txbFatherName.Text.Trim());
                            cmd.Parameters.AddWithValue("@d", txbNationalCode.Text.Trim());
                            cmd.Parameters.AddWithValue("@e", txbDegree.Text.Trim());
                            cmd.Parameters.AddWithValue("@f", txbSpecialty.Text.Trim());
                            cmd.Parameters.AddWithValue("@g", txbMedicalSystemID.Text.Trim());
                            cmd.Parameters.AddWithValue("@h", txbPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@i", txbAddress.Text.Trim());
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

        private void btnSelectMode_Click(object sender, EventArgs e)
        {
            hideOptions();
            indx();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbEditName.Text != string.Empty && txbEditLastName.Text != string.Empty && txbEditFatherName.Text != string.Empty && txbEditNationalCode.Text != string.Empty && txbEditDegree.Text != string.Empty && txbEditSpecialty.Text != string.Empty && txbEditMedicalSystemID.Text != string.Empty && txbEditPhone.Text != string.Empty && txbEditAddress.Text != string.Empty)
                {
                        DialogResult res = MessageBox.Show("آیا از انجام تغییرات مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            cmd.Parameters.Clear();
                            cmd.Connection = con;
                            cmd.CommandText = "update TBLSamplingPhysician set SamplingPhysicianName=@N,SamplingPhysicianLastName=@LN,SamplingPhysicianFatherName=@FN,SamplingPhysicianNationalCode=@NC,SamplingPhysicianDegree=@DG,SamplingPhysicianSpecialty=@SP,SamplingPhysicianMedicalSystemID=@MSI,SamplingPhysicianPhone=@PH,SamplingPhysicianAddress=@AD where SamplingPhysicianNationalCode=@NC";
                            cmd.Parameters.AddWithValue("@N", txbEditName.Text.Trim());
                            cmd.Parameters.AddWithValue("@LN", txbEditLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@FN", txbEditFatherName.Text.Trim());
                            cmd.Parameters.AddWithValue("@NC", txbEditNationalCode.Text.Trim());
                            cmd.Parameters.AddWithValue("@DG", txbEditDegree.Text.Trim());
                            cmd.Parameters.AddWithValue("@SP", txbEditSpecialty.Text.Trim());
                            cmd.Parameters.AddWithValue("@MSI", txbEditMedicalSystemID.Text.Trim());
                            cmd.Parameters.AddWithValue("@PH", txbEditPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@AD", txbEditAddress.Text.Trim());
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            display();
                            MessageBox.Show("ویرایش اطلاعات با موفقیت انجام شد");
                            txbEditAddress.Text = string.Empty;
                            txbEditDegree.Text = string.Empty;
                            txbEditFatherName.Text = string.Empty;
                            txbEditLastName.Text = string.Empty;
                            txbEditMedicalSystemID.Text = string.Empty;
                            txbEditName.Text = string.Empty;
                            txbEditNationalCode.Text = string.Empty;
                            txbEditPhone.Text = string.Empty;
                            txbEditSpecialty.Text = string.Empty;
                            btnClean_Click(sender, e);
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
                if (txbEditName.Text != string.Empty && txbEditLastName.Text != string.Empty && txbEditFatherName.Text != string.Empty && txbEditNationalCode.Text != string.Empty && txbEditDegree.Text != string.Empty && txbEditSpecialty.Text != string.Empty && txbEditMedicalSystemID.Text != string.Empty && txbEditPhone.Text != string.Empty && txbEditAddress.Text != string.Empty)
                {
                    DialogResult res = MessageBox.Show("آیا از حذف اطلاعات مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        cmd.Parameters.Clear();
                        cmd.Connection = con;
                        cmd.CommandText = "delete from TBLSamplingPhysician where SamplingPhysicianNationalCode=@NCode";
                        cmd.Parameters.AddWithValue("@NCode", txbEditNationalCode.Text.Trim());
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        display();
                        MessageBox.Show("حذف اطلاعات با موفقیت انجام شد");
                        btnClean_Click(sender, e);
                        txbEditAddress.Text = string.Empty;
                        txbEditDegree.Text = string.Empty;
                        txbEditFatherName.Text = string.Empty;
                        txbEditLastName.Text = string.Empty;
                        txbEditMedicalSystemID.Text = string.Empty;
                        txbEditName.Text = string.Empty;
                        txbEditNationalCode.Text = string.Empty;
                        txbEditPhone.Text = string.Empty;
                        txbEditSpecialty.Text = string.Empty;
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
                dgvSamplingPhysician.ClearSelection();

                int temp = 0;
                bool temp1 = false;
                for (int i = 0; i < dgvSamplingPhysician.Rows.Count; i++)
                {
                    if (dgvSamplingPhysician.Rows[i].Cells[4].Value.ToString() == cmbExperimentSelection.Text.ToString().Trim())
                    {
                        dgvSamplingPhysician.Rows[i].Selected = true;
                        temp = i;
                        temp1 = true;
                        break;
                    }
                }
                if (temp1 == true)
                {

                    txbEditName.Text = dgvSamplingPhysician[1, temp].Value.ToString();
                    txbEditLastName.Text = dgvSamplingPhysician[2, temp].Value.ToString();
                    txbEditFatherName.Text = dgvSamplingPhysician[3, temp].Value.ToString();
                    txbEditNationalCode.Text = dgvSamplingPhysician[4, temp].Value.ToString();
                    txbEditDegree.Text = dgvSamplingPhysician[5, temp].Value.ToString();
                    txbEditSpecialty.Text = dgvSamplingPhysician[6, temp].Value.ToString();
                    txbEditMedicalSystemID.Text = dgvSamplingPhysician[7, temp].Value.ToString();
                    txbEditPhone.Text = dgvSamplingPhysician[8, temp].Value.ToString();
                    txbEditAddress.Text = dgvSamplingPhysician[9, temp].Value.ToString();
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
            dgvSamplingPhysician.ClearSelection();

            int temp = 0;
            bool temp1 = false;
            for (int i = 0; i < dgvSamplingPhysician.Rows.Count; i++)
            {

                if (dgvSamplingPhysician.Rows[i].Cells[4].Value.ToString() == cmbSearch.Text.ToString().Trim())
                {
                    dgvSamplingPhysician.Rows[i].Selected = true;
                    temp = i;
                    temp1 = true;
                    break;
                }
            }
            if (temp1 == true)
            {

                dgvSamplingPhysician.FirstDisplayedScrollingRowIndex = temp;
            }
            else
            {
                MessageBox.Show("لطفا مقدار فیلد را به درستی وارد نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txbMedicalSystemID.Text = string.Empty;
            txbAddress.Text = string.Empty;
            txbSpecialty.Text = string.Empty;
            txbDegree.Text = string.Empty;
            txbPhone.Text = string.Empty;
            txbNationalCode.Text = string.Empty;
            txbFatherName.Text = string.Empty;
            txbName.Text = string.Empty;
            txbLastName.Text = string.Empty;
        }

        private void label10_MouseDown(object sender, MouseEventArgs e)
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

        private void txbSpecialty_KeyDown(object sender, KeyEventArgs e)
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

        private void txbMedicalSystemID_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbDegree_KeyDown(object sender, KeyEventArgs e)
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

        private void txbEditSpecialty_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cmbExperimentSelection_KeyDown(object sender, KeyEventArgs e)
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

        private void txbEditMedicalSystemID_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbEditDegree_KeyDown(object sender, KeyEventArgs e)
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

        private void txbEditSpecialty_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbEditSpecialty);
        }

        private void txbSpecialty_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbSpecialty);
        }

        private void txbMedicalSystemID_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbMedicalSystemID);
        }

        private void txbEditMedicalSystemID_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbEditMedicalSystemID);
        }

        private void txbEditDegree_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbEditDegree);
        }

        private void txbDegree_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbDegree);
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
