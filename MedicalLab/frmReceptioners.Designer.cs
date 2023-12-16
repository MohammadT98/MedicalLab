namespace MedicalLab
{
    partial class frmReceptioners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceptioners));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbFatherName = new System.Windows.Forms.TextBox();
            this.txbNationalCode = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSelectMode = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPatientSelection = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbPatientSelection = new System.Windows.Forms.ComboBox();
            this.txbEditLastName = new System.Windows.Forms.TextBox();
            this.txbEditFatherName = new System.Windows.Forms.TextBox();
            this.txbEditNationalCode = new System.Windows.Forms.TextBox();
            this.txbEditPhone = new System.Windows.Forms.TextBox();
            this.txbEditAddress = new System.Windows.Forms.TextBox();
            this.txbEditName = new System.Windows.Forms.TextBox();
            this.lblEditName = new System.Windows.Forms.Label();
            this.lblEditAddress = new System.Windows.Forms.Label();
            this.lblEditLastName = new System.Windows.Forms.Label();
            this.lblEditPhone = new System.Windows.Forms.Label();
            this.lblEditFatherName = new System.Windows.Forms.Label();
            this.lblEditNC = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnSelection = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.dgvReceptioners = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptioners)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(945, 91);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(21, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 52);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "❌";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.AliceBlue;
            this.btnClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClean.BackgroundImage")));
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClean.Location = new System.Drawing.Point(847, 5);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(85, 76);
            this.btnClean.TabIndex = 29;
            this.btnClean.TabStop = false;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(785, 152);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(46, 42);
            this.label1.TabIndex = 30;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(697, 277);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(135, 42);
            this.label2.TabIndex = 31;
            this.label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(251, 31);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(84, 42);
            this.label3.TabIndex = 32;
            this.label3.Text = "نام پدر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(714, 29);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(119, 42);
            this.label4.TabIndex = 33;
            this.label4.Text = "شماره ملی";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(275, 154);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(63, 42);
            this.label5.TabIndex = 34;
            this.label5.Text = "تلفن";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(759, 400);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(73, 42);
            this.label6.TabIndex = 35;
            this.label6.Text = "آدرس";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(14, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 897);
            this.tabControl1.TabIndex = 36;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txbLastName);
            this.tabPage1.Controls.Add(this.txbFatherName);
            this.tabPage1.Controls.Add(this.txbNationalCode);
            this.tabPage1.Controls.Add(this.txbPhone);
            this.tabPage1.Controls.Add(this.txbAddress);
            this.tabPage1.Controls.Add(this.txbName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(10, 58);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(909, 829);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "پذیرش کننده جدید";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(328, 636);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(255, 151);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbLastName
            // 
            this.txbLastName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbLastName.Location = new System.Drawing.Point(585, 321);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(241, 50);
            this.txbLastName.TabIndex = 42;
            this.txbLastName.TextChanged += new System.EventHandler(this.txbLastName_TextChanged);
            this.txbLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbLastName_KeyDown);
            // 
            // txbFatherName
            // 
            this.txbFatherName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbFatherName.Location = new System.Drawing.Point(89, 75);
            this.txbFatherName.Name = "txbFatherName";
            this.txbFatherName.Size = new System.Drawing.Size(241, 50);
            this.txbFatherName.TabIndex = 41;
            this.txbFatherName.TextChanged += new System.EventHandler(this.txbFatherName_TextChanged);
            this.txbFatherName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbFatherName_KeyDown);
            // 
            // txbNationalCode
            // 
            this.txbNationalCode.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbNationalCode.Location = new System.Drawing.Point(587, 75);
            this.txbNationalCode.Name = "txbNationalCode";
            this.txbNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbNationalCode.Size = new System.Drawing.Size(241, 50);
            this.txbNationalCode.TabIndex = 40;
            this.txbNationalCode.TextChanged += new System.EventHandler(this.txbNationalCode_TextChanged);
            this.txbNationalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNationalCode_KeyDown);
            // 
            // txbPhone
            // 
            this.txbPhone.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbPhone.Location = new System.Drawing.Point(91, 198);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbPhone.Size = new System.Drawing.Size(241, 50);
            this.txbPhone.TabIndex = 39;
            this.txbPhone.TextChanged += new System.EventHandler(this.txbPhone_TextChanged);
            this.txbPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPhone_KeyDown);
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbAddress.Location = new System.Drawing.Point(91, 444);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(734, 153);
            this.txbAddress.TabIndex = 38;
            this.txbAddress.TextChanged += new System.EventHandler(this.txbAddress_TextChanged);
            this.txbAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbAddress_KeyDown);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbName.Location = new System.Drawing.Point(585, 198);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(241, 50);
            this.txbName.TabIndex = 36;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            this.txbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbName_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.btnSelectMode);
            this.tabPage2.Controls.Add(this.btnSaveChanges);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnPatientSelection);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.cmbPatientSelection);
            this.tabPage2.Controls.Add(this.txbEditLastName);
            this.tabPage2.Controls.Add(this.txbEditFatherName);
            this.tabPage2.Controls.Add(this.txbEditNationalCode);
            this.tabPage2.Controls.Add(this.txbEditPhone);
            this.tabPage2.Controls.Add(this.txbEditAddress);
            this.tabPage2.Controls.Add(this.txbEditName);
            this.tabPage2.Controls.Add(this.lblEditName);
            this.tabPage2.Controls.Add(this.lblEditAddress);
            this.tabPage2.Controls.Add(this.lblEditLastName);
            this.tabPage2.Controls.Add(this.lblEditPhone);
            this.tabPage2.Controls.Add(this.lblEditFatherName);
            this.tabPage2.Controls.Add(this.lblEditNC);
            this.tabPage2.Location = new System.Drawing.Point(10, 58);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(909, 829);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "تغییر پذیرش کنندگان";
            // 
            // btnSelectMode
            // 
            this.btnSelectMode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectMode.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelectMode.Location = new System.Drawing.Point(631, 640);
            this.btnSelectMode.Name = "btnSelectMode";
            this.btnSelectMode.Size = new System.Drawing.Size(198, 142);
            this.btnSelectMode.TabIndex = 134;
            this.btnSelectMode.Text = "انتخاب پذیرش کننده";
            this.btnSelectMode.UseVisualStyleBackColor = false;
            this.btnSelectMode.Click += new System.EventHandler(this.btnSelectMode_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveChanges.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.Location = new System.Drawing.Point(329, 640);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(265, 142);
            this.btnSaveChanges.TabIndex = 133;
            this.btnSaveChanges.Text = "ذخیره تغییرات";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(91, 640);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(203, 142);
            this.btnDelete.TabIndex = 132;
            this.btnDelete.Text = "حذف ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPatientSelection
            // 
            this.btnPatientSelection.BackColor = System.Drawing.Color.Azure;
            this.btnPatientSelection.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold);
            this.btnPatientSelection.Location = new System.Drawing.Point(190, 68);
            this.btnPatientSelection.Name = "btnPatientSelection";
            this.btnPatientSelection.Size = new System.Drawing.Size(105, 57);
            this.btnPatientSelection.TabIndex = 131;
            this.btnPatientSelection.Text = "انتخاب";
            this.btnPatientSelection.UseVisualStyleBackColor = false;
            this.btnPatientSelection.Click += new System.EventHandler(this.btnPatientSelection_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(489, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(214, 42);
            this.label20.TabIndex = 130;
            this.label20.Text = "انتخاب پذیرش کننده";
            // 
            // cmbPatientSelection
            // 
            this.cmbPatientSelection.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbPatientSelection.FormattingEnabled = true;
            this.cmbPatientSelection.Items.AddRange(new object[] {
            "خانم",
            "آقا"});
            this.cmbPatientSelection.Location = new System.Drawing.Point(329, 75);
            this.cmbPatientSelection.Name = "cmbPatientSelection";
            this.cmbPatientSelection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPatientSelection.Size = new System.Drawing.Size(373, 51);
            this.cmbPatientSelection.TabIndex = 129;
            this.cmbPatientSelection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPatientSelection_KeyDown);
            // 
            // txbEditLastName
            // 
            this.txbEditLastName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditLastName.Location = new System.Drawing.Point(587, 321);
            this.txbEditLastName.Name = "txbEditLastName";
            this.txbEditLastName.Size = new System.Drawing.Size(241, 50);
            this.txbEditLastName.TabIndex = 55;
            this.txbEditLastName.TextChanged += new System.EventHandler(this.txbEditLastName_TextChanged);
            this.txbEditLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditLastName_KeyDown);
            // 
            // txbEditFatherName
            // 
            this.txbEditFatherName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditFatherName.Location = new System.Drawing.Point(91, 76);
            this.txbEditFatherName.Name = "txbEditFatherName";
            this.txbEditFatherName.Size = new System.Drawing.Size(241, 50);
            this.txbEditFatherName.TabIndex = 54;
            this.txbEditFatherName.TextChanged += new System.EventHandler(this.txbEditFatherName_TextChanged);
            this.txbEditFatherName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditFatherName_KeyDown);
            // 
            // txbEditNationalCode
            // 
            this.txbEditNationalCode.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditNationalCode.Location = new System.Drawing.Point(585, 76);
            this.txbEditNationalCode.Name = "txbEditNationalCode";
            this.txbEditNationalCode.ReadOnly = true;
            this.txbEditNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbEditNationalCode.Size = new System.Drawing.Size(241, 50);
            this.txbEditNationalCode.TabIndex = 53;
            this.txbEditNationalCode.TabStop = false;
            this.txbEditNationalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditNationalCode_KeyDown);
            // 
            // txbEditPhone
            // 
            this.txbEditPhone.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditPhone.Location = new System.Drawing.Point(91, 198);
            this.txbEditPhone.Name = "txbEditPhone";
            this.txbEditPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbEditPhone.Size = new System.Drawing.Size(241, 50);
            this.txbEditPhone.TabIndex = 52;
            this.txbEditPhone.TextChanged += new System.EventHandler(this.txbEditPhone_TextChanged);
            this.txbEditPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditPhone_KeyDown);
            // 
            // txbEditAddress
            // 
            this.txbEditAddress.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditAddress.Location = new System.Drawing.Point(91, 444);
            this.txbEditAddress.Multiline = true;
            this.txbEditAddress.Name = "txbEditAddress";
            this.txbEditAddress.Size = new System.Drawing.Size(734, 153);
            this.txbEditAddress.TabIndex = 51;
            this.txbEditAddress.TextChanged += new System.EventHandler(this.txbEditAddress_TextChanged);
            this.txbEditAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditAddress_KeyDown);
            // 
            // txbEditName
            // 
            this.txbEditName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditName.Location = new System.Drawing.Point(585, 198);
            this.txbEditName.Name = "txbEditName";
            this.txbEditName.Size = new System.Drawing.Size(241, 50);
            this.txbEditName.TabIndex = 50;
            this.txbEditName.TextChanged += new System.EventHandler(this.txbEditName_TextChanged);
            this.txbEditName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditName_KeyDown);
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.lblEditName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditName.Location = new System.Drawing.Point(785, 152);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEditName.Size = new System.Drawing.Size(46, 42);
            this.lblEditName.TabIndex = 44;
            this.lblEditName.Text = "نام";
            // 
            // lblEditAddress
            // 
            this.lblEditAddress.AutoSize = true;
            this.lblEditAddress.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.lblEditAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditAddress.Location = new System.Drawing.Point(759, 400);
            this.lblEditAddress.Name = "lblEditAddress";
            this.lblEditAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEditAddress.Size = new System.Drawing.Size(73, 42);
            this.lblEditAddress.TabIndex = 49;
            this.lblEditAddress.Text = "آدرس";
            // 
            // lblEditLastName
            // 
            this.lblEditLastName.AutoSize = true;
            this.lblEditLastName.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.lblEditLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditLastName.Location = new System.Drawing.Point(699, 277);
            this.lblEditLastName.Name = "lblEditLastName";
            this.lblEditLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEditLastName.Size = new System.Drawing.Size(135, 42);
            this.lblEditLastName.TabIndex = 45;
            this.lblEditLastName.Text = "نام خانوادگی";
            // 
            // lblEditPhone
            // 
            this.lblEditPhone.AutoSize = true;
            this.lblEditPhone.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.lblEditPhone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditPhone.Location = new System.Drawing.Point(275, 154);
            this.lblEditPhone.Name = "lblEditPhone";
            this.lblEditPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEditPhone.Size = new System.Drawing.Size(63, 42);
            this.lblEditPhone.TabIndex = 48;
            this.lblEditPhone.Text = "تلفن";
            // 
            // lblEditFatherName
            // 
            this.lblEditFatherName.AutoSize = true;
            this.lblEditFatherName.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.lblEditFatherName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditFatherName.Location = new System.Drawing.Point(254, 32);
            this.lblEditFatherName.Name = "lblEditFatherName";
            this.lblEditFatherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEditFatherName.Size = new System.Drawing.Size(84, 42);
            this.lblEditFatherName.TabIndex = 46;
            this.lblEditFatherName.Text = "نام پدر";
            // 
            // lblEditNC
            // 
            this.lblEditNC.AutoSize = true;
            this.lblEditNC.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.lblEditNC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditNC.Location = new System.Drawing.Point(712, 30);
            this.lblEditNC.Name = "lblEditNC";
            this.lblEditNC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEditNC.Size = new System.Drawing.Size(119, 42);
            this.lblEditNC.TabIndex = 47;
            this.lblEditNC.Text = "شماره ملی";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage3.Controls.Add(this.lblTotal);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.lblSelect);
            this.tabPage3.Controls.Add(this.btnSelection);
            this.tabPage3.Controls.Add(this.cmbSearch);
            this.tabPage3.Controls.Add(this.dgvReceptioners);
            this.tabPage3.Location = new System.Drawing.Point(10, 58);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(909, 829);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "مشاهده پذیرش کنندگان";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("B Nazanin", 8.1F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Location = new System.Drawing.Point(387, 713);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 44);
            this.lblTotal.TabIndex = 139;
            this.lblTotal.Text = "label";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(585, 713);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(263, 42);
            this.label21.TabIndex = 138;
            this.label21.Text = "تعداد کل پذیرش کنندگان";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("A Chamran", 8F);
            this.lblSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelect.Location = new System.Drawing.Point(648, 568);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(209, 41);
            this.lblSelect.TabIndex = 137;
            this.lblSelect.Text = "انتخاب پذیرش کننده";
            // 
            // btnSelection
            // 
            this.btnSelection.BackColor = System.Drawing.Color.Azure;
            this.btnSelection.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold);
            this.btnSelection.Location = new System.Drawing.Point(224, 605);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(105, 57);
            this.btnSelection.TabIndex = 136;
            this.btnSelection.Text = "انتخاب";
            this.btnSelection.UseVisualStyleBackColor = false;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("B Nazanin", 8F);
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(387, 609);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearch.Size = new System.Drawing.Size(462, 48);
            this.cmbSearch.TabIndex = 135;
            this.cmbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSearch_KeyDown);
            // 
            // dgvReceptioners
            // 
            this.dgvReceptioners.AllowUserToAddRows = false;
            this.dgvReceptioners.AllowUserToDeleteRows = false;
            this.dgvReceptioners.AllowUserToOrderColumns = true;
            this.dgvReceptioners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReceptioners.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReceptioners.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceptioners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvReceptioners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceptioners.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvReceptioners.Location = new System.Drawing.Point(0, 0);
            this.dgvReceptioners.MultiSelect = false;
            this.dgvReceptioners.Name = "dgvReceptioners";
            this.dgvReceptioners.ReadOnly = true;
            this.dgvReceptioners.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceptioners.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvReceptioners.RowHeadersWidth = 92;
            this.dgvReceptioners.RowTemplate.Height = 37;
            this.dgvReceptioners.Size = new System.Drawing.Size(906, 530);
            this.dgvReceptioners.TabIndex = 134;
            this.dgvReceptioners.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(304, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 71);
            this.label7.TabIndex = 48;
            this.label7.Text = "پذیرش کنندگان";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label7_MouseDown);
            // 
            // frmReceptioners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(949, 1007);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReceptioners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmReceptioners_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptioners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbFatherName;
        private System.Windows.Forms.TextBox txbNationalCode;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbEditLastName;
        private System.Windows.Forms.TextBox txbEditFatherName;
        private System.Windows.Forms.TextBox txbEditNationalCode;
        private System.Windows.Forms.TextBox txbEditPhone;
        private System.Windows.Forms.TextBox txbEditAddress;
        private System.Windows.Forms.TextBox txbEditName;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Label lblEditAddress;
        private System.Windows.Forms.Label lblEditLastName;
        private System.Windows.Forms.Label lblEditPhone;
        private System.Windows.Forms.Label lblEditFatherName;
        private System.Windows.Forms.Label lblEditNC;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.DataGridView dgvReceptioners;
        private System.Windows.Forms.Button btnPatientSelection;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbPatientSelection;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelectMode;
    }
}