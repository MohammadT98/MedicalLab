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
    public partial class frmPatientInformationReport : Form
    {
        public frmPatientInformationReport()
        {
            InitializeComponent();
            dgvPatients.ColumnHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvPatients.DefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvPatients.RowHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
        }

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

            cmbSearch.DisplayMember = "PatientNationalCode";
            cmbSearch.ValueMember = "PatientNationalCode";
            cmbSearch.DataSource = ds.Tables["TBLPatientInformation"];

            dgvPatients.DataSource = ds;
            dgvPatients.DataMember = "TBLPatientInformation";

            dgvPatients.Columns[0].HeaderText = "شناسه";
            dgvPatients.Columns[1].HeaderText = "نام";
            dgvPatients.Columns[2].HeaderText = "نام خانوادگی";
            dgvPatients.Columns[3].HeaderText = "نام پدر";
            dgvPatients.Columns[4].HeaderText = "کد ملی";
            dgvPatients.Columns[5].HeaderText = "شماره تلفن";
            dgvPatients.Columns[6].HeaderText = "جنسیت";
            dgvPatients.Columns[7].HeaderText = "بیمه";
            dgvPatients.Columns[8].HeaderText = "آدرس";

            cmbSearch.SelectedIndex = -1;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmPatientInformationReport_Activated(object sender, EventArgs e)
        {
            display();

            if (MedicalLab.Properties.Settings.Default.Theme == 'D')
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                pictureBox1.BackColor = Color.DimGray;
                label1.ForeColor = Color.White;
                label3.BackColor = Color.DimGray;
                dgvPatients.BackgroundColor = Color.Gray;
                lblTotal.ForeColor = Color.White;
                lblSelect.ForeColor = Color.White;
            }
            lblTotal.Text = dgvPatients.Rows.Count.ToString();
            display();
            cmbSearch.Focus();
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPatients.ClearSelection();

                int temp = 0;
                bool temp1 = false;
                for (int i = 0; i < dgvPatients.Rows.Count; i++)
                {

                    if (dgvPatients.Rows[i].Cells[4].Value.ToString() == cmbSearch.Text.ToString().Trim())
                    {

                        dgvPatients.Rows[i].Selected = true;
                        temp = i;
                        temp1 = true;
                        break;
                    }
                }
                if (temp1 == true)
                {
                    dgvPatients.FirstDisplayedScrollingRowIndex = temp;
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

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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
    }
}
