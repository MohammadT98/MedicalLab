namespace MedicalLab
{
    partial class frmPatientInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientInformation));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSelectMode = new System.Windows.Forms.Button();
            this.btnPatientSelection = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbPatientSelection = new System.Windows.Forms.ComboBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txbEditAddress = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbEditSex = new System.Windows.Forms.ComboBox();
            this.cmbEditInsurance = new System.Windows.Forms.ComboBox();
            this.txbEditName = new System.Windows.Forms.TextBox();
            this.txbEditLastName = new System.Windows.Forms.TextBox();
            this.txbEditFatherName = new System.Windows.Forms.TextBox();
            this.txbEditNationalCode = new System.Windows.Forms.TextBox();
            this.txbEditPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvTemp = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.cmbInsurance = new System.Windows.Forms.ComboBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbFatherName = new System.Windows.Forms.TextBox();
            this.txbNationalCode = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1543, 91);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(23, 20);
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
            this.btnClean.BackColor = System.Drawing.Color.Azure;
            this.btnClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClean.BackgroundImage")));
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClean.Location = new System.Drawing.Point(1450, 9);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(85, 76);
            this.btnClean.TabIndex = 29;
            this.btnClean.TabStop = false;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(664, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 71);
            this.label3.TabIndex = 84;
            this.label3.Text = "اطلاعات بیمار";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.btnSelectMode);
            this.tabPage2.Controls.Add(this.btnPatientSelection);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.cmbPatientSelection);
            this.tabPage2.Controls.Add(this.btnSaveChanges);
            this.tabPage2.Controls.Add(this.txbEditAddress);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.cmbEditSex);
            this.tabPage2.Controls.Add(this.cmbEditInsurance);
            this.tabPage2.Controls.Add(this.txbEditName);
            this.tabPage2.Controls.Add(this.txbEditLastName);
            this.tabPage2.Controls.Add(this.txbEditFatherName);
            this.tabPage2.Controls.Add(this.txbEditNationalCode);
            this.tabPage2.Controls.Add(this.txbEditPhone);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.dgvTemp);
            this.tabPage2.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabPage2.Location = new System.Drawing.Point(10, 58);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1523, 786);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "تغییر اطلاعات بیمار";
            // 
            // btnSelectMode
            // 
            this.btnSelectMode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectMode.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelectMode.Location = new System.Drawing.Point(1299, 588);
            this.btnSelectMode.Name = "btnSelectMode";
            this.btnSelectMode.Size = new System.Drawing.Size(177, 142);
            this.btnSelectMode.TabIndex = 130;
            this.btnSelectMode.Text = "انتخاب بیمار";
            this.btnSelectMode.UseVisualStyleBackColor = false;
            this.btnSelectMode.Click += new System.EventHandler(this.btnSelectMode_Click);
            // 
            // btnPatientSelection
            // 
            this.btnPatientSelection.BackColor = System.Drawing.Color.Azure;
            this.btnPatientSelection.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold);
            this.btnPatientSelection.Location = new System.Drawing.Point(512, 76);
            this.btnPatientSelection.Name = "btnPatientSelection";
            this.btnPatientSelection.Size = new System.Drawing.Size(105, 57);
            this.btnPatientSelection.TabIndex = 128;
            this.btnPatientSelection.Text = "انتخاب";
            this.btnPatientSelection.UseVisualStyleBackColor = false;
            this.btnPatientSelection.Click += new System.EventHandler(this.btnPatientSelection_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(880, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 42);
            this.label20.TabIndex = 127;
            this.label20.Text = "انتخاب بیمار";
            // 
            // cmbPatientSelection
            // 
            this.cmbPatientSelection.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbPatientSelection.FormattingEnabled = true;
            this.cmbPatientSelection.Items.AddRange(new object[] {
            "خانم",
            "آقا"});
            this.cmbPatientSelection.Location = new System.Drawing.Point(636, 81);
            this.cmbPatientSelection.Name = "cmbPatientSelection";
            this.cmbPatientSelection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPatientSelection.Size = new System.Drawing.Size(373, 51);
            this.cmbPatientSelection.TabIndex = 126;
            this.cmbPatientSelection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPatientSelection_KeyDown);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveChanges.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.Location = new System.Drawing.Point(629, 588);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(265, 142);
            this.btnSaveChanges.TabIndex = 125;
            this.btnSaveChanges.Text = "ذخیره تغییرات";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txbEditAddress
            // 
            this.txbEditAddress.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditAddress.Location = new System.Drawing.Point(43, 386);
            this.txbEditAddress.Multiline = true;
            this.txbEditAddress.Name = "txbEditAddress";
            this.txbEditAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbEditAddress.Size = new System.Drawing.Size(851, 171);
            this.txbEditAddress.TabIndex = 124;
            this.txbEditAddress.TextChanged += new System.EventHandler(this.txbEditAddress_TextChanged);
            this.txbEditAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditAddress_KeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(43, 588);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(265, 142);
            this.btnDelete.TabIndex = 123;
            this.btnDelete.Text = "حذف بیمار";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbEditSex
            // 
            this.cmbEditSex.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbEditSex.FormattingEnabled = true;
            this.cmbEditSex.Items.AddRange(new object[] {
            "خانم",
            "آقا"});
            this.cmbEditSex.Location = new System.Drawing.Point(756, 80);
            this.cmbEditSex.Name = "cmbEditSex";
            this.cmbEditSex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbEditSex.Size = new System.Drawing.Size(138, 51);
            this.cmbEditSex.TabIndex = 122;
            this.cmbEditSex.TextChanged += new System.EventHandler(this.cmbEditSex_TextChanged);
            this.cmbEditSex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEditSex_KeyDown);
            // 
            // cmbEditInsurance
            // 
            this.cmbEditInsurance.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbEditInsurance.FormattingEnabled = true;
            this.cmbEditInsurance.Location = new System.Drawing.Point(605, 181);
            this.cmbEditInsurance.Name = "cmbEditInsurance";
            this.cmbEditInsurance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbEditInsurance.Size = new System.Drawing.Size(289, 51);
            this.cmbEditInsurance.TabIndex = 121;
            this.cmbEditInsurance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEditInsurance_KeyDown);
            // 
            // txbEditName
            // 
            this.txbEditName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditName.Location = new System.Drawing.Point(1107, 181);
            this.txbEditName.Name = "txbEditName";
            this.txbEditName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbEditName.Size = new System.Drawing.Size(369, 50);
            this.txbEditName.TabIndex = 120;
            this.txbEditName.TextChanged += new System.EventHandler(this.txbEditName_TextChanged);
            this.txbEditName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditName_KeyDown);
            // 
            // txbEditLastName
            // 
            this.txbEditLastName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditLastName.Location = new System.Drawing.Point(1107, 283);
            this.txbEditLastName.Name = "txbEditLastName";
            this.txbEditLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbEditLastName.Size = new System.Drawing.Size(369, 50);
            this.txbEditLastName.TabIndex = 119;
            this.txbEditLastName.TextChanged += new System.EventHandler(this.txbEditLastName_TextChanged);
            this.txbEditLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditLastName_KeyDown);
            // 
            // txbEditFatherName
            // 
            this.txbEditFatherName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditFatherName.Location = new System.Drawing.Point(1107, 386);
            this.txbEditFatherName.Name = "txbEditFatherName";
            this.txbEditFatherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbEditFatherName.Size = new System.Drawing.Size(369, 50);
            this.txbEditFatherName.TabIndex = 118;
            this.txbEditFatherName.TextChanged += new System.EventHandler(this.txbEditFatherName_TextChanged);
            this.txbEditFatherName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditFatherName_KeyDown);
            // 
            // txbEditNationalCode
            // 
            this.txbEditNationalCode.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditNationalCode.Location = new System.Drawing.Point(1107, 80);
            this.txbEditNationalCode.Name = "txbEditNationalCode";
            this.txbEditNationalCode.ReadOnly = true;
            this.txbEditNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbEditNationalCode.Size = new System.Drawing.Size(369, 50);
            this.txbEditNationalCode.TabIndex = 117;
            this.txbEditNationalCode.TabStop = false;
            this.txbEditNationalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditNationalCode_KeyDown);
            // 
            // txbEditPhone
            // 
            this.txbEditPhone.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditPhone.Location = new System.Drawing.Point(605, 280);
            this.txbEditPhone.Name = "txbEditPhone";
            this.txbEditPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbEditPhone.Size = new System.Drawing.Size(289, 50);
            this.txbEditPhone.TabIndex = 116;
            this.txbEditPhone.TextChanged += new System.EventHandler(this.txbEditPhone_TextChanged);
            this.txbEditPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditPhone_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1352, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 42);
            this.label1.TabIndex = 111;
            this.label1.Text = "شماره ملی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(827, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 42);
            this.label2.TabIndex = 109;
            this.label2.Text = "تلفن";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(1425, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 42);
            this.label13.TabIndex = 113;
            this.label13.Text = "نام";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(795, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 42);
            this.label14.TabIndex = 108;
            this.label14.Text = "جنسیت";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(839, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 42);
            this.label15.TabIndex = 107;
            this.label15.Text = "بیمه";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(1386, 340);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 42);
            this.label16.TabIndex = 112;
            this.label16.Text = "نام پدر";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(1335, 239);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 42);
            this.label18.TabIndex = 110;
            this.label18.Text = "نام خانوادگی";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(815, 334);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 42);
            this.label19.TabIndex = 105;
            this.label19.Text = "آدرس";
            // 
            // dgvTemp
            // 
            this.dgvTemp.AllowUserToAddRows = false;
            this.dgvTemp.AllowUserToDeleteRows = false;
            this.dgvTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemp.Location = new System.Drawing.Point(19, 18);
            this.dgvTemp.Name = "dgvTemp";
            this.dgvTemp.RowHeadersWidth = 92;
            this.dgvTemp.RowTemplate.Height = 37;
            this.dgvTemp.Size = new System.Drawing.Size(222, 747);
            this.dgvTemp.TabIndex = 129;
            this.dgvTemp.TabStop = false;
            this.dgvTemp.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.cmbSex);
            this.tabPage1.Controls.Add(this.cmbInsurance);
            this.tabPage1.Controls.Add(this.txbName);
            this.tabPage1.Controls.Add(this.txbLastName);
            this.tabPage1.Controls.Add(this.txbFatherName);
            this.tabPage1.Controls.Add(this.txbNationalCode);
            this.tabPage1.Controls.Add(this.txbPhone);
            this.tabPage1.Controls.Add(this.txbAddress);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabPage1.Location = new System.Drawing.Point(10, 58);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1523, 786);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "بیمار جدید";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(631, 572);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(265, 142);
            this.btnSave.TabIndex = 104;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbSex
            // 
            this.cmbSex.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "خانم",
            "آقا"});
            this.cmbSex.Location = new System.Drawing.Point(758, 80);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSex.Size = new System.Drawing.Size(138, 51);
            this.cmbSex.TabIndex = 103;
            this.cmbSex.TextChanged += new System.EventHandler(this.cmbSex_TextChanged);
            this.cmbSex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSex_KeyDown);
            // 
            // cmbInsurance
            // 
            this.cmbInsurance.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbInsurance.FormattingEnabled = true;
            this.cmbInsurance.Location = new System.Drawing.Point(607, 181);
            this.cmbInsurance.Name = "cmbInsurance";
            this.cmbInsurance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbInsurance.Size = new System.Drawing.Size(289, 51);
            this.cmbInsurance.TabIndex = 102;
            this.cmbInsurance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbInsurance_KeyDown);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbName.Location = new System.Drawing.Point(1107, 183);
            this.txbName.Name = "txbName";
            this.txbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbName.Size = new System.Drawing.Size(369, 50);
            this.txbName.TabIndex = 101;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            this.txbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbName_KeyDown);
            // 
            // txbLastName
            // 
            this.txbLastName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbLastName.Location = new System.Drawing.Point(1107, 283);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbLastName.Size = new System.Drawing.Size(369, 50);
            this.txbLastName.TabIndex = 100;
            this.txbLastName.TextChanged += new System.EventHandler(this.txbLastName_TextChanged);
            this.txbLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbLastName_KeyDown);
            // 
            // txbFatherName
            // 
            this.txbFatherName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbFatherName.Location = new System.Drawing.Point(1107, 386);
            this.txbFatherName.Name = "txbFatherName";
            this.txbFatherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbFatherName.Size = new System.Drawing.Size(369, 50);
            this.txbFatherName.TabIndex = 99;
            this.txbFatherName.TextChanged += new System.EventHandler(this.txbFatherName_TextChanged);
            this.txbFatherName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbFatherName_KeyDown);
            // 
            // txbNationalCode
            // 
            this.txbNationalCode.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbNationalCode.Location = new System.Drawing.Point(1107, 80);
            this.txbNationalCode.Name = "txbNationalCode";
            this.txbNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbNationalCode.Size = new System.Drawing.Size(369, 50);
            this.txbNationalCode.TabIndex = 98;
            this.txbNationalCode.TextChanged += new System.EventHandler(this.txbNationalCode_TextChanged);
            this.txbNationalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNationalCode_KeyDown);
            // 
            // txbPhone
            // 
            this.txbPhone.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbPhone.Location = new System.Drawing.Point(607, 283);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbPhone.Size = new System.Drawing.Size(289, 50);
            this.txbPhone.TabIndex = 97;
            this.txbPhone.TextChanged += new System.EventHandler(this.txbPhone_TextChanged);
            this.txbPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPhone_KeyDown);
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbAddress.Location = new System.Drawing.Point(43, 386);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbAddress.Size = new System.Drawing.Size(853, 158);
            this.txbAddress.TabIndex = 95;
            this.txbAddress.TextChanged += new System.EventHandler(this.txbAddress_TextChanged);
            this.txbAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbAddress_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(1352, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 42);
            this.label10.TabIndex = 92;
            this.label10.Text = "شماره ملی";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(829, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 42);
            this.label8.TabIndex = 90;
            this.label8.Text = "تلفن";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(1425, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 42);
            this.label12.TabIndex = 94;
            this.label12.Text = "نام";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(797, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 42);
            this.label7.TabIndex = 89;
            this.label7.Text = "جنسیت";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(841, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 42);
            this.label6.TabIndex = 88;
            this.label6.Text = "بیمه";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(1386, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 42);
            this.label11.TabIndex = 93;
            this.label11.Text = "نام پدر";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(1335, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 42);
            this.label9.TabIndex = 91;
            this.label9.Text = "نام خانوادگی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(817, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 42);
            this.label4.TabIndex = 86;
            this.label4.Text = "آدرس";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(2, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1543, 854);
            this.tabControl1.TabIndex = 86;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabcontrol_SelectedIndexChanged);
            // 
            // frmPatientInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1545, 952);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPatientInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Activated += new System.EventHandler(this.frmPatientInformation_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txbEditAddress;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbEditSex;
        private System.Windows.Forms.ComboBox cmbEditInsurance;
        private System.Windows.Forms.TextBox txbEditName;
        private System.Windows.Forms.TextBox txbEditLastName;
        private System.Windows.Forms.TextBox txbEditFatherName;
        private System.Windows.Forms.TextBox txbEditNationalCode;
        private System.Windows.Forms.TextBox txbEditPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.ComboBox cmbInsurance;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbFatherName;
        private System.Windows.Forms.TextBox txbNationalCode;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnPatientSelection;
        private System.Windows.Forms.DataGridView dgvTemp;
        private System.Windows.Forms.Button btnSelectMode;
        private System.Windows.Forms.ComboBox cmbPatientSelection;
    }
}