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
    public partial class frmDoctorsInformation : Form
    {
        public frmDoctorsInformation()
        {
            InitializeComponent();

            display();

            hideOptions();

            lblTotal.Text = dgvDoctors.Rows.Count.ToString();

            dgvDoctors.ColumnHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvDoctors.DefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvDoctors.RowHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);

            indx();
        }

        //capability of moving the form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Represents an open connection to a data source
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=MedicalLabDBAccess.mdb");
        //for execute actions on database
        OleDbCommand cmd = new OleDbCommand();

        //display data from access database
        void display()
        {
            //Represents an in-memory cache of data
            DataSet ds = new DataSet();
            //Represents a set of data commands and a database connection that are used to fill the DataSet and update the data source
            OleDbDataAdapter adp = new OleDbDataAdapter();
            adp.SelectCommand = new OleDbCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "select * from TBLDoctorsInformation";
            //fill the dataset from tabel of database
            adp.Fill(ds, "TBLDoctorsInformation");

            cmbDoctorSelection.DisplayMember = "DoctorNationalCode";
            cmbDoctorSelection.ValueMember = "DoctorNationalCode";
            cmbDoctorSelection.DataSource = ds.Tables["TBLDoctorsInformation"];

            cmbSearch.DisplayMember = "DoctorNationalCode";
            cmbSearch.ValueMember = "DoctorNationalCode";
            cmbSearch.DataSource = ds.Tables["TBLDoctorsInformation"];

            dgvDoctors.DataSource = ds;
            dgvDoctors.DataMember = "TBLDoctorsInformation";

            dgvDoctors.Columns[0].HeaderText = "شناسه";
            dgvDoctors.Columns[1].HeaderText = "نام";
            dgvDoctors.Columns[2].HeaderText = "نام خانوادگی";
            dgvDoctors.Columns[3].HeaderText = "نام پدر";
            dgvDoctors.Columns[4].HeaderText = "کد ملی";
            dgvDoctors.Columns[5].HeaderText = "تخصص";
            dgvDoctors.Columns[6].HeaderText = "شناسه نظام پزشکی";
            dgvDoctors.Columns[7].HeaderText = "مدرک";
            dgvDoctors.Columns[8].HeaderText = "تلفن";
            dgvDoctors.Columns[9].HeaderText = "آدرس";

            cmbDoctorSelection.SelectedIndex = -1;
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
            txbEditByNC.Visible = false;
            txbEditPhone.Visible = false;
            txbEditSpecialty.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label11.Visible = false;
            label19.Visible = false;
            label14.Visible = false;
            label12.Visible = false;
            label10.Visible = false;
            btnDelete.Visible = false;
            btnSaveChanges.Visible = false;
            btnSelectMode.Visible = false;
            label13.Visible = true;
            cmbDoctorSelection.Visible = true;
            btnDoctorSelect.Visible = true;
        }
        void showOptions()
        {
            txbEditAddress.Visible = true;
            txbEditDegree.Visible = true;
            txbEditFatherName.Visible = true;
            txbEditLastName.Visible = true;
            txbEditMedicalSystemID.Visible = true;
            txbEditName.Visible = true;
            txbEditByNC.Visible = true;
            txbEditPhone.Visible = true;
            txbEditSpecialty.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label11.Visible = true;
            label19.Visible = true;
            label14.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            btnDelete.Visible = true;
            btnSaveChanges.Visible = true;
            btnSelectMode.Visible = true;
            label13.Visible = false;
            cmbDoctorSelection.Visible = false;
            btnDoctorSelect.Visible = false;
        }

        //ordering indexes
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
                cmbDoctorSelection.TabIndex = 0;
                btnDoctorSelect.TabIndex = 1;
                txbEditName.TabIndex = 2;
                txbEditLastName.TabIndex = 3;
                txbEditFatherName.TabIndex = 4;
                txbEditSpecialty.TabIndex = 5;
                txbEditMedicalSystemID.TabIndex = 6;
                txbEditDegree.TabIndex = 7;
                txbEditPhone.TabIndex = 8;
                txbEditAddress.TabIndex = 9;
                btnSaveChanges.TabIndex = 10;
                btnDelete.TabIndex = 11;
                btnSelectMode.TabIndex = 12;

                if (cmbDoctorSelection.Visible == true)
                {
                    cmbDoctorSelection.Focus();
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
            //capability of moving the form
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txbName.Text = string.Empty;
            txbLastName.Text = string.Empty;
            txbNationalCode.Text = string.Empty;
            txbFatherName.Text = string.Empty;
            txbMedicalSystemID.Text = string.Empty;
            txbAddress.Text = string.Empty;
            txbSpecialty.Text = string.Empty;
            txbDegree.Text = string.Empty;
            txbPhone.Text = string.Empty;
        }

        private void frmDoctorsInformation_Activated(object sender, EventArgs e)
        {
            //dark mode
            if (MedicalLab.Properties.Settings.Default.Theme == 'D')
            {
                this.BackColor = Color.Gray;
                pictureBox1.BackColor = Color.DimGray;
                tabPage1.BackColor = Color.FromArgb(45, 45, 48);
                tabPage2.BackColor = Color.FromArgb(45, 45, 48);
                tabPage3.BackColor = Color.FromArgb(45, 45, 48);
                btnSave.BackColor = Color.DimGray;
                btnSaveChanges.BackColor = Color.DimGray;
                label20.BackColor = Color.DimGray;
                btnClean.BackColor = Color.DimGray;
                dgvDoctors.BackgroundColor = Color.Gray;
                btnSelectMode.BackColor = Color.DimGray;
            }
            display();
            indx();
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            dgvDoctors.ClearSelection();

            int temp = 0;
            bool temp1 = false;

            //find the value in datagridview
            for (int i = 0; i < dgvDoctors.Rows.Count; i++)
            {
                if (dgvDoctors.Rows[i].Cells[4].Value.ToString() == cmbSearch.Text.ToString().Trim())
                {
                    dgvDoctors.Rows[i].Selected = true;
                    temp = i;
                    temp1 = true;
                    break;
                }
            }
            if (temp1 == true)
            {
                dgvDoctors.FirstDisplayedScrollingRowIndex = temp;
            }
            else
            {
                MessageBox.Show("لطفا مقدار فیلد را به درستی وارد نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbEditName.Text != string.Empty && txbEditLastName.Text != string.Empty && txbEditFatherName.Text != string.Empty && txbEditSpecialty.Text != string.Empty && txbEditMedicalSystemID.Text != string.Empty && txbEditDegree.Text != string.Empty && txbEditPhone.Text != string.Empty && txbEditAddress.Text != string.Empty)
                {
                    DialogResult res = MessageBox.Show("آیا از حذف اطلاعات مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        cmd.Parameters.Clear();
                        cmd.Connection = con;
                        cmd.CommandText = "delete from TBLDoctorsInformation where DoctorNationalCode= @DoctorNationalCode";
                        cmd.Parameters.AddWithValue("@DoctorNationalCode", txbEditByNC.Text.Trim());
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        display();
                        MessageBox.Show("حذف اطلاعات با موفقیت انجام شد");
                        btnClean_Click(sender, e);
                        txbEditMedicalSystemID.Text = string.Empty;
                        txbEditAddress.Text = string.Empty;
                        txbEditSpecialty.Text = string.Empty;
                        txbEditDegree.Text = string.Empty;
                        txbEditPhone.Text = string.Empty;
                        txbEditFatherName.Text = string.Empty;
                        txbEditName.Text = string.Empty;
                        txbEditLastName.Text = string.Empty;
                        cmbDoctorSelection.Text = string.Empty;
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
                if (txbEditName.Text != string.Empty && txbEditLastName.Text != string.Empty && txbEditFatherName.Text != string.Empty && txbEditSpecialty.Text != string.Empty && txbEditMedicalSystemID.Text != string.Empty && txbEditDegree.Text != string.Empty && txbEditPhone.Text != string.Empty && txbEditAddress.Text != string.Empty)
                {
                        DialogResult res = MessageBox.Show("آیا از انجام تغییرات مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            cmd.Parameters.Clear();
                            cmd.Connection = con;
                            cmd.CommandText = "update TBLDoctorsInformation set DoctorName=@Name, DoctorLastName=@LastName, DoctorFatherName=@FatherName, DoctorNationalCode=@NationalCode, DoctorSpecialty=@Specialty, DoctorMedicalSystemID=@MedicalSystemID, DoctorDegree=@Degree, DoctorPhone=@Phone, DoctorAddress=@Address where DoctorNationalCode= @NationalCode";
                            cmd.Parameters.AddWithValue("@Name", txbEditName.Text.Trim());
                            cmd.Parameters.AddWithValue("@LastName", txbEditLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@FatherName", txbEditFatherName.Text.Trim());
                            cmd.Parameters.AddWithValue("@NationalCode", txbEditByNC.Text.Trim());
                            cmd.Parameters.AddWithValue("@Specialty", txbEditSpecialty.Text.Trim());
                            cmd.Parameters.AddWithValue("@MedicalSystemID", txbEditMedicalSystemID.Text.Trim());
                            cmd.Parameters.AddWithValue("@Degree", txbEditDegree.Text.Trim());
                            cmd.Parameters.AddWithValue("@Phone", txbEditPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@Address", txbEditAddress.Text.Trim());
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            display();
                            MessageBox.Show("ویرایش اطلاعات با موفقیت انجام شد");
                            txbEditMedicalSystemID.Text = string.Empty;
                            txbEditAddress.Text = string.Empty;
                            txbEditSpecialty.Text = string.Empty;
                            txbEditDegree.Text = string.Empty;
                            txbEditPhone.Text = string.Empty;
                            txbEditFatherName.Text = string.Empty;
                            txbEditName.Text = string.Empty;
                            txbEditLastName.Text = string.Empty;
                            cmbDoctorSelection.Text = string.Empty;
                            hideOptions();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //check: does this value already exist in database?
                bool tmp = false;
                for (int i = 0; i < dgvDoctors.Rows.Count; i++)
                {
                    if (dgvDoctors.Rows[i].Cells[4].Value.ToString() == txbNationalCode.Text.ToString())
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
                    if (txbName.Text != string.Empty && txbLastName.Text != string.Empty && txbFatherName.Text != string.Empty && txbNationalCode.Text != string.Empty && txbSpecialty.Text != string.Empty && txbMedicalSystemID.Text != string.Empty && txbDegree.Text != string.Empty && txbPhone.Text != string.Empty && txbAddress.Text != string.Empty)
                    {
                            cmd.Parameters.Clear();
                            cmd.Connection = con;
                            cmd.CommandText = "insert into TBLDoctorsInformation(DoctorName,DoctorLastName,DoctorFatherName,DoctorNationalCode,DoctorSpecialty,DoctorMedicalSystemID,DoctorDegree,DoctorPhone,DoctorAddress) values (@a,@b,@c,@d,@e,@f,@g,@h,@i)";
                            cmd.Parameters.AddWithValue("@a", txbName.Text.Trim());
                            cmd.Parameters.AddWithValue("@b", txbLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@c", txbFatherName.Text.Trim());
                            cmd.Parameters.AddWithValue("@d", txbNationalCode.Text.Trim());
                            cmd.Parameters.AddWithValue("@e", txbSpecialty.Text.Trim());
                            cmd.Parameters.AddWithValue("@f", txbMedicalSystemID.Text.Trim());
                            cmd.Parameters.AddWithValue("@g", txbDegree.Text.Trim());
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

        //entering data of database in textboxes
        private void btnDoctorSelect_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDoctors.ClearSelection();

                int temp = 0;
                bool temp1 = false;

                for (int i = 0; i < dgvDoctors.Rows.Count; i++)
                {
                    if (dgvDoctors.Rows[i].Cells[4].Value.ToString() == cmbDoctorSelection.Text.ToString().Trim())
                    {
                        dgvDoctors.Rows[i].Selected = true;
                        temp = i;
                        temp1 = true;
                        break;
                    }
                }
                if (temp1 == true)
                {
                    txbEditName.Text = dgvDoctors[1, temp].Value.ToString();
                    txbEditLastName.Text = dgvDoctors[2, temp].Value.ToString();
                    txbEditFatherName.Text = dgvDoctors[3, temp].Value.ToString();
                    txbEditByNC.Text = dgvDoctors[4, temp].Value.ToString();
                    txbEditSpecialty.Text = dgvDoctors[5, temp].Value.ToString();
                    txbEditMedicalSystemID.Text = dgvDoctors[6, temp].Value.ToString();
                    txbEditDegree.Text = dgvDoctors[7, temp].Value.ToString();
                    txbEditPhone.Text = dgvDoctors[8, temp].Value.ToString();
                    txbEditAddress.Text = dgvDoctors[9, temp].Value.ToString();

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

        private void label20_MouseDown(object sender, MouseEventArgs e)
        {
            //capability of moving the form
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSelectMode_Click(object sender, EventArgs e)
        {
            hideOptions();
            indx();
        }

        private void txbName_KeyDown(object sender, KeyEventArgs e)
        {
            //next textbox by enter
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

        private void txbSpecialty_KeyDown(object sender, KeyEventArgs e)
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

        private void txbEditSpecialty_KeyDown(object sender, KeyEventArgs e)
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

        private void cmbDoctorSelection_KeyDown(object sender, KeyEventArgs e)
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

        private void txbLastName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbLastName);
        }

        private void txbEditLastName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbEditLastName);
        }

        private void txbFatherName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbFatherName);
        }

        private void txbEditFatherName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbEditFatherName);
        }

        private void txbSpecialty_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbSpecialty);
        }

        private void txbEditSpecialty_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbEditSpecialty);
        }

        private void txbEditMedicalSystemID_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbEditMedicalSystemID);
        }

        private void txbMedicalSystemID_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbMedicalSystemID);
        }

        private void txbDegree_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbDegree);
        }

        private void txbEditDegree_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(txbEditDegree);
        }

        private void txbPhone_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbPhone);
        }

        private void txbEditPhone_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbEditPhone);
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
