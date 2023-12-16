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
    public partial class frmInsurances : Form
    {
        public frmInsurances()
        {
            InitializeComponent();

            display();

            dgvInsurances.ColumnHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvInsurances.DefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvInsurances.RowHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);

            hideOptions();

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
            DataSet ds = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter();
            adp.SelectCommand = new OleDbCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "select * from TBLInsurances";
            adp.Fill(ds, "TBLInsurances");

            cmbSelectInsurance.DisplayMember = "InsurancesName";
            cmbSelectInsurance.ValueMember = "InsurancesName";
            cmbSelectInsurance.DataSource = ds.Tables["TBLInsurances"];

            cmbSearch.DisplayMember = "InsurancesName";
            cmbSearch.ValueMember = "InsurancesName";
            cmbSearch.DataSource = ds.Tables["TBLInsurances"];

            dgvInsurances.DataSource = ds;
            dgvInsurances.DataMember = "TBLInsurances";

            dgvInsurances.Columns[0].HeaderText = "شناسه";
            dgvInsurances.Columns[1].HeaderText = "نام بیمه";
            dgvInsurances.Columns[2].HeaderText = "نوع بیمه";

            cmbSelectInsurance.SelectedIndex = -1;
            cmbSearch.SelectedIndex = -1;
        }


        void hideOptions()
        {
            txbEditByName.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            cmbEditInsuranceType.Visible = false;
            btnSelectMode.Visible = false;
            btnSaveChanges.Visible = false;
            btnDelete.Visible = false;
            cmbSelectInsurance.Visible = true;
            btnPatientSelection.Visible = true;
            label13.Visible = true;
        }
        void showOptions()
        {
            txbEditByName.Visible = true;
            label2.Visible = true;
            label1.Visible = true;
            cmbEditInsuranceType.Visible = true;
            btnSelectMode.Visible = true;
            btnSaveChanges.Visible = true;
            btnDelete.Visible = true;
            cmbSelectInsurance.Visible = false;
            btnPatientSelection.Visible = false;
            label13.Visible = false;
        }

        //ordering indexes
        void indx()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                txbInsuranceName.TabIndex = 0;
                cmbInsuranceType.TabIndex = 1;
                btnSave.TabIndex = 2;
                txbInsuranceName.Focus();
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                cmbSelectInsurance.TabIndex = 0;
                btnPatientSelection.TabIndex = 1;
                cmbEditInsuranceType.TabIndex = 2;
                btnSaveChanges.TabIndex = 3;
                btnDelete.TabIndex = 4;
                btnSelectMode.TabIndex = 5;

                if (cmbSelectInsurance.Visible == true)
                {
                    cmbSelectInsurance.Focus();
                }
                else
                {
                    cmbEditInsuranceType.Focus();
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

        private void frmInsurances_Activated(object sender, EventArgs e)
        {
            //dark mode
            if (MedicalLab.Properties.Settings.Default.Theme == 'D')
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                pictureBox1.BackColor = Color.DimGray;
                label3.BackColor = Color.DimGray;
                btnClean.BackColor = Color.DimGray;
                dgvInsurances.BackgroundColor = Color.Gray;
                tabPage3.BackColor = Color.FromArgb(45, 45, 48);
                tabPage1.BackColor = Color.FromArgb(45, 45, 48);
                tabPage2.BackColor = Color.FromArgb(45, 45, 48);
            }
            display();
            dgvInsurances.ClearSelection();
            indx();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txbInsuranceName.Text = string.Empty;
            cmbInsuranceType.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool tmp = false;
                for (int i = 0; i < dgvInsurances.Rows.Count; i++)
                {
                    if (dgvInsurances.Rows[i].Cells[1].Value.ToString() == txbInsuranceName.Text.ToString())
                    {
                        tmp = true;
                        break;
                    }
                }

                if (tmp == true)
                {
                    MessageBox.Show("اطلاعات بیمه با این نام ثبت شده است", "تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (txbInsuranceName.Text != string.Empty)
                    {
                            cmd.Parameters.Clear();
                            cmd.Connection = con;
                            cmd.CommandText = "insert into TBLInsurances(InsurancesName,InsurancesType) values (@a,@b)";
                            cmd.Parameters.AddWithValue("@a", txbInsuranceName.Text.Trim());
                            cmd.Parameters.AddWithValue("@b", cmbInsuranceType.Text.Trim());
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("آیا از حذف اطلاعات مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    cmd.Parameters.Clear();
                    cmd.Connection = con;
                    cmd.CommandText = "delete from TBLInsurances where InsurancesName=@InsName1";
                    cmd.Parameters.AddWithValue("@InsName1", txbEditByName.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display();
                    MessageBox.Show("حذف اطلاعات با موفقیت انجام شد");
                    btnClean_Click(sender, e);
                    cmbSelectInsurance.Text = string.Empty;
                    btnSelectMode_Click(sender, e);
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
                DialogResult res = MessageBox.Show("آیا از انجام تغییرات مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    cmd.Parameters.Clear();
                    cmd.Connection = con;
                    cmd.CommandText = "update TBLInsurances set InsurancesName=@InsName ,InsurancesType=@InsType where InsurancesName = @InsName";
                    cmd.Parameters.AddWithValue("@InsName", txbEditByName.Text.Trim());
                    cmd.Parameters.AddWithValue("@InsType", cmbEditInsuranceType.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display();
                    MessageBox.Show("ویرایش اطلاعات با موفقیت انجام شد");
                    cmbSelectInsurance.Text = string.Empty;
                    btnSelectMode_Click(sender, e);
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
                dgvInsurances.ClearSelection();

                int temp = 0;
                bool temp1 = false;
                for (int i = 0; i < dgvInsurances.Rows.Count; i++)
                {
                    if (dgvInsurances.Rows[i].Cells[1].Value.ToString() == cmbSelectInsurance.Text.ToString())
                    {
                        dgvInsurances.Rows[i].Selected = true;
                        temp = i;
                        temp1 = true;
                        break;
                    }
                }
                if (temp1 == true)
                {
                    txbEditByName.Text = dgvInsurances[1, temp].Value.ToString();
                    cmbEditInsuranceType.Text = dgvInsurances[2, temp].Value.ToString();

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
            dgvInsurances.ClearSelection();

            int temp = 0;
            bool temp1 = false;

            //find the value in datagridview
            for (int i = 0; i < dgvInsurances.Rows.Count; i++)
            {

                if (dgvInsurances.Rows[i].Cells[1].Value.ToString() == cmbSearch.Text.ToString().Trim())
                {

                    dgvInsurances.Rows[i].Selected = true;
                    temp = i;
                    temp1 = true;
                    break;
                }
            }
            if (temp1 == true)
            {
                dgvInsurances.FirstDisplayedScrollingRowIndex = temp;
            }
            else
            {
                MessageBox.Show("لطفا مقدار فیلد را به درستی وارد نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            //capability of moving the form
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indx();
            if (tabControl1.SelectedTab == tabPage1)
            {
                btnClean.Visible = true;
            }
            else
            {
                btnClean.Visible = false;
            }
        }

        private void txbInsuranceName_KeyDown(object sender, KeyEventArgs e)
        {
            //next textbox by enter
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbEditInsuranceName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cmbEditInsuranceType_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cmbInsuranceType_KeyDown(object sender, KeyEventArgs e)
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

        private void txbEditByName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cmbSelectInsurance_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
