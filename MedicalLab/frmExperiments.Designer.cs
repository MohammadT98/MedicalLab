namespace MedicalLab
{
    partial class frmExperiments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExperiments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txbTariffWithInsurances = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbTariffWithoutInsurances = new System.Windows.Forms.TextBox();
            this.txbNationalCode = new System.Windows.Forms.TextBox();
            this.txbUnit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAbbreviated = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txbEditByName = new System.Windows.Forms.TextBox();
            this.btnSelectMode = new System.Windows.Forms.Button();
            this.btnPatientSelection = new System.Windows.Forms.Button();
            this.txbEditTariffWithoutInsurances = new System.Windows.Forms.TextBox();
            this.txbEditNationalCode = new System.Windows.Forms.TextBox();
            this.txbEditUnit = new System.Windows.Forms.TextBox();
            this.txbEditTariffWithInsurances = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txbEditAbbreviated = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cmbExperimentSelection = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnSelection = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.dgvExperiments = new System.Windows.Forms.DataGridView();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperiments)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1159, 91);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(27, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 52);
            this.btnClose.TabIndex = 17;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "❌";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.AliceBlue;
            this.btnClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClean.BackgroundImage")));
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClean.Location = new System.Drawing.Point(1066, 6);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(85, 76);
            this.btnClean.TabIndex = 29;
            this.btnClean.TabStop = false;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(0, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1160, 858);
            this.tabControl1.TabIndex = 56;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage2.Controls.Add(this.txbTariffWithInsurances);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.txbTariffWithoutInsurances);
            this.tabPage2.Controls.Add(this.txbNationalCode);
            this.tabPage2.Controls.Add(this.txbUnit);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txbAbbreviated);
            this.tabPage2.Controls.Add(this.txbName);
            this.tabPage2.Font = new System.Drawing.Font("A Chamran", 8F);
            this.tabPage2.Location = new System.Drawing.Point(10, 58);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1140, 790);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "آزمایش جدید";
            // 
            // txbTariffWithInsurances
            // 
            this.txbTariffWithInsurances.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbTariffWithInsurances.Location = new System.Drawing.Point(61, 106);
            this.txbTariffWithInsurances.Name = "txbTariffWithInsurances";
            this.txbTariffWithInsurances.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbTariffWithInsurances.Size = new System.Drawing.Size(420, 50);
            this.txbTariffWithInsurances.TabIndex = 80;
            this.txbTariffWithInsurances.TextChanged += new System.EventHandler(this.txbTariffWithInsurances_TextChanged);
            this.txbTariffWithInsurances.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTariffWithInsurances_KeyDown_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(440, 622);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(270, 118);
            this.btnSave.TabIndex = 79;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbTariffWithoutInsurances
            // 
            this.txbTariffWithoutInsurances.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbTariffWithoutInsurances.Location = new System.Drawing.Point(61, 244);
            this.txbTariffWithoutInsurances.Name = "txbTariffWithoutInsurances";
            this.txbTariffWithoutInsurances.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbTariffWithoutInsurances.Size = new System.Drawing.Size(420, 50);
            this.txbTariffWithoutInsurances.TabIndex = 78;
            this.txbTariffWithoutInsurances.TextChanged += new System.EventHandler(this.txbTariffWithoutInsurances_TextChanged);
            this.txbTariffWithoutInsurances.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTariffWithoutInsurances_KeyDown);
            // 
            // txbNationalCode
            // 
            this.txbNationalCode.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbNationalCode.Location = new System.Drawing.Point(646, 382);
            this.txbNationalCode.Name = "txbNationalCode";
            this.txbNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbNationalCode.Size = new System.Drawing.Size(420, 50);
            this.txbNationalCode.TabIndex = 76;
            this.txbNationalCode.TextChanged += new System.EventHandler(this.txbNationalCode_TextChanged);
            this.txbNationalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNationalCode_KeyDown);
            // 
            // txbUnit
            // 
            this.txbUnit.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbUnit.Location = new System.Drawing.Point(646, 520);
            this.txbUnit.Name = "txbUnit";
            this.txbUnit.Size = new System.Drawing.Size(420, 50);
            this.txbUnit.TabIndex = 75;
            this.txbUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbUnit_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(322, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 41);
            this.label12.TabIndex = 68;
            this.label12.Text = "تعرفه بدون بیمه";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(357, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 41);
            this.label11.TabIndex = 67;
            this.label11.Text = "تعرفه با بیمه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(906, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 41);
            this.label5.TabIndex = 61;
            this.label5.Text = "واحد اندازه گیری";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(989, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 41);
            this.label3.TabIndex = 59;
            this.label3.Text = "کد ملی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(945, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 41);
            this.label2.TabIndex = 58;
            this.label2.Text = "نام اختصاری";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(953, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 41);
            this.label1.TabIndex = 57;
            this.label1.Text = "نام آزمایش";
            // 
            // txbAbbreviated
            // 
            this.txbAbbreviated.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbAbbreviated.Location = new System.Drawing.Point(646, 244);
            this.txbAbbreviated.Name = "txbAbbreviated";
            this.txbAbbreviated.Size = new System.Drawing.Size(420, 50);
            this.txbAbbreviated.TabIndex = 56;
            this.txbAbbreviated.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbAbbreviated_KeyDown);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbName.Location = new System.Drawing.Point(646, 106);
            this.txbName.Name = "txbName";
            this.txbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbName.Size = new System.Drawing.Size(420, 50);
            this.txbName.TabIndex = 55;
            this.txbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbName_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage3.Controls.Add(this.txbEditByName);
            this.tabPage3.Controls.Add(this.btnSelectMode);
            this.tabPage3.Controls.Add(this.btnPatientSelection);
            this.tabPage3.Controls.Add(this.txbEditTariffWithoutInsurances);
            this.tabPage3.Controls.Add(this.txbEditNationalCode);
            this.tabPage3.Controls.Add(this.txbEditUnit);
            this.tabPage3.Controls.Add(this.txbEditTariffWithInsurances);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.txbEditAbbreviated);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnSaveChanges);
            this.tabPage3.Controls.Add(this.cmbExperimentSelection);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Font = new System.Drawing.Font("A Chamran", 8F);
            this.tabPage3.Location = new System.Drawing.Point(10, 58);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1140, 790);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "تغییر آزمایش";
            // 
            // txbEditByName
            // 
            this.txbEditByName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditByName.Location = new System.Drawing.Point(646, 105);
            this.txbEditByName.Name = "txbEditByName";
            this.txbEditByName.ReadOnly = true;
            this.txbEditByName.Size = new System.Drawing.Size(420, 50);
            this.txbEditByName.TabIndex = 133;
            this.txbEditByName.TabStop = false;
            // 
            // btnSelectMode
            // 
            this.btnSelectMode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectMode.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelectMode.Location = new System.Drawing.Point(61, 354);
            this.btnSelectMode.Name = "btnSelectMode";
            this.btnSelectMode.Size = new System.Drawing.Size(198, 149);
            this.btnSelectMode.TabIndex = 131;
            this.btnSelectMode.Text = "انتخاب آزمایش";
            this.btnSelectMode.UseVisualStyleBackColor = false;
            this.btnSelectMode.Click += new System.EventHandler(this.btnSelectMode_Click);
            // 
            // btnPatientSelection
            // 
            this.btnPatientSelection.BackColor = System.Drawing.Color.Azure;
            this.btnPatientSelection.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold);
            this.btnPatientSelection.Location = new System.Drawing.Point(234, 99);
            this.btnPatientSelection.Name = "btnPatientSelection";
            this.btnPatientSelection.Size = new System.Drawing.Size(105, 57);
            this.btnPatientSelection.TabIndex = 130;
            this.btnPatientSelection.Text = "انتخاب";
            this.btnPatientSelection.UseVisualStyleBackColor = false;
            this.btnPatientSelection.Click += new System.EventHandler(this.btnPatientSelection_Click);
            // 
            // txbEditTariffWithoutInsurances
            // 
            this.txbEditTariffWithoutInsurances.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditTariffWithoutInsurances.Location = new System.Drawing.Point(61, 250);
            this.txbEditTariffWithoutInsurances.Name = "txbEditTariffWithoutInsurances";
            this.txbEditTariffWithoutInsurances.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbEditTariffWithoutInsurances.Size = new System.Drawing.Size(420, 50);
            this.txbEditTariffWithoutInsurances.TabIndex = 129;
            this.txbEditTariffWithoutInsurances.TextChanged += new System.EventHandler(this.txbEditTariffWithoutInsurances_TextChanged);
            this.txbEditTariffWithoutInsurances.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditTariffWithoutInsurances_KeyDown);
            // 
            // txbEditNationalCode
            // 
            this.txbEditNationalCode.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditNationalCode.Location = new System.Drawing.Point(646, 396);
            this.txbEditNationalCode.Name = "txbEditNationalCode";
            this.txbEditNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbEditNationalCode.Size = new System.Drawing.Size(420, 50);
            this.txbEditNationalCode.TabIndex = 127;
            this.txbEditNationalCode.TextChanged += new System.EventHandler(this.txbEditNationalCode_TextChanged);
            this.txbEditNationalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditNationalCode_KeyDown);
            // 
            // txbEditUnit
            // 
            this.txbEditUnit.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditUnit.Location = new System.Drawing.Point(646, 541);
            this.txbEditUnit.Name = "txbEditUnit";
            this.txbEditUnit.Size = new System.Drawing.Size(420, 50);
            this.txbEditUnit.TabIndex = 126;
            this.txbEditUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditUnit_KeyDown);
            // 
            // txbEditTariffWithInsurances
            // 
            this.txbEditTariffWithInsurances.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditTariffWithInsurances.Location = new System.Drawing.Point(61, 106);
            this.txbEditTariffWithInsurances.Name = "txbEditTariffWithInsurances";
            this.txbEditTariffWithInsurances.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbEditTariffWithInsurances.Size = new System.Drawing.Size(420, 50);
            this.txbEditTariffWithInsurances.TabIndex = 121;
            this.txbEditTariffWithInsurances.TextChanged += new System.EventHandler(this.txbEditTariffWithInsurances_TextChanged);
            this.txbEditTariffWithInsurances.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditTariffWithInsurances_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(322, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 41);
            this.label14.TabIndex = 119;
            this.label14.Text = "تعرفه بدون بیمه";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(357, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 41);
            this.label15.TabIndex = 118;
            this.label15.Text = "تعرفه با بیمه";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(899, 500);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(167, 41);
            this.label21.TabIndex = 112;
            this.label21.Text = "واحد اندازه گیری";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(990, 354);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 41);
            this.label23.TabIndex = 110;
            this.label23.Text = "کد ملی";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(946, 208);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(128, 41);
            this.label24.TabIndex = 109;
            this.label24.Text = "نام اختصاری";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label25.Location = new System.Drawing.Point(953, 64);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(119, 41);
            this.label25.TabIndex = 108;
            this.label25.Text = "نام آزمایش";
            // 
            // txbEditAbbreviated
            // 
            this.txbEditAbbreviated.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditAbbreviated.Location = new System.Drawing.Point(646, 250);
            this.txbEditAbbreviated.Name = "txbEditAbbreviated";
            this.txbEditAbbreviated.Size = new System.Drawing.Size(420, 50);
            this.txbEditAbbreviated.TabIndex = 107;
            this.txbEditAbbreviated.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditAbbreviated_KeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(646, 641);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(425, 68);
            this.btnDelete.TabIndex = 105;
            this.btnDelete.Text = "حذف این آزمایش";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveChanges.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.Location = new System.Drawing.Point(61, 560);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(421, 150);
            this.btnSaveChanges.TabIndex = 104;
            this.btnSaveChanges.Text = "ذخیره تغییرات";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cmbExperimentSelection
            // 
            this.cmbExperimentSelection.Font = new System.Drawing.Font("B Nazanin", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbExperimentSelection.FormattingEnabled = true;
            this.cmbExperimentSelection.Location = new System.Drawing.Point(387, 105);
            this.cmbExperimentSelection.Name = "cmbExperimentSelection";
            this.cmbExperimentSelection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbExperimentSelection.Size = new System.Drawing.Size(420, 48);
            this.cmbExperimentSelection.TabIndex = 1;
            this.cmbExperimentSelection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbExperimentSelection_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("A Chamran", 8F);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(650, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 41);
            this.label13.TabIndex = 0;
            this.label13.Text = "انتخاب آزمایش";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage1.Controls.Add(this.lblSelect);
            this.tabPage1.Controls.Add(this.btnSelection);
            this.tabPage1.Controls.Add(this.cmbSearch);
            this.tabPage1.Controls.Add(this.dgvExperiments);
            this.tabPage1.Location = new System.Drawing.Point(10, 58);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1140, 790);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "مشاهده آزمایش ها";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("A Chamran", 8F);
            this.lblSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelect.Location = new System.Drawing.Point(931, 637);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(156, 41);
            this.lblSelect.TabIndex = 131;
            this.lblSelect.Text = "انتخاب آزمایش";
            // 
            // btnSelection
            // 
            this.btnSelection.BackColor = System.Drawing.Color.Azure;
            this.btnSelection.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold);
            this.btnSelection.Location = new System.Drawing.Point(473, 673);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(105, 57);
            this.btnSelection.TabIndex = 130;
            this.btnSelection.Text = "انتخاب";
            this.btnSelection.UseVisualStyleBackColor = false;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(626, 679);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearch.Size = new System.Drawing.Size(462, 51);
            this.cmbSearch.TabIndex = 32;
            this.cmbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSearch_KeyDown);
            // 
            // dgvExperiments
            // 
            this.dgvExperiments.AllowUserToAddRows = false;
            this.dgvExperiments.AllowUserToDeleteRows = false;
            this.dgvExperiments.AllowUserToOrderColumns = true;
            this.dgvExperiments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExperiments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExperiments.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExperiments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvExperiments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExperiments.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvExperiments.Location = new System.Drawing.Point(0, 1);
            this.dgvExperiments.MultiSelect = false;
            this.dgvExperiments.Name = "dgvExperiments";
            this.dgvExperiments.ReadOnly = true;
            this.dgvExperiments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExperiments.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvExperiments.RowHeadersWidth = 92;
            this.dgvExperiments.RowTemplate.Height = 37;
            this.dgvExperiments.Size = new System.Drawing.Size(1134, 604);
            this.dgvExperiments.TabIndex = 31;
            this.dgvExperiments.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.AliceBlue;
            this.label26.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 10F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(402, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(371, 51);
            this.label26.TabIndex = 130;
            this.label26.Text = "تعریف آزمایش ها و تعرفه ها";
            this.label26.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label26_MouseDown);
            // 
            // frmExperiments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1161, 962);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExperiments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmExperiments_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperiments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbNationalCode;
        private System.Windows.Forms.TextBox txbUnit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAbbreviated;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbExperimentSelection;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txbEditNationalCode;
        private System.Windows.Forms.TextBox txbEditUnit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txbEditAbbreviated;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvExperiments;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnPatientSelection;
        private System.Windows.Forms.Button btnSelectMode;
        private System.Windows.Forms.TextBox txbEditByName;
        private System.Windows.Forms.TextBox txbEditTariffWithoutInsurances;
        private System.Windows.Forms.TextBox txbEditTariffWithInsurances;
        private System.Windows.Forms.TextBox txbTariffWithoutInsurances;
        private System.Windows.Forms.TextBox txbTariffWithInsurances;
    }
}