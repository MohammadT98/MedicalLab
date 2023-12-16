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
using System.Drawing.Printing;
using System.Drawing.Imaging;
using MD.PersianDateTime;

namespace MedicalLab
{
    public partial class frmResults : Form
    {
        Bitmap buffer;
        public frmResults()
        {
            InitializeComponent();
            dgvResults.ColumnHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvResults.DefaultCellStyle.Font = new Font("B Nazanin", 9);
            dgvResults.RowHeadersDefaultCellStyle.Font = new Font("B Nazanin", 9);
            display();

            buffer = new Bitmap(pcbPrint.Width, pcbPrint.Height);

            pcbPrint.BringToFront();

            btnPrint.Visible = false;
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
            PersianDateTime prs = new PersianDateTime(PersianDateTime.Now);

            DataSet ds = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter();
            adp.SelectCommand = new OleDbCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "select distinct TBLPatientReception.PatientNationalCode from TBLExperiments,TBLPatientReception,TBLPatientInformation where TBLExperiments.ExperimentName = TBLPatientReception.ExperimentName and TBLPatientReception.PatientNationalCode = TBLPatientInformation.PatientNationalCode and AcceptanceDate = '" + prs.Date.ToShortDateString().ToString() + "'";
            adp.Fill(ds, "TBLPatientReception");

            dgvResults.DataSource = ds;
            dgvResults.DataMember = "TBLPatientReception";

            cmbSelect.DisplayMember = "PatientNationalCode";
            cmbSelect.ValueMember = "PatientNationalCode";
            cmbSelect.DataSource = ds.Tables["TBLPatientReception"];

            cmbSelect.SelectedIndex = -1;
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

        private void frmResults_Activated(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'D')
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                pictureBox1.BackColor = Color.DimGray;
                lblAcceptanceID.ForeColor = Color.White;
                lblPatient.ForeColor = Color.White;
                lblDate.ForeColor = Color.White;
                lblDoctor.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                lblSamp.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                lblTotal2.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label11.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                lblTime.ForeColor = Color.White;
                lblTotal1.ForeColor = Color.White;
                label13.BackColor = Color.DimGray;
                dgvResults.BackgroundColor = Color.Gray;
                pcbPrint.BackColor = Color.Gray;
                lblAcceptanceID.BackColor = Color.Gray;
                lblPatient.BackColor = Color.Gray;
                lblDate.BackColor = Color.Gray;
                lblDoctor.BackColor = Color.Gray;
                label1.BackColor = Color.Gray;
                lblSamp.BackColor = Color.Gray;
                label3.BackColor = Color.Gray;
                lblTotal2.BackColor = Color.Gray;
                label5.BackColor = Color.FromArgb(45, 45, 48);
                label6.BackColor = Color.Gray;
                label7.BackColor = Color.Gray;
                label8.BackColor = Color.Gray;
                label9.BackColor = Color.Gray;
                label10.BackColor = Color.Gray;
                label11.BackColor = Color.Gray;
                label12.BackColor = Color.Gray;
                lblTime.BackColor = Color.Gray;
                lblTotal1.BackColor = Color.Gray;
            }
            dgvForShow.ClearSelection();
            display();
            cmbSelect.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog svd = new SaveFileDialog();

                using (Graphics G = pcbPrint.CreateGraphics())
                {
                    G.DrawRectangle(Pens.Blue, 0, 0, 0, 0);
                }
                Bitmap BMP = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);

                using (Graphics GFX = Graphics.FromImage(BMP))
                {
                    GFX.CopyFromScreen(Screen.PrimaryScreen.Bounds.X + 6, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                }
                Bitmap YourPictureBoxImage = new Bitmap(pcbPrint.Width, pcbPrint.Height);
                using (Graphics g = Graphics.FromImage(YourPictureBoxImage))
                {
                    //MessageBox.Show(pcbPrint.Height.ToString());
                    Point np = pcbPrint.PointToScreen(new Point(0, 0));
                    g.DrawImage(BMP, new Rectangle(0, 0, pcbPrint.Width, pcbPrint.Height), new Rectangle(np, pcbPrint.Size), GraphicsUnit.Pixel);
                }

                svd.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.PNG";
                if (svd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.FileStream fs = (System.IO.FileStream)svd.OpenFile();
                    YourPictureBoxImage.Save(fs, ImageFormat.Png);
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
                var persianDateTime = new PersianDateTime(DateTime.Now);

                string temp = "\0";
                bool temp1 = false;
                for (int i = 0; i < dgvResults.Rows.Count; i++)
                {
                    if (dgvResults.Rows[i].Cells[0].Value.ToString() == cmbSelect.Text.ToString().Trim())
                    {
                        temp = dgvResults.Rows[i].Cells[0].Value.ToString();
                        temp1 = true;
                        break;
                    }
                }

                if (temp1 == true)
                {
                    DataSet ds = new DataSet();
                    OleDbDataAdapter adp = new OleDbDataAdapter();
                    adp.SelectCommand = new OleDbCommand();
                    adp.SelectCommand.Connection = con;

                    adp.SelectCommand.CommandText = "select TBLPatientReception.AcceptanceID,TBLPatientInformation.PatientName & ' ' & TBLPatientInformation.PatientLastName as PatientN,TBLPatientReception.DoctorName & ' ' & TBLPatientReception.DoctorLastName as DoctorN,TBLPatientReception.SamplingPhysicianName & ' ' & TBLPatientReception.SamplingPhysicianLastName as SampN,TBLPatientReception.AcceptanceDate,TBLPatientReception.AcceptanceTime from TBLExperiments,TBLPatientReception,TBLPatientInformation where TBLExperiments.ExperimentName = TBLPatientReception.ExperimentName and  TBLPatientReception.AcceptanceDate = '" + persianDateTime.Date.ToShortDateString().ToString() + "' and TBLPatientReception.PatientNationalCode = TBLPatientInformation.PatientNationalCode and TBLPatientReception.PatientNationalCode = '" + temp + "'";
                    adp.Fill(ds, "TBLPatientReception");

                    dgvForLabels.DataSource = ds;
                    dgvForLabels.DataMember = "TBLPatientReception";

                    if (dgvForLabels.Rows.Count != 0)
                    {
                        btnPrint.Visible = true;
                        pcbPrint.SendToBack();
                        lblAcceptanceID.Text = dgvForLabels.Rows[0].Cells[0].Value.ToString();
                        lblPatient.Text = dgvForLabels.Rows[0].Cells[1].Value.ToString();
                        lblDoctor.Text = dgvForLabels.Rows[0].Cells[2].Value.ToString();
                        lblSamp.Text = dgvForLabels.Rows[0].Cells[3].Value.ToString();
                        lblDate.Text = dgvForLabels.Rows[0].Cells[4].Value.ToString();
                        lblTime.Text = dgvForLabels.Rows[0].Cells[5].Value.ToString();

                        DataSet ds1 = new DataSet();
                        adp.SelectCommand.CommandText = "select TBLPatientReception.ExperimentName,TBLExperiments.TariffWithInsurances,TBLExperiments.TariffWithoutInsurances from TBLExperiments,TBLPatientReception,TBLPatientInformation where TBLExperiments.ExperimentName = TBLPatientReception.ExperimentName and TBLPatientReception.AcceptanceDate = '" + persianDateTime.Date.ToShortDateString().ToString() + "' and TBLPatientReception.PatientNationalCode = TBLPatientInformation.PatientNationalCode and TBLPatientReception.PatientNationalCode = '" + temp + "'";
                        adp.Fill(ds1, "TBLPatientReception");

                        dgvForShow.DataSource = ds1;
                        dgvForShow.DataMember = "TBLPatientReception";

                        dgvForShow.Columns[0].HeaderText = "نام آزمایش";
                        dgvForShow.Columns[1].HeaderText = "تعرفه با بیمه";
                        dgvForShow.Columns[2].HeaderText = "تعرفه بدون بیمه";

                        dgvForShow.ClearSelection();

                        int lblT1 = 0;

                        for (int i = 0; i < dgvForShow.Rows.Count; i++)
                        {
                            lblT1 += Convert.ToInt32(dgvForShow.Rows[i].Cells[1].Value.ToString());
                        }
                        lblTotal1.Text = lblT1.ToString();

                        int lblT2 = 0;

                        for (int i = 0; i < dgvForShow.Rows.Count; i++)
                        {
                            lblT2 += Convert.ToInt32(dgvForShow.Rows[i].Cells[2].Value.ToString());
                        }
                        lblTotal2.Text = lblT2.ToString();
                    }
                    else
                    {
                        MessageBox.Show("پذیرشی برای امروز ثبت نشده است که نتیجه ی آن نشان داده شود", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
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

        private void label13_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void cmbSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
