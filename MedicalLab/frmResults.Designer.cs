namespace MedicalLab
{
    partial class frmResults
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResults));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAcceptanceID = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.dgvForShow = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSamp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pcbPrint = new System.Windows.Forms.PictureBox();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelection = new System.Windows.Forms.Button();
            this.dgvForLabels = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForLabels)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1760, 91);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(22, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 52);
            this.btnClose.TabIndex = 16;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "❌";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Azure;
            this.label13.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 14F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(734, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(262, 71);
            this.label13.TabIndex = 48;
            this.label13.Text = "جواب آزمایش";
            this.label13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label13_MouseDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label12.Location = new System.Drawing.Point(1565, 288);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(99, 42);
            this.label12.TabIndex = 56;
            this.label12.Text = "نام بیمار";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label11.Location = new System.Drawing.Point(949, 189);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(115, 42);
            this.label11.TabIndex = 55;
            this.label11.Text = "نام پزشک";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label10.Location = new System.Drawing.Point(322, 187);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(144, 42);
            this.label10.TabIndex = 54;
            this.label10.Text = "تاریخ پذیرش";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label9.Location = new System.Drawing.Point(310, 288);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(155, 42);
            this.label9.TabIndex = 53;
            this.label9.Text = "ساعت پذیرش";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label8.Location = new System.Drawing.Point(1510, 187);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(151, 42);
            this.label8.TabIndex = 52;
            this.label8.Text = "شماره پذیرش";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label6.Location = new System.Drawing.Point(1510, 990);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 42);
            this.label6.TabIndex = 50;
            this.label6.Text = "هزینه کل آزمایش";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label7.Location = new System.Drawing.Point(175, 1063);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 42);
            this.label7.TabIndex = 51;
            this.label7.Text = "امضا پزشک";
            // 
            // lblAcceptanceID
            // 
            this.lblAcceptanceID.AutoSize = true;
            this.lblAcceptanceID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAcceptanceID.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAcceptanceID.Location = new System.Drawing.Point(1245, 197);
            this.lblAcceptanceID.Name = "lblAcceptanceID";
            this.lblAcceptanceID.Size = new System.Drawing.Size(53, 43);
            this.lblAcceptanceID.TabIndex = 57;
            this.lblAcceptanceID.Text = "lbl";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPatient.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPatient.Location = new System.Drawing.Point(1245, 292);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(53, 43);
            this.lblPatient.TabIndex = 58;
            this.lblPatient.Text = "lbl";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.Location = new System.Drawing.Point(81, 189);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 43);
            this.lblDate.TabIndex = 60;
            this.lblDate.Text = "lbl";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDoctor.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDoctor.Location = new System.Drawing.Point(632, 189);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(53, 43);
            this.lblDoctor.TabIndex = 61;
            this.lblDoctor.Text = "lbl";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.Location = new System.Drawing.Point(81, 290);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 43);
            this.lblTime.TabIndex = 62;
            this.lblTime.Text = "lbl";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal1.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotal1.Location = new System.Drawing.Point(1120, 999);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(53, 43);
            this.lblTotal1.TabIndex = 63;
            this.lblTotal1.Text = "lbl";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToOrderColumns = true;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResults.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.Location = new System.Drawing.Point(32, 386);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.RowHeadersWidth = 92;
            this.dgvResults.RowTemplate.Height = 37;
            this.dgvResults.Size = new System.Drawing.Size(1694, 557);
            this.dgvResults.TabIndex = 64;
            this.dgvResults.TabStop = false;
            // 
            // dgvForShow
            // 
            this.dgvForShow.AllowUserToAddRows = false;
            this.dgvForShow.AllowUserToDeleteRows = false;
            this.dgvForShow.AllowUserToOrderColumns = true;
            this.dgvForShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvForShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvForShow.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvForShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvForShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvForShow.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvForShow.Location = new System.Drawing.Point(32, 386);
            this.dgvForShow.MultiSelect = false;
            this.dgvForShow.Name = "dgvForShow";
            this.dgvForShow.ReadOnly = true;
            this.dgvForShow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvForShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvForShow.RowHeadersWidth = 92;
            this.dgvForShow.RowTemplate.Height = 37;
            this.dgvForShow.Size = new System.Drawing.Size(1694, 557);
            this.dgvForShow.TabIndex = 65;
            this.dgvForShow.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label1.Location = new System.Drawing.Point(835, 288);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(224, 42);
            this.label1.TabIndex = 66;
            this.label1.Text = "نام پزشک نمونه بردار";
            // 
            // lblSamp
            // 
            this.lblSamp.AutoSize = true;
            this.lblSamp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSamp.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSamp.Location = new System.Drawing.Point(632, 288);
            this.lblSamp.Name = "lblSamp";
            this.lblSamp.Size = new System.Drawing.Size(53, 43);
            this.lblSamp.TabIndex = 67;
            this.lblSamp.Text = "lbl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label3.Location = new System.Drawing.Point(1438, 1072);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 42);
            this.label3.TabIndex = 68;
            this.label3.Text = "هزینه کل آزمایش با بیمه";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal2.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotal2.Location = new System.Drawing.Point(1120, 1074);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(53, 43);
            this.lblTotal2.TabIndex = 69;
            this.lblTotal2.Text = "lbl";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(1887, 1063);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(210, 141);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pcbPrint
            // 
            this.pcbPrint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pcbPrint.Location = new System.Drawing.Point(-3, 98);
            this.pcbPrint.Name = "pcbPrint";
            this.pcbPrint.Size = new System.Drawing.Size(1766, 1191);
            this.pcbPrint.TabIndex = 71;
            this.pcbPrint.TabStop = false;
            // 
            // cmbSelect
            // 
            this.cmbSelect.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Location = new System.Drawing.Point(1850, 98);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSelect.Size = new System.Drawing.Size(306, 51);
            this.cmbSelect.TabIndex = 0;
            this.cmbSelect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSelect_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label5.Location = new System.Drawing.Point(2024, 55);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(136, 42);
            this.label5.TabIndex = 73;
            this.label5.Text = "انتخاب بیمار";
            // 
            // btnSelection
            // 
            this.btnSelection.BackColor = System.Drawing.Color.Azure;
            this.btnSelection.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold);
            this.btnSelection.Location = new System.Drawing.Point(2051, 180);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(105, 57);
            this.btnSelection.TabIndex = 1;
            this.btnSelection.Text = "انتخاب";
            this.btnSelection.UseVisualStyleBackColor = false;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // dgvForLabels
            // 
            this.dgvForLabels.AllowUserToAddRows = false;
            this.dgvForLabels.AllowUserToDeleteRows = false;
            this.dgvForLabels.AllowUserToOrderColumns = true;
            this.dgvForLabels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvForLabels.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvForLabels.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvForLabels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvForLabels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvForLabels.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvForLabels.Location = new System.Drawing.Point(32, 386);
            this.dgvForLabels.MultiSelect = false;
            this.dgvForLabels.Name = "dgvForLabels";
            this.dgvForLabels.ReadOnly = true;
            this.dgvForLabels.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvForLabels.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvForLabels.RowHeadersWidth = 92;
            this.dgvForLabels.RowTemplate.Height = 37;
            this.dgvForLabels.Size = new System.Drawing.Size(1694, 557);
            this.dgvForLabels.TabIndex = 132;
            this.dgvForLabels.TabStop = false;
            // 
            // frmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(2211, 1290);
            this.Controls.Add(this.dgvForShow);
            this.Controls.Add(this.dgvForLabels);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSelect);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSamp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.lblTotal1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.lblAcceptanceID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcbPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmResults_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForLabels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAcceptanceID;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridView dgvForShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSamp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox pcbPrint;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.DataGridView dgvForLabels;
    }
}