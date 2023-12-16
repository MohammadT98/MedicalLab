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
using MD.PersianDateTime;
using System.Collections;
using System.Text.RegularExpressions;

namespace MedicalLab
{
    public partial class frmPatientReception : Form
    {
        int incNum = 0;
        public frmPatientReception()
        {
            InitializeComponent();
            dgvforShow.ColumnHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvforShow.DefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvforShow.RowHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
            display();

            incNum = 0;

            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "delete from TBLPatientReceptionTemp";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            dgvDoc.Visible = false;
            dgvSamp.Visible = false;

            indx();

            cmbDoctorLastName.Visible = false;
            cmbSamplingPhysicianLastName.Visible = false;
            label5.Visible = false;
            label1.Visible = false;
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
            adp.SelectCommand.CommandText = "select * from TBLPatientReception";
            adp.Fill(ds, "TBLPatientReception");

            dgvPatientReception.DataSource = ds;
            dgvPatientReception.DataMember = "TBLPatientReception";

            DataSet ds1 = new DataSet();
            adp.SelectCommand.CommandText = "select ExperimentName from TBLExperiments";
            adp.Fill(ds1, "TBLExperiments");

            cmbExperiment.DisplayMember = "ExperimentName";
            cmbExperiment.ValueMember = "ExperimentName";
            cmbExperiment.DataSource = ds1.Tables["TBLExperiments"];

            DataSet ds2 = new DataSet();
            adp.SelectCommand.CommandText = "select DoctorName,DoctorLastName from TBLDoctorsInformation";
            adp.Fill(ds2, "TBLDoctorsInformation");

            cmbDoctorName.DisplayMember = "DoctorName";
            cmbDoctorName.ValueMember = "DoctorName";
            cmbDoctorName.DataSource = ds2.Tables["TBLDoctorsInformation"];

            dgvDoc.DataSource = ds2;
            dgvDoc.DataMember = "TBLDoctorsInformation";

            DataSet ds3 = new DataSet();
            adp.SelectCommand.CommandText = "select SamplingPhysicianName,SamplingPhysicianLastName from TBLSamplingPhysician";
            adp.Fill(ds3, "TBLSamplingPhysician");

            cmbSamplingPhysicianName.DisplayMember = "SamplingPhysicianName";
            cmbSamplingPhysicianName.ValueMember = "SamplingPhysicianName";
            cmbSamplingPhysicianName.DataSource = ds3.Tables["TBLSamplingPhysician"];

            dgvSamp.DataSource = ds3;
            dgvSamp.DataMember = "TBLSamplingPhysician";

            DataSet ds4 = new DataSet();
            adp.SelectCommand.CommandText = "select AcceptanceID,PatientNationalCode,ExperimentName,DoctorName & ' ' & DoctorLastName as DocName,SamplingPhysicianName & ' ' & SamplingPhysicianLastName as sampName,AcceptanceDate,AcceptanceTime from TBLPatientReceptionTemp";
            adp.Fill(ds4, "TBLPatientReceptionTemp");

            dgvforShow.DataSource = ds4;
            dgvforShow.DataMember = "TBLPatientReceptionTemp";

            cmbSearch.DisplayMember = "PatientNationalCode";
            cmbSearch.ValueMember = "PatientNationalCode";
            cmbSearch.DataSource = ds4.Tables["TBLPatientReceptionTemp"];


            DataSet ds5 = new DataSet();
            adp.SelectCommand.CommandText = "select PatientNationalCode from TBLPatientInformation";
            adp.Fill(ds5, "TBLPatientInformation");

            cmbNC.DisplayMember = "PatientNationalCode";
            cmbNC.ValueMember = "PatientNationalCode";
            cmbNC.DataSource = ds5.Tables["TBLPatientInformation"];

            dgvforShow.Columns[0].HeaderText = "شماره پذیرش";
            dgvforShow.Columns[1].HeaderText = "کد ملی بیمار";
            dgvforShow.Columns[2].HeaderText = "آزمایش";
            dgvforShow.Columns[3].HeaderText = "پزشک";
            dgvforShow.Columns[4].HeaderText = "پزشک نمونه بردار";
            dgvforShow.Columns[5].HeaderText = "تاریخ";
            dgvforShow.Columns[6].HeaderText = "زمان";

            cmbNC.Text = string.Empty;
            cmbExperiment.Text = string.Empty;
            cmbDoctorName.Text = string.Empty;
            cmbDoctorLastName.Text = string.Empty;
            cmbSamplingPhysicianName.Text = string.Empty;
            cmbSamplingPhysicianLastName.Text = string.Empty;

            cmbSearch.SelectedIndex = -1;
        }

        void indx()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                cmbNC.TabIndex = 0;
                cmbExperiment.TabIndex = 1;
                cmbDoctorName.TabIndex = 2;
                cmbDoctorLastName.TabIndex = 3;
                cmbSamplingPhysicianName.TabIndex = 4;
                cmbSamplingPhysicianLastName.TabIndex = 5;
                btnSave.TabIndex = 6;
                cmbNC.Focus();
            }
            if (tabControl1.SelectedTab == tabPage2)
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

        private void frmPatientReception_Activated(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'D')
            {
                this.BackColor = Color.Gray;
                pictureBox1.BackColor = Color.DimGray;
                tabPage1.BackColor = Color.FromArgb(45, 45, 48);
                tabPage2.BackColor = Color.FromArgb(45, 45, 48);
                label2.ForeColor = Color.White;
                lblTotal.ForeColor = Color.White;
                label15.ForeColor = Color.White;
                label16.ForeColor = Color.White;
                label17.ForeColor = Color.White;
                btnSave.BackColor = Color.DimGray;
                label4.BackColor = Color.DimGray;
                label7.ForeColor = Color.White;
                btnClean.BackColor = Color.DimGray;
                dgvPatientReception.BackgroundColor = Color.Gray;
                lblSelect.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label5.ForeColor = Color.White;
            }
            display();
            lblTotal.Text = dgvforShow.Rows.Count.ToString();
            indx();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNC.Text != string.Empty && cmbExperiment.Text != string.Empty && cmbDoctorName.Text != string.Empty && cmbDoctorLastName.Text != string.Empty && cmbSamplingPhysicianName.Text != string.Empty && cmbSamplingPhysicianLastName.Text != string.Empty)
                {
                        var persianDateTime = new PersianDateTime(DateTime.Now);

                        incNum = incNum + 1;

                        cmd.Parameters.Clear();
                        cmd.Connection = con;
                        cmd.CommandText = "insert into TBLPatientReception(AcceptanceID,PatientNationalCode,ExperimentName,DoctorName,DoctorLastName,SamplingPhysicianName,SamplingPhysicianLastName,AcceptanceDate,AcceptanceTime) values (@a,@b,@c,@d,@e,@f,@g,@h,@i)";
                        cmd.Parameters.AddWithValue("@a", incNum);
                        cmd.Parameters.AddWithValue("@b", cmbNC.Text.Trim());
                        cmd.Parameters.AddWithValue("@c", cmbExperiment.Text.Trim());
                        cmd.Parameters.AddWithValue("@d", cmbDoctorName.Text.Trim());
                        cmd.Parameters.AddWithValue("@e", cmbDoctorLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@f", cmbSamplingPhysicianName.Text.Trim());
                        cmd.Parameters.AddWithValue("@g", cmbSamplingPhysicianLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@h", persianDateTime.Date.ToShortDateString().ToString().Trim());
                        cmd.Parameters.AddWithValue("@i", persianDateTime.TimeOfDay.ToString().Trim());

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        cmd.Parameters.Clear();
                        cmd.Connection = con;
                        cmd.CommandText = "insert into TBLPatientReceptionTemp(AcceptanceID,PatientNationalCode,ExperimentName,DoctorName,DoctorLastName,SamplingPhysicianName,SamplingPhysicianLastName,AcceptanceDate,AcceptanceTime) values (@a,@b,@c,@d,@e,@f,@g,@h,@i)";
                        cmd.Parameters.AddWithValue("@a", incNum);
                        cmd.Parameters.AddWithValue("@b", cmbNC.Text);
                        cmd.Parameters.AddWithValue("@c", cmbExperiment.Text);
                        cmd.Parameters.AddWithValue("@d", cmbDoctorName.Text);
                        cmd.Parameters.AddWithValue("@e", cmbDoctorLastName.Text);
                        cmd.Parameters.AddWithValue("@f", cmbSamplingPhysicianName.Text);
                        cmd.Parameters.AddWithValue("@g", cmbSamplingPhysicianLastName.Text);
                        cmd.Parameters.AddWithValue("@h", persianDateTime.Date.ToShortDateString().ToString());
                        cmd.Parameters.AddWithValue("@i", persianDateTime.TimeOfDay.ToString());

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            dgvforShow.ClearSelection();

            int temp = 0;
            bool temp1 = false;
            for (int i = 0; i < dgvforShow.Rows.Count; i++)
            {
                if (dgvforShow.Rows[i].Cells[1].Value.ToString() == cmbSearch.Text.ToString().Trim())
                {
                    dgvforShow.Rows[i].Selected = true;
                    temp = i;
                    temp1 = true;
                    break;
                }
            }
            if (temp1 == true)
            {

                dgvforShow.FirstDisplayedScrollingRowIndex = temp;
            }
            else
            {
                MessageBox.Show("لطفا مقدار فیلد را به درستی وارد نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cmbNC.Text = string.Empty;
            cmbDoctorName.Text = string.Empty;
            cmbDoctorLastName.Text = string.Empty;
            cmbExperiment.Text = string.Empty;
            cmbSamplingPhysicianName.Text = string.Empty;
            cmbSamplingPhysicianLastName.Text = string.Empty;
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
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

        private void txbNC_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cmbExperiment_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cmbDoctorName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cmbDoctorLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cmbSamplingPhysicianName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cmbSamplingPhysicianLastName_KeyDown(object sender, KeyEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmbDoctorLastName.Visible = true;
                label1.Visible = true;

                cmbDoctorLastName.Items.Clear();

                ArrayList arl = new ArrayList();

                for (int i = 0; i < dgvDoc.Rows.Count; i++)
                {
                    if (dgvDoc.Rows[i].Cells[0].Value.ToString() == cmbDoctorName.Text.ToString().Trim())
                    {
                        arl.Add(dgvDoc.Rows[i].Cells[1].Value.ToString());
                    }
                }

                object[] array = arl.ToArray();

                cmbDoctorLastName.Items.AddRange(array);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
            cmbSamplingPhysicianLastName.Visible = true;
            label5.Visible = true;

            cmbSamplingPhysicianLastName.Items.Clear();

            ArrayList arl = new ArrayList();

            for (int i = 0; i < dgvSamp.Rows.Count; i++)
            {
                if (dgvSamp.Rows[i].Cells[0].Value.ToString() == cmbSamplingPhysicianName.Text.ToString().Trim())
                {
                    arl.Add(dgvSamp.Rows[i].Cells[1].Value.ToString());
                }
            }

            object[] array = arl.ToArray();

            cmbSamplingPhysicianLastName.Items.AddRange(array);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbNC_TextChanged(object sender, EventArgs e)
        {
            RegeX.OnlyNumbers(cmbNC);
        }

        private void cmbDoctorName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(cmbDoctorName);
        }

        private void cmbDoctorLastName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(cmbDoctorLastName);
        }

        private void cmbSamplingPhysicianName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(cmbSamplingPhysicianName);
        }

        private void cmbSamplingPhysicianLastName_TextChanged(object sender, EventArgs e)
        {
            ToPersian.CheckPersianWithoutNumbers(cmbSamplingPhysicianLastName);
        }
    }
}
