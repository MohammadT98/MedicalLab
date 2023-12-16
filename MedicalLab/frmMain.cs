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


namespace MedicalLab
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            //for dark mode/light mode
            if(MedicalLab.Properties.Settings.Default.Theme == 'L')
            {
                this.BackColor = Color.MintCream;
                btnCenterSpecifications.BackColor = Color.White;
                btnDoctorsInformation.BackColor = Color.White;
                btnExperiments.BackColor = Color.White;
                btnFinancialReport.BackColor = Color.White;
                btnInsurances.BackColor = Color.White;
                btnPatientInformation.BackColor = Color.White;
                btnPatientInformationReport.BackColor = Color.White;
                btnPatientReception.BackColor = Color.White;
                btnReceptioners.BackColor = Color.White;
                btnResults.BackColor = Color.White;
                btnSamplingPhysician.BackColor = Color.White;
                BtnSupport.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                btnCenterSpecifications.BackColor = Color.DimGray;
                btnDoctorsInformation.BackColor = Color.DimGray;
                btnExperiments.BackColor = Color.DimGray;
                btnFinancialReport.BackColor = Color.DimGray;
                btnInsurances.BackColor = Color.DimGray;
                btnPatientInformation.BackColor = Color.DimGray;
                btnPatientInformationReport.BackColor = Color.DimGray;
                btnPatientReception.BackColor = Color.DimGray;
                btnReceptioners.BackColor = Color.DimGray;
                btnResults.BackColor = Color.DimGray;
                btnSamplingPhysician.BackColor = Color.DimGray;
                BtnSupport.BackColor = Color.DimGray;
            }
        }

        frmMessageBox1 frmMsg;
        frmSetting sform = new frmSetting();
        frmPatientInformation patientInformationForm = new frmPatientInformation();
        frmPatientReception patientReceptionForm = new frmPatientReception();
        frmSamplingPhysician samplingPhysicianForm = new frmSamplingPhysician();
        frmResults resultsForm = new frmResults();
        frmPatientInformationReport patientInformationReportForm = new frmPatientInformationReport();
        frmDoctorsInformation doctorsInformationForm = new frmDoctorsInformation();
        frmReceptioners receptionersForm = new frmReceptioners();
        frmFinancialReport financialReportForm = new frmFinancialReport();
        frmExperiments experimentsForm = new frmExperiments();
        frmInsurances insurancesForm = new frmInsurances();
        frmCenterSpecifications centerSpecificationsForm = new frmCenterSpecifications();
        frmSupport supportForm = new frmSupport();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMsg = new frmMessageBox1();
            frmMsg.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            sform.ShowDialog();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnPatientReception_Click(object sender, EventArgs e)
        {
                patientReceptionForm.Show();
                patientReceptionForm.Focus();
        }

        private void btnPatientInformation_Click(object sender, EventArgs e)
        {
                patientInformationForm.Show();
                patientInformationForm.Focus();
        }

        private void btnSamplingPhysician_Click(object sender, EventArgs e)
        {
                samplingPhysicianForm.Show();
                samplingPhysicianForm.Focus();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
                resultsForm.Show();
                resultsForm.Focus();
        }

        private void btnPatientInformationReport_Click(object sender, EventArgs e)
        {
                patientInformationReportForm.Show();
                patientInformationReportForm.Focus();
        }

        private void btnDoctorsInformation_Click(object sender, EventArgs e)
        {
                doctorsInformationForm.Show();
                doctorsInformationForm.Focus();
        }

        private void btnReceptioners_Click(object sender, EventArgs e)
        {
                receptionersForm.Show();
                receptionersForm.Focus();
        }

        private void btnFinancialReport_Click(object sender, EventArgs e)
        {
                financialReportForm.Show();
                financialReportForm.Focus();
        }

        private void btnExperiments_Click(object sender, EventArgs e)
        {
                experimentsForm.Show();
                experimentsForm.Focus();
        }

        private void btnInsurances_Click(object sender, EventArgs e)
        {
                insurancesForm.Show();
                insurancesForm.Focus();
        }

        private void btnCenterSpecifications_Click(object sender, EventArgs e)
        {
                centerSpecificationsForm.Show();
                centerSpecificationsForm.Focus();
        }

        private void BtnSupport_Click(object sender, EventArgs e)
        {
                supportForm.Show();
                supportForm.Focus();
        }

        private void btnPatientReception_MouseEnter(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnPatientReception.BackColor = Color.SlateGray;
            else btnPatientReception.BackColor = Color.Gray;
        }

        private void btnPatientReception_MouseLeave(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnPatientReception.BackColor = Color.White;
            else btnPatientReception.BackColor = Color.SlateGray;
        }

        private void btnPatientInformation_MouseEnter(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnPatientInformation.BackColor = Color.SlateGray;
            else btnPatientInformation.BackColor = Color.Gray;
        }

        private void btnPatientInformation_MouseLeave(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnPatientInformation.BackColor = Color.White;
            else btnPatientInformation.BackColor = Color.SlateGray;
        }

        private void btnSamplingPhysician_MouseEnter(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnSamplingPhysician.BackColor = Color.SlateGray;
            else btnSamplingPhysician.BackColor = Color.Gray;
        }

        private void btnSamplingPhysician_MouseLeave(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnSamplingPhysician.BackColor = Color.White;
            else btnSamplingPhysician.BackColor = Color.SlateGray;
        }

        private void btnResults_MouseEnter(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnResults.BackColor = Color.SlateGray;
            else btnResults.BackColor = Color.Gray;
        }

        private void btnResults_MouseLeave(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnResults.BackColor = Color.White;
            else btnResults.BackColor = Color.SlateGray;
        }

        private void btnPatientInformationReport_MouseEnter(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnPatientInformationReport.BackColor = Color.SlateGray;
            else btnPatientInformationReport.BackColor = Color.Gray;
        }

        private void btnPatientInformationReport_MouseLeave(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnPatientInformationReport.BackColor = Color.White;
            else btnPatientInformationReport.BackColor = Color.SlateGray;
        }

        private void btnDoctorsInformation_MouseEnter(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnDoctorsInformation.BackColor = Color.SlateGray;
            else btnDoctorsInformation.BackColor = Color.Gray;
        }

        private void btnDoctorsInformation_MouseLeave(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnDoctorsInformation.BackColor = Color.White;
            else btnDoctorsInformation.BackColor = Color.SlateGray;
        }

        private void btnReceptioners_MouseEnter(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnReceptioners.BackColor = Color.SlateGray;
            else btnReceptioners.BackColor = Color.Gray;
        }

        private void btnReceptioners_MouseLeave(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnReceptioners.BackColor = Color.White;
            else btnReceptioners.BackColor = Color.SlateGray;
        }

        private void btnFinancialReport_MouseEnter(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnFinancialReport.BackColor = Color.SlateGray;
            else btnFinancialReport.BackColor = Color.Gray;
        }

        private void btnFinancialReport_MouseLeave(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnFinancialReport.BackColor = Color.White;
            else btnFinancialReport.BackColor = Color.SlateGray;
        }

        private void btnExperiments_MouseEnter(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnExperiments.BackColor = Color.SlateGray;
            else btnExperiments.BackColor = Color.Gray;
        }

        private void btnExperiments_MouseLeave(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnExperiments.BackColor = Color.White;
            else btnExperiments.BackColor = Color.SlateGray;
        }

        private void btnInsurances_MouseEnter(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnInsurances.BackColor = Color.SlateGray;
            else btnInsurances.BackColor = Color.Gray;
        }

        private void btnInsurances_MouseLeave(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnInsurances.BackColor = Color.White;
            else btnInsurances.BackColor = Color.SlateGray;
        }

        private void btnCenterSpecifications_MouseEnter(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnCenterSpecifications.BackColor = Color.SlateGray;
            else btnCenterSpecifications.BackColor = Color.Gray;
        }

        private void btnCenterSpecifications_MouseLeave(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') btnCenterSpecifications.BackColor = Color.White;
            else btnCenterSpecifications.BackColor = Color.SlateGray;
        }

        private void BtnSupport_MouseEnter(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') BtnSupport.BackColor = Color.SlateGray;
            else BtnSupport.BackColor = Color.Gray;
        }

        private void BtnSupport_MouseLeave(object sender, EventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L') BtnSupport.BackColor = Color.White;
            else BtnSupport.BackColor = Color.SlateGray;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.DarkRed;
            btnClose.ForeColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
            btnClose.ForeColor = Color.DarkRed;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.DarkRed;
            btnMinimize.ForeColor = Color.White;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.White;
            btnMinimize.ForeColor = Color.DarkRed;
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (MedicalLab.Properties.Settings.Default.Theme == 'L')
            {
                this.BackColor = Color.MintCream;
                btnCenterSpecifications.BackColor = Color.White;
                btnDoctorsInformation.BackColor = Color.White;
                btnExperiments.BackColor = Color.White;
                btnFinancialReport.BackColor = Color.White;
                btnInsurances.BackColor = Color.White;
                btnPatientInformation.BackColor = Color.White;
                btnPatientInformationReport.BackColor = Color.White;
                btnPatientReception.BackColor = Color.White;
                btnReceptioners.BackColor = Color.White;
                btnResults.BackColor = Color.White;
                btnSamplingPhysician.BackColor = Color.White;
                BtnSupport.BackColor = Color.White;
            }

            if (MedicalLab.Properties.Settings.Default.Theme == 'D')
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                btnCenterSpecifications.BackColor = Color.DimGray;
                btnDoctorsInformation.BackColor = Color.DimGray;
                btnExperiments.BackColor = Color.DimGray;
                btnFinancialReport.BackColor = Color.DimGray;
                btnInsurances.BackColor = Color.DimGray;
                btnPatientInformation.BackColor = Color.DimGray;
                btnPatientInformationReport.BackColor = Color.DimGray;
                btnPatientReception.BackColor = Color.DimGray;
                btnReceptioners.BackColor = Color.DimGray;
                btnResults.BackColor = Color.DimGray;
                btnSamplingPhysician.BackColor = Color.DimGray;
                BtnSupport.BackColor = Color.DimGray;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            btnPatientReception.Focus();
        }
    }
}
