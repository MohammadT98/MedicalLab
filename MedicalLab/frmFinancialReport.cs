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
    public partial class frmFinancialReport : Form
    {
        public frmFinancialReport()
        {
            InitializeComponent();
            display();
            dgvFinancialReport.ColumnHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvFinancialReport.DefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvFinancialReport.RowHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
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
            adp.SelectCommand.CommandText = "select TBLPatientReception.ExperimentName,TBLPatientReception.AcceptanceDate,TBLExperiments.TariffWithInsurances,TBLExperiments.TariffWithoutInsurances from TBLPatientReception,TBLExperiments where TBLPatientReception.ExperimentName = TBLExperiments.ExperimentName ";
            adp.Fill(ds, "TBLPatientReception");

            cmbSearch.DisplayMember = "AcceptanceDate";
            cmbSearch.ValueMember = "AcceptanceDate";
            cmbSearch.DataSource = ds.Tables["TBLPatientReception"];

            dgvFinancialReport.DataSource = ds;
            dgvFinancialReport.DataMember = "TBLPatientReception";

            dgvFinancialReport.Columns[0].HeaderText = "نام";
            dgvFinancialReport.Columns[1].HeaderText = "تاریخ";
            dgvFinancialReport.Columns[2].HeaderText = "تعرفه با بیمه";
            dgvFinancialReport.Columns[3].HeaderText = "تعرفه بدون بیمه";

            cmbSearch.SelectedIndex = -1;
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

        private void frmFinancialReport_Activated(object sender, EventArgs e)
        {
            dgvFinancialReport.ClearSelection();

            if (MedicalLab.Properties.Settings.Default.Theme == 'D')
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                pictureBox1.BackColor = Color.DimGray;
                label5.BackColor = Color.DimGray;
                dgvFinancialReport.BackgroundColor = Color.Gray;
            }
            display();

            int total1 = 0;

            for (int i = 0; i < dgvFinancialReport.Rows.Count; i++)
            {
                total1 += Convert.ToInt32(dgvFinancialReport.Rows[i].Cells[2].Value.ToString());
            }
            lblTotal1.Text = total1.ToString();

            int total2 = 0;

            for (int i = 0; i < dgvFinancialReport.Rows.Count; i++)
            {
                total2 += Convert.ToInt32(dgvFinancialReport.Rows[i].Cells[3].Value.ToString());
            }
            lblTotal2.Text = total2.ToString();

            cmbSearch.Focus();
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            try
            {
                dgvFinancialReport.ClearSelection();

                int temp = 0;
                bool temp1 = false;
                for (int i = 0; i < dgvFinancialReport.Rows.Count; i++)
                {
                    if (dgvFinancialReport.Rows[i].Cells[1].Value.ToString() == cmbSearch.Text.ToString().Trim())
                    {
                        dgvFinancialReport.Rows[i].Selected = true;
                        temp1 = true;
                        temp = i;
                    }
                }
                if (temp1 == true)
                {
                    dgvFinancialReport.FirstDisplayedScrollingRowIndex = temp;
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

        private void label5_MouseDown(object sender, MouseEventArgs e)
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

        private void frmFinancialReport_Shown_1(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "delete from TBLPatientReceptionTemp";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Connection = con;
            for (int i = 0; i < dgvFinancialReport.Rows.Count; i++)
            {
                cmd.CommandText = "insert into TBLFinancialReport(ExperimentName,ExperimentDate,TariffWithInsurances,TariffWithoutInsurances) values (@a,@b,@c,@d)";
                cmd.Parameters.AddWithValue("@a", dgvFinancialReport.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@b", dgvFinancialReport.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@c", dgvFinancialReport.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@d", dgvFinancialReport.Rows[i].Cells[3].Value.ToString());
            }
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
