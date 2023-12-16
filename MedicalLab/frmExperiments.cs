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
using System.Numerics;

namespace MedicalLab
{
    public partial class frmExperiments : Form
    {
        public frmExperiments()
        {
            InitializeComponent();

            display();
            hideOptions();

            dgvExperiments.ColumnHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvExperiments.DefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvExperiments.RowHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);

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
            adp.SelectCommand.CommandText = "select * from TBLExperiments";
            //fill the dataset from tabel of database
            adp.Fill(ds, "TBLExperiments");

            cmbExperimentSelection.DisplayMember = "ExperimentName";
            cmbExperimentSelection.ValueMember = "ExperimentName";
            cmbExperimentSelection.DataSource = ds.Tables["TBLExperiments"];

            cmbSearch.DisplayMember = "ExperimentName";
            cmbSearch.ValueMember = "ExperimentName";
            cmbSearch.DataSource = ds.Tables["TBLExperiments"];

            dgvExperiments.DataSource = ds;
            dgvExperiments.DataMember = "TBLExperiments";

            dgvExperiments.Columns[0].HeaderText = "شناسه";
            dgvExperiments.Columns[1].HeaderText = "نام";
            dgvExperiments.Columns[2].HeaderText = "نام اختصاری";
            dgvExperiments.Columns[3].HeaderText = "کد ملی";
            dgvExperiments.Columns[4].HeaderText = "واحد اندازه گیری";
            dgvExperiments.Columns[5].HeaderText = "تعرفه با بیمه";
            dgvExperiments.Columns[6].HeaderText = "تعرفه بدون بیمه";

            cmbExperimentSelection.SelectedIndex = -1;
            cmbSearch.SelectedIndex = -1;
        }

        void hideOptions()
        {
            cmbExperimentSelection.Visible = true;
            label13.Visible = true;
            txbEditAbbreviated.Visible = false;
            txbEditByName.Visible = false;
            txbEditNationalCode.Visible = false;
            txbEditTariffWithInsurances.Visible = false;
            txbEditTariffWithoutInsurances.Visible = false;
            txbEditUnit.Visible = false;
            label25.Visible = false;
            label24.Visible = false;
            label23.Visible = false;
            label21.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            btnSelectMode.Visible = false;
            btnSaveChanges.Visible = false;
            btnDelete.Visible = false;
            btnPatientSelection.Visible = true;
        }
        void showOptions()
        {
            cmbExperimentSelection.Visible = false;
            label13.Visible = false;
            txbEditAbbreviated.Visible = true;
            txbEditByName.Visible = true;
            txbEditNationalCode.Visible = true;
            txbEditTariffWithInsurances.Visible = true;
            txbEditTariffWithoutInsurances.Visible = true;
            txbEditUnit.Visible = true;
            label25.Visible = true;
            label24.Visible = true;
            label23.Visible = true;
            label21.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            btnSelectMode.Visible = true;
            btnSaveChanges.Visible = true;
            btnDelete.Visible = true;
            btnPatientSelection.Visible = false;
        }

        //ordering indexes
        void indx()
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                txbName.TabIndex = 0;
                txbAbbreviated.TabIndex = 1;
                txbNationalCode.TabIndex = 2;
                txbUnit.TabIndex = 3;
                txbTariffWithInsurances.TabIndex = 4;
                txbTariffWithoutInsurances.TabIndex = 5;
                btnSave.TabIndex = 6;
                txbName.Focus();
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                cmbExperimentSelection.TabIndex = 0;
                btnPatientSelection.TabIndex = 1;
                txbEditAbbreviated.TabIndex = 2;
                txbEditNationalCode.TabIndex = 3;
                txbEditUnit.TabIndex = 4;
                txbEditTariffWithInsurances.TabIndex = 5;
                txbEditTariffWithoutInsurances.TabIndex = 6;
                cmbExperimentSelection.TabIndex = 7;
                btnSaveChanges.TabIndex = 8;
                btnDelete.TabIndex = 9;
                btnSelectMode.TabIndex = 10;

                if (cmbExperimentSelection.Visible == true)
                {
                    cmbExperimentSelection.Focus();
                }
                else
                {
                    txbEditAbbreviated.Focus();
                }
            }
            if (tabControl1.SelectedTab == tabPage1)
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
            txbAbbreviated.Text = string.Empty;
            txbName.Text = string.Empty;
            txbNationalCode.Text = string.Empty;
            txbTariffWithInsurances.Text = string.Empty;
            txbTariffWithoutInsurances.Text = string.Empty;
            txbUnit.Text = string.Empty;
        }

        private void label26_MouseDown(object sender, MouseEventArgs e)
        {
            //capability of moving the form
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmExperiments_Activated(object sender, EventArgs e)
        {
            //dark mode
            if (MedicalLab.Properties.Settings.Default.Theme == 'D')
            {
                this.BackColor = Color.Gray;
                pictureBox1.BackColor = Color.DimGray;
                tabPage1.BackColor = Color.FromArgb(45, 45, 48);
                tabPage2.BackColor = Color.FromArgb(45, 45, 48);
                tabPage3.BackColor = Color.FromArgb(45, 45, 48);
                label26.BackColor = Color.DimGray;
                btnSave.BackColor = Color.DimGray;
                btnSaveChanges.BackColor = Color.DimGray;
                btnClean.BackColor = Color.DimGray;
                dgvExperiments.BackgroundColor = Color.Gray;
                btnSelectMode.BackColor = Color.DimGray;
            }
            display();
            indx();
        }

        

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbTariffWithInsurances.Text.Length > 18 || txbTariffWithoutInsurances.Text.Length > 18)
                {
                    MessageBox.Show("مقدار تعرفه ها بیش از حد معمول می باشد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txbEditTariffWithInsurances.Text == string.Empty)
                        txbEditTariffWithInsurances.Text = "0";
                    if (txbEditTariffWithoutInsurances.Text == string.Empty)
                        txbEditTariffWithoutInsurances.Text = "0";

                    ToPersian.EngNumToPrs(txbEditTariffWithInsurances);
                    ToPersian.EngNumToPrs(txbEditTariffWithoutInsurances);

                    if (txbEditByName.Text != string.Empty && txbEditNationalCode.Text != string.Empty && txbEditUnit.Text != string.Empty)
                    {
                            DialogResult res = MessageBox.Show("آیا از انجام تغییرات مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (res == DialogResult.Yes)
                            {
                                cmd.Parameters.Clear();
                                cmd.Connection = con;
                                cmd.CommandText = "update TBLExperiments set ExperimentName = @Name , ExperimentAbbreviated = @Abbreviated , ExperimentNationalCode = @NationalCode,  ExperimentUnit = @Unit,TariffWithInsurances = @TariffWith , TariffWithoutInsurances = @TariffWithout where ExperimentName = @Name";
                                cmd.Parameters.AddWithValue("@Name", txbEditByName.Text.Trim());
                                cmd.Parameters.AddWithValue("@Abbreviated", txbEditAbbreviated.Text.Trim());
                                cmd.Parameters.AddWithValue("@NationalCode", txbEditNationalCode.Text.Trim());
                                cmd.Parameters.AddWithValue("@Unit", txbEditUnit.Text.Trim());
                                cmd.Parameters.AddWithValue("@TariffWith", Convert.ToUInt64(txbEditTariffWithInsurances.Text.Trim()));
                                cmd.Parameters.AddWithValue("@TariffWithout", Convert.ToUInt64(txbEditTariffWithoutInsurances.Text.Trim()));
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                display();
                                MessageBox.Show("ویرایش اطلاعات با موفقیت انجام شد");
                                txbEditAbbreviated.Text = string.Empty;
                                txbEditNationalCode.Text = string.Empty;
                                txbEditUnit.Text = string.Empty;
                                txbEditTariffWithInsurances.Text = string.Empty;
                                txbEditTariffWithoutInsurances.Text = string.Empty;
                                cmbExperimentSelection.Text = string.Empty;
                                btnSelectMode_Click(sender, e);
                            }
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
                if (txbEditByName.Text != string.Empty && txbEditNationalCode.Text != string.Empty && txbEditUnit.Text != string.Empty)
                {
                    DialogResult res = MessageBox.Show("آیا از حذف اطلاعات مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        cmd.Parameters.Clear();
                        cmd.Connection = con;
                        cmd.CommandText = "delete from TBLExperiments where ExperimentName=@ExpName";
                        cmd.Parameters.AddWithValue("@ExpName", txbEditByName.Text.Trim());
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        display();
                        MessageBox.Show("حذف اطلاعات با موفقیت انجام شد");
                        btnClean_Click(sender, e);
                        txbEditAbbreviated.Text = string.Empty;
                        txbEditNationalCode.Text = string.Empty;
                        txbEditUnit.Text = string.Empty;
                        txbEditTariffWithInsurances.Text = string.Empty;
                        txbEditTariffWithoutInsurances.Text = string.Empty;
                        cmbExperimentSelection.Text = string.Empty;
                        btnSelectMode_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("لطفا فیلد های خالی را تکمیل نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //entering data of database in textboxes
        private void btnPatientSelection_Click(object sender, EventArgs e)
        {
            try
            {
                dgvExperiments.ClearSelection();

                int temp = 0;
                bool temp1 = false;

                for (int i = 0; i < dgvExperiments.Rows.Count; i++)
                {
                    if (dgvExperiments.Rows[i].Cells[1].Value.ToString() == cmbExperimentSelection.Text.ToString().Trim())
                    {
                        dgvExperiments.Rows[i].Selected = true;
                        temp = i;
                        temp1 = true;
                        break;
                    }
                }
                if (temp1 == true)
                {
                    txbEditByName.Text = dgvExperiments[1, temp].Value.ToString();
                    txbEditAbbreviated.Text = dgvExperiments[2, temp].Value.ToString();
                    txbEditNationalCode.Text = dgvExperiments[3, temp].Value.ToString();
                    txbEditUnit.Text = dgvExperiments[4, temp].Value.ToString();
                    txbEditTariffWithInsurances.Text = dgvExperiments[5, temp].Value.ToString();
                    txbEditTariffWithoutInsurances.Text = dgvExperiments[6, temp].Value.ToString();

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
            try
            {
                dgvExperiments.ClearSelection();

                int temp = 0;
                bool temp1 = false;

                //find the value in datagridview
                for (int i = 0; i < dgvExperiments.Rows.Count; i++)
                {
                    if (dgvExperiments.Rows[i].Cells[1].Value.ToString() == cmbSearch.Text.ToString().Trim())
                    {
                        dgvExperiments.Rows[i].Selected = true;
                        temp = i;
                        temp1 = true;
                        break;
                    }
                }
                if (temp1 == true)
                {

                    dgvExperiments.FirstDisplayedScrollingRowIndex = temp;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbTariffWithInsurances.Text.Length > 18 || txbTariffWithoutInsurances.Text.Length > 18)
                {
                    MessageBox.Show("مقدار تعرفه ها بیش از حد معمول می باشد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txbTariffWithInsurances.Text == string.Empty)
                        txbTariffWithInsurances.Text = "0";
                    if (txbTariffWithoutInsurances.Text == string.Empty)
                        txbTariffWithoutInsurances.Text = "0";

                    ToPersian.EngNumToPrs(txbTariffWithInsurances);
                    ToPersian.EngNumToPrs(txbTariffWithoutInsurances);

                    bool tmp = false;
                    for (int i = 0; i < dgvExperiments.Rows.Count; i++)
                    {
                        if (dgvExperiments.Rows[i].Cells[1].Value.ToString() == txbName.Text.ToString())
                        {
                            tmp = true;
                            break;
                        }
                    }

                    if (tmp == true)
                    {
                        MessageBox.Show("اطلاعات آزمایش با این نام ثبت شده است", "تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txbName.Text != string.Empty && txbNationalCode.Text != string.Empty && txbUnit.Text != string.Empty)
                        {
                                cmd.Parameters.Clear();
                                cmd.Connection = con;
                                cmd.CommandText = "insert into TBLExperiments(ExperimentName,ExperimentAbbreviated,ExperimentNationalCode,ExperimentUnit,TariffWithInsurances,TariffWithoutInsurances) values (@a,@b,@c,@d,@e,@f)";
                                cmd.Parameters.AddWithValue("@a", txbName.Text.Trim());
                                cmd.Parameters.AddWithValue("@b", txbAbbreviated.Text.Trim());
                                cmd.Parameters.AddWithValue("@c", txbNationalCode.Text.Trim());
                                cmd.Parameters.AddWithValue("@d", txbUnit.Text.Trim());
                                cmd.Parameters.AddWithValue("@e", Convert.ToUInt64(txbTariffWithInsurances.Text.Trim()));
                                cmd.Parameters.AddWithValue("@f", Convert.ToUInt64(txbTariffWithoutInsurances.Text.Trim()));
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indx();

            if (tabControl1.SelectedTab == tabPage2)
            {
                btnClean.Visible = true;
            }
            else
            {
                btnClean.Visible = false;
            }
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

        private void txbAbbreviated_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbReceptionCode_KeyDown(object sender, KeyEventArgs e)
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

        private void txbUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbTariffWithInsurances_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbTariffWithoutInsurances_KeyDown(object sender, KeyEventArgs e)
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

        private void txbEditAbbreviated_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbEditReceptionCode_KeyDown(object sender, KeyEventArgs e)
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

        private void txbEditUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbEditTariffWithInsurances_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbEditTariffWithoutInsurances_KeyDown(object sender, KeyEventArgs e)
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

        private void cmbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbTariffWithInsurances_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txbEditNationalCode_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbEditNationalCode);
        }

        private void txbNationalCode_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbNationalCode);
        }

        private void txbEditTariffWithInsurances_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbEditTariffWithInsurances);
        }

        private void txbTariffWithInsurances_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbTariffWithInsurances);
        }

        private void txbTariffWithoutInsurances_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbTariffWithoutInsurances);
        }

        private void txbEditTariffWithoutInsurances_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(txbEditTariffWithoutInsurances);
        }
    }
}
