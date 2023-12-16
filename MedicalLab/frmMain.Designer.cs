namespace MedicalLab
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnPatientReception = new System.Windows.Forms.Button();
            this.btnReceptioners = new System.Windows.Forms.Button();
            this.btnSamplingPhysician = new System.Windows.Forms.Button();
            this.btnDoctorsInformation = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnPatientInformation = new System.Windows.Forms.Button();
            this.btnExperiments = new System.Windows.Forms.Button();
            this.btnFinancialReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCenterSpecifications = new System.Windows.Forms.Button();
            this.btnInsurances = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnPatientInformationReport = new System.Windows.Forms.Button();
            this.BtnSupport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "آزمایشگاه پزشکی";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2131, 153);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(41, 43);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 52);
            this.btnClose.TabIndex = 10;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "❌";
            this.toolTip1.SetToolTip(this.btnClose, "خروج");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.DarkRed;
            this.btnMinimize.Location = new System.Drawing.Point(153, 43);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(59, 52);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "➖";
            this.toolTip1.SetToolTip(this.btnMinimize, "کوچک نمایی");
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.White;
            this.btnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.BackgroundImage")));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSetting.Location = new System.Drawing.Point(1999, 33);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(88, 82);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSetting, "تنظیمات کلی");
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnPatientReception
            // 
            this.btnPatientReception.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatientReception.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPatientReception.BackgroundImage")));
            this.btnPatientReception.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPatientReception.Location = new System.Drawing.Point(41, 205);
            this.btnPatientReception.Name = "btnPatientReception";
            this.btnPatientReception.Size = new System.Drawing.Size(403, 346);
            this.btnPatientReception.TabIndex = 0;
            this.btnPatientReception.UseVisualStyleBackColor = false;
            this.btnPatientReception.Click += new System.EventHandler(this.btnPatientReception_Click);
            this.btnPatientReception.MouseEnter += new System.EventHandler(this.btnPatientReception_MouseEnter);
            this.btnPatientReception.MouseLeave += new System.EventHandler(this.btnPatientReception_MouseLeave);
            // 
            // btnReceptioners
            // 
            this.btnReceptioners.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReceptioners.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReceptioners.BackgroundImage")));
            this.btnReceptioners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReceptioners.Location = new System.Drawing.Point(1136, 654);
            this.btnReceptioners.Name = "btnReceptioners";
            this.btnReceptioners.Size = new System.Drawing.Size(403, 346);
            this.btnReceptioners.TabIndex = 6;
            this.btnReceptioners.UseVisualStyleBackColor = false;
            this.btnReceptioners.Click += new System.EventHandler(this.btnReceptioners_Click);
            this.btnReceptioners.MouseEnter += new System.EventHandler(this.btnReceptioners_MouseEnter);
            this.btnReceptioners.MouseLeave += new System.EventHandler(this.btnReceptioners_MouseLeave);
            // 
            // btnSamplingPhysician
            // 
            this.btnSamplingPhysician.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSamplingPhysician.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSamplingPhysician.BackgroundImage")));
            this.btnSamplingPhysician.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSamplingPhysician.Location = new System.Drawing.Point(589, 654);
            this.btnSamplingPhysician.Name = "btnSamplingPhysician";
            this.btnSamplingPhysician.Size = new System.Drawing.Size(403, 346);
            this.btnSamplingPhysician.TabIndex = 5;
            this.btnSamplingPhysician.UseVisualStyleBackColor = false;
            this.btnSamplingPhysician.Click += new System.EventHandler(this.btnSamplingPhysician_Click);
            this.btnSamplingPhysician.MouseEnter += new System.EventHandler(this.btnSamplingPhysician_MouseEnter);
            this.btnSamplingPhysician.MouseLeave += new System.EventHandler(this.btnSamplingPhysician_MouseLeave);
            // 
            // btnDoctorsInformation
            // 
            this.btnDoctorsInformation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDoctorsInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoctorsInformation.BackgroundImage")));
            this.btnDoctorsInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoctorsInformation.Location = new System.Drawing.Point(41, 654);
            this.btnDoctorsInformation.Name = "btnDoctorsInformation";
            this.btnDoctorsInformation.Size = new System.Drawing.Size(403, 346);
            this.btnDoctorsInformation.TabIndex = 4;
            this.btnDoctorsInformation.UseVisualStyleBackColor = false;
            this.btnDoctorsInformation.Click += new System.EventHandler(this.btnDoctorsInformation_Click);
            this.btnDoctorsInformation.MouseEnter += new System.EventHandler(this.btnDoctorsInformation_MouseEnter);
            this.btnDoctorsInformation.MouseLeave += new System.EventHandler(this.btnDoctorsInformation_MouseLeave);
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResults.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResults.BackgroundImage")));
            this.btnResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResults.Location = new System.Drawing.Point(1683, 205);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(403, 346);
            this.btnResults.TabIndex = 3;
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            this.btnResults.MouseEnter += new System.EventHandler(this.btnResults_MouseEnter);
            this.btnResults.MouseLeave += new System.EventHandler(this.btnResults_MouseLeave);
            // 
            // btnPatientInformation
            // 
            this.btnPatientInformation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatientInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPatientInformation.BackgroundImage")));
            this.btnPatientInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPatientInformation.Location = new System.Drawing.Point(589, 205);
            this.btnPatientInformation.Name = "btnPatientInformation";
            this.btnPatientInformation.Size = new System.Drawing.Size(403, 346);
            this.btnPatientInformation.TabIndex = 1;
            this.btnPatientInformation.UseVisualStyleBackColor = false;
            this.btnPatientInformation.Click += new System.EventHandler(this.btnPatientInformation_Click);
            this.btnPatientInformation.MouseEnter += new System.EventHandler(this.btnPatientInformation_MouseEnter);
            this.btnPatientInformation.MouseLeave += new System.EventHandler(this.btnPatientInformation_MouseLeave);
            // 
            // btnExperiments
            // 
            this.btnExperiments.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExperiments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExperiments.BackgroundImage")));
            this.btnExperiments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExperiments.Location = new System.Drawing.Point(41, 1102);
            this.btnExperiments.Name = "btnExperiments";
            this.btnExperiments.Size = new System.Drawing.Size(403, 346);
            this.btnExperiments.TabIndex = 8;
            this.btnExperiments.UseVisualStyleBackColor = false;
            this.btnExperiments.Click += new System.EventHandler(this.btnExperiments_Click);
            this.btnExperiments.MouseEnter += new System.EventHandler(this.btnExperiments_MouseEnter);
            this.btnExperiments.MouseLeave += new System.EventHandler(this.btnExperiments_MouseLeave);
            // 
            // btnFinancialReport
            // 
            this.btnFinancialReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinancialReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinancialReport.BackgroundImage")));
            this.btnFinancialReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFinancialReport.Location = new System.Drawing.Point(1683, 654);
            this.btnFinancialReport.Name = "btnFinancialReport";
            this.btnFinancialReport.Size = new System.Drawing.Size(403, 346);
            this.btnFinancialReport.TabIndex = 7;
            this.btnFinancialReport.UseVisualStyleBackColor = false;
            this.btnFinancialReport.Click += new System.EventHandler(this.btnFinancialReport_Click);
            this.btnFinancialReport.MouseEnter += new System.EventHandler(this.btnFinancialReport_MouseEnter);
            this.btnFinancialReport.MouseLeave += new System.EventHandler(this.btnFinancialReport_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.label1.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(861, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 87);
            this.label1.TabIndex = 11;
            this.label1.Text = "آزمایشگاه پزشکی";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnCenterSpecifications
            // 
            this.btnCenterSpecifications.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCenterSpecifications.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCenterSpecifications.BackgroundImage")));
            this.btnCenterSpecifications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCenterSpecifications.Location = new System.Drawing.Point(1136, 1102);
            this.btnCenterSpecifications.Name = "btnCenterSpecifications";
            this.btnCenterSpecifications.Size = new System.Drawing.Size(403, 346);
            this.btnCenterSpecifications.TabIndex = 10;
            this.btnCenterSpecifications.UseVisualStyleBackColor = false;
            this.btnCenterSpecifications.Click += new System.EventHandler(this.btnCenterSpecifications_Click);
            this.btnCenterSpecifications.MouseEnter += new System.EventHandler(this.btnCenterSpecifications_MouseEnter);
            this.btnCenterSpecifications.MouseLeave += new System.EventHandler(this.btnCenterSpecifications_MouseLeave);
            // 
            // btnInsurances
            // 
            this.btnInsurances.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsurances.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsurances.BackgroundImage")));
            this.btnInsurances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsurances.Location = new System.Drawing.Point(589, 1102);
            this.btnInsurances.Name = "btnInsurances";
            this.btnInsurances.Size = new System.Drawing.Size(403, 346);
            this.btnInsurances.TabIndex = 9;
            this.btnInsurances.UseVisualStyleBackColor = false;
            this.btnInsurances.Click += new System.EventHandler(this.btnInsurances_Click);
            this.btnInsurances.MouseEnter += new System.EventHandler(this.btnInsurances_MouseEnter);
            this.btnInsurances.MouseLeave += new System.EventHandler(this.btnInsurances_MouseLeave);
            // 
            // btnPatientInformationReport
            // 
            this.btnPatientInformationReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatientInformationReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPatientInformationReport.BackgroundImage")));
            this.btnPatientInformationReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPatientInformationReport.Location = new System.Drawing.Point(1136, 205);
            this.btnPatientInformationReport.Name = "btnPatientInformationReport";
            this.btnPatientInformationReport.Size = new System.Drawing.Size(403, 346);
            this.btnPatientInformationReport.TabIndex = 2;
            this.btnPatientInformationReport.UseVisualStyleBackColor = false;
            this.btnPatientInformationReport.Click += new System.EventHandler(this.btnPatientInformationReport_Click);
            this.btnPatientInformationReport.MouseEnter += new System.EventHandler(this.btnPatientInformationReport_MouseEnter);
            this.btnPatientInformationReport.MouseLeave += new System.EventHandler(this.btnPatientInformationReport_MouseLeave);
            // 
            // BtnSupport
            // 
            this.BtnSupport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSupport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSupport.BackgroundImage")));
            this.BtnSupport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSupport.Location = new System.Drawing.Point(1683, 1102);
            this.BtnSupport.Name = "BtnSupport";
            this.BtnSupport.Size = new System.Drawing.Size(403, 346);
            this.BtnSupport.TabIndex = 11;
            this.BtnSupport.UseVisualStyleBackColor = false;
            this.BtnSupport.Click += new System.EventHandler(this.BtnSupport_Click);
            this.BtnSupport.MouseEnter += new System.EventHandler(this.BtnSupport_MouseEnter);
            this.BtnSupport.MouseLeave += new System.EventHandler(this.BtnSupport_MouseLeave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(2131, 1487);
            this.Controls.Add(this.BtnSupport);
            this.Controls.Add(this.btnCenterSpecifications);
            this.Controls.Add(this.btnInsurances);
            this.Controls.Add(this.btnPatientInformationReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinancialReport);
            this.Controls.Add(this.btnExperiments);
            this.Controls.Add(this.btnPatientInformation);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnDoctorsInformation);
            this.Controls.Add(this.btnSamplingPhysician);
            this.Controls.Add(this.btnReceptioners);
            this.Controls.Add(this.btnPatientReception);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnPatientReception;
        private System.Windows.Forms.Button btnReceptioners;
        private System.Windows.Forms.Button btnSamplingPhysician;
        private System.Windows.Forms.Button btnDoctorsInformation;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnPatientInformation;
        private System.Windows.Forms.Button btnExperiments;
        private System.Windows.Forms.Button btnFinancialReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCenterSpecifications;
        private System.Windows.Forms.Button btnInsurances;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnPatientInformationReport;
        private System.Windows.Forms.Button BtnSupport;
    }
}