namespace MedicalLab
{
    partial class frmDoctorsInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctorsInformation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbMedicalSystemID = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbSpecialty = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbNationalCode = new System.Windows.Forms.TextBox();
            this.txbFatherName = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txbDegree = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txbEditByNC = new System.Windows.Forms.TextBox();
            this.btnSelectMode = new System.Windows.Forms.Button();
            this.btnDoctorSelect = new System.Windows.Forms.Button();
            this.txbEditDegree = new System.Windows.Forms.TextBox();
            this.txbEditMedicalSystemID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txbEditAddress = new System.Windows.Forms.TextBox();
            this.txbEditSpecialty = new System.Windows.Forms.TextBox();
            this.txbEditPhone = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txbEditFatherName = new System.Windows.Forms.TextBox();
            this.txbEditName = new System.Windows.Forms.TextBox();
            this.txbEditLastName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cmbDoctorSelection = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSelection = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2361, 91);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(19, 25);
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
            this.btnClean.Location = new System.Drawing.Point(2266, 9);
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
            this.label1.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1262, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 41);
            this.label1.TabIndex = 30;
            this.label1.Text = "شناسه نظام پزشکی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1386, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 41);
            this.label2.TabIndex = 31;
            this.label2.Text = "آدرس";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(2165, 660);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 41);
            this.label3.TabIndex = 32;
            this.label3.Text = "تخصص";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1303, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 41);
            this.label4.TabIndex = 33;
            this.label4.Text = "مدرک تحصیلی";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1396, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 41);
            this.label5.TabIndex = 34;
            this.label5.Text = "تلفن";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(2163, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 41);
            this.label6.TabIndex = 35;
            this.label6.Text = "کد ملی";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(2163, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 41);
            this.label7.TabIndex = 36;
            this.label7.Text = "نام پدر";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(2112, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 41);
            this.label8.TabIndex = 37;
            this.label8.Text = "نام خانوادگی";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(2200, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 41);
            this.label9.TabIndex = 38;
            this.label9.Text = "نام";
            // 
            // txbMedicalSystemID
            // 
            this.txbMedicalSystemID.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbMedicalSystemID.Location = new System.Drawing.Point(1086, 81);
            this.txbMedicalSystemID.Name = "txbMedicalSystemID";
            this.txbMedicalSystemID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbMedicalSystemID.Size = new System.Drawing.Size(364, 50);
            this.txbMedicalSystemID.TabIndex = 5;
            this.txbMedicalSystemID.TextChanged += new System.EventHandler(this.txbMedicalSystemID_TextChanged);
            this.txbMedicalSystemID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMedicalSystemID_KeyDown);
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbAddress.Location = new System.Drawing.Point(67, 546);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbAddress.Size = new System.Drawing.Size(1382, 206);
            this.txbAddress.TabIndex = 8;
            this.txbAddress.TextChanged += new System.EventHandler(this.txbAddress_TextChanged);
            this.txbAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbAddress_KeyDown);
            // 
            // txbSpecialty
            // 
            this.txbSpecialty.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbSpecialty.Location = new System.Drawing.Point(1530, 701);
            this.txbSpecialty.Name = "txbSpecialty";
            this.txbSpecialty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbSpecialty.Size = new System.Drawing.Size(721, 50);
            this.txbSpecialty.TabIndex = 4;
            this.txbSpecialty.TextChanged += new System.EventHandler(this.txbSpecialty_TextChanged);
            this.txbSpecialty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSpecialty_KeyDown);
            // 
            // txbPhone
            // 
            this.txbPhone.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbPhone.Location = new System.Drawing.Point(1086, 391);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbPhone.Size = new System.Drawing.Size(364, 50);
            this.txbPhone.TabIndex = 7;
            this.txbPhone.TextChanged += new System.EventHandler(this.txbPhone_TextChanged);
            this.txbPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPhone_KeyDown);
            // 
            // txbNationalCode
            // 
            this.txbNationalCode.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbNationalCode.Location = new System.Drawing.Point(1950, 81);
            this.txbNationalCode.Name = "txbNationalCode";
            this.txbNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbNationalCode.Size = new System.Drawing.Size(293, 50);
            this.txbNationalCode.TabIndex = 3;
            this.txbNationalCode.TextChanged += new System.EventHandler(this.txbNationalCode_TextChanged);
            this.txbNationalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNationalCode_KeyDown);
            // 
            // txbFatherName
            // 
            this.txbFatherName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbFatherName.Location = new System.Drawing.Point(1950, 546);
            this.txbFatherName.Name = "txbFatherName";
            this.txbFatherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbFatherName.Size = new System.Drawing.Size(293, 50);
            this.txbFatherName.TabIndex = 2;
            this.txbFatherName.TextChanged += new System.EventHandler(this.txbFatherName_TextChanged);
            this.txbFatherName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbFatherName_KeyDown);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbName.Location = new System.Drawing.Point(1950, 236);
            this.txbName.Name = "txbName";
            this.txbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbName.Size = new System.Drawing.Size(293, 50);
            this.txbName.TabIndex = 0;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            this.txbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbName_KeyDown);
            // 
            // txbLastName
            // 
            this.txbLastName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbLastName.Location = new System.Drawing.Point(1950, 391);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbLastName.Size = new System.Drawing.Size(293, 50);
            this.txbLastName.TabIndex = 1;
            this.txbLastName.TextChanged += new System.EventHandler(this.txbLastName_TextChanged);
            this.txbLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbLastName_KeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(5, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2346, 1064);
            this.tabControl1.TabIndex = 48;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.txbDegree);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txbMedicalSystemID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txbAddress);
            this.tabPage1.Controls.Add(this.txbSpecialty);
            this.tabPage1.Controls.Add(this.txbPhone);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txbNationalCode);
            this.tabPage1.Controls.Add(this.txbFatherName);
            this.tabPage1.Controls.Add(this.txbName);
            this.tabPage1.Controls.Add(this.txbLastName);
            this.tabPage1.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabPage1.Location = new System.Drawing.Point(10, 58);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2326, 996);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "پزشک جدید";
            // 
            // txbDegree
            // 
            this.txbDegree.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbDegree.Location = new System.Drawing.Point(1086, 236);
            this.txbDegree.Name = "txbDegree";
            this.txbDegree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbDegree.Size = new System.Drawing.Size(364, 50);
            this.txbDegree.TabIndex = 6;
            this.txbDegree.TextChanged += new System.EventHandler(this.txbDegree_TextChanged);
            this.txbDegree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbDegree_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(883, 815);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(567, 148);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.txbEditByNC);
            this.tabPage2.Controls.Add(this.btnSelectMode);
            this.tabPage2.Controls.Add(this.btnDoctorSelect);
            this.tabPage2.Controls.Add(this.txbEditDegree);
            this.tabPage2.Controls.Add(this.txbEditMedicalSystemID);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.txbEditAddress);
            this.tabPage2.Controls.Add(this.txbEditSpecialty);
            this.tabPage2.Controls.Add(this.txbEditPhone);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.txbEditFatherName);
            this.tabPage2.Controls.Add(this.txbEditName);
            this.tabPage2.Controls.Add(this.txbEditLastName);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnSaveChanges);
            this.tabPage2.Controls.Add(this.cmbDoctorSelection);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabPage2.Location = new System.Drawing.Point(10, 58);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2326, 996);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "تغییر پزشک";
            // 
            // txbEditByNC
            // 
            this.txbEditByNC.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditByNC.Location = new System.Drawing.Point(1952, 81);
            this.txbEditByNC.Name = "txbEditByNC";
            this.txbEditByNC.ReadOnly = true;
            this.txbEditByNC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbEditByNC.Size = new System.Drawing.Size(294, 50);
            this.txbEditByNC.TabIndex = 133;
            this.txbEditByNC.TabStop = false;
            // 
            // btnSelectMode
            // 
            this.btnSelectMode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectMode.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelectMode.Location = new System.Drawing.Point(1959, 781);
            this.btnSelectMode.Name = "btnSelectMode";
            this.btnSelectMode.Size = new System.Drawing.Size(295, 179);
            this.btnSelectMode.TabIndex = 131;
            this.btnSelectMode.Text = "انتخاب پزشک";
            this.btnSelectMode.UseVisualStyleBackColor = false;
            this.btnSelectMode.Click += new System.EventHandler(this.btnSelectMode_Click);
            // 
            // btnDoctorSelect
            // 
            this.btnDoctorSelect.BackColor = System.Drawing.Color.Azure;
            this.btnDoctorSelect.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold);
            this.btnDoctorSelect.Location = new System.Drawing.Point(694, 136);
            this.btnDoctorSelect.Name = "btnDoctorSelect";
            this.btnDoctorSelect.Size = new System.Drawing.Size(105, 57);
            this.btnDoctorSelect.TabIndex = 130;
            this.btnDoctorSelect.Text = "انتخاب";
            this.btnDoctorSelect.UseVisualStyleBackColor = false;
            this.btnDoctorSelect.Click += new System.EventHandler(this.btnDoctorSelect_Click);
            // 
            // txbEditDegree
            // 
            this.txbEditDegree.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditDegree.Location = new System.Drawing.Point(1086, 236);
            this.txbEditDegree.Name = "txbEditDegree";
            this.txbEditDegree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbEditDegree.Size = new System.Drawing.Size(351, 50);
            this.txbEditDegree.TabIndex = 127;
            this.txbEditDegree.TextChanged += new System.EventHandler(this.txbEditDegree_TextChanged);
            this.txbEditDegree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditDegree_KeyDown);
            // 
            // txbEditMedicalSystemID
            // 
            this.txbEditMedicalSystemID.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditMedicalSystemID.Location = new System.Drawing.Point(1086, 81);
            this.txbEditMedicalSystemID.Name = "txbEditMedicalSystemID";
            this.txbEditMedicalSystemID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbEditMedicalSystemID.Size = new System.Drawing.Size(351, 50);
            this.txbEditMedicalSystemID.TabIndex = 119;
            this.txbEditMedicalSystemID.TextChanged += new System.EventHandler(this.txbEditMedicalSystemID_TextChanged);
            this.txbEditMedicalSystemID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditMedicalSystemID_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(1374, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 41);
            this.label10.TabIndex = 111;
            this.label10.Text = "آدرس";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(2167, 660);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 41);
            this.label11.TabIndex = 112;
            this.label11.Text = "تخصص";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(1291, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 41);
            this.label12.TabIndex = 113;
            this.label12.Text = "مدرک تحصیلی";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(1385, 350);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 41);
            this.label14.TabIndex = 114;
            this.label14.Text = "تلفن";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(2162, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 41);
            this.label15.TabIndex = 115;
            this.label15.Text = "کد ملی";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(2168, 505);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 41);
            this.label16.TabIndex = 116;
            this.label16.Text = "نام پدر";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(2117, 350);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 41);
            this.label17.TabIndex = 117;
            this.label17.Text = "نام خانوادگی";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(2202, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 41);
            this.label18.TabIndex = 118;
            this.label18.Text = "نام";
            // 
            // txbEditAddress
            // 
            this.txbEditAddress.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditAddress.Location = new System.Drawing.Point(69, 546);
            this.txbEditAddress.Multiline = true;
            this.txbEditAddress.Name = "txbEditAddress";
            this.txbEditAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbEditAddress.Size = new System.Drawing.Size(1368, 206);
            this.txbEditAddress.TabIndex = 120;
            this.txbEditAddress.TextChanged += new System.EventHandler(this.txbEditAddress_TextChanged);
            this.txbEditAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditAddress_KeyDown);
            // 
            // txbEditSpecialty
            // 
            this.txbEditSpecialty.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditSpecialty.Location = new System.Drawing.Point(1530, 701);
            this.txbEditSpecialty.Name = "txbEditSpecialty";
            this.txbEditSpecialty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbEditSpecialty.Size = new System.Drawing.Size(722, 50);
            this.txbEditSpecialty.TabIndex = 121;
            this.txbEditSpecialty.TextChanged += new System.EventHandler(this.txbEditSpecialty_TextChanged);
            this.txbEditSpecialty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditSpecialty_KeyDown);
            // 
            // txbEditPhone
            // 
            this.txbEditPhone.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditPhone.Location = new System.Drawing.Point(1087, 391);
            this.txbEditPhone.Name = "txbEditPhone";
            this.txbEditPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbEditPhone.Size = new System.Drawing.Size(351, 50);
            this.txbEditPhone.TabIndex = 122;
            this.txbEditPhone.TextChanged += new System.EventHandler(this.txbEditPhone_TextChanged);
            this.txbEditPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditPhone_KeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("A Chamran", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(1250, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(195, 41);
            this.label19.TabIndex = 110;
            this.label19.Text = "شناسه نظام پزشکی";
            // 
            // txbEditFatherName
            // 
            this.txbEditFatherName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditFatherName.Location = new System.Drawing.Point(1952, 546);
            this.txbEditFatherName.Name = "txbEditFatherName";
            this.txbEditFatherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbEditFatherName.Size = new System.Drawing.Size(293, 50);
            this.txbEditFatherName.TabIndex = 124;
            this.txbEditFatherName.TextChanged += new System.EventHandler(this.txbEditFatherName_TextChanged);
            this.txbEditFatherName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditFatherName_KeyDown);
            // 
            // txbEditName
            // 
            this.txbEditName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditName.Location = new System.Drawing.Point(1952, 236);
            this.txbEditName.Name = "txbEditName";
            this.txbEditName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbEditName.Size = new System.Drawing.Size(293, 50);
            this.txbEditName.TabIndex = 125;
            this.txbEditName.TextChanged += new System.EventHandler(this.txbEditName_TextChanged);
            this.txbEditName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditName_KeyDown);
            // 
            // txbEditLastName
            // 
            this.txbEditLastName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditLastName.Location = new System.Drawing.Point(1952, 391);
            this.txbEditLastName.Name = "txbEditLastName";
            this.txbEditLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbEditLastName.Size = new System.Drawing.Size(293, 50);
            this.txbEditLastName.TabIndex = 126;
            this.txbEditLastName.TextChanged += new System.EventHandler(this.txbEditLastName_TextChanged);
            this.txbEditLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditLastName_KeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(70, 781);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(574, 179);
            this.btnDelete.TabIndex = 109;
            this.btnDelete.Text = "حذف این پزشک";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveChanges.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.Location = new System.Drawing.Point(863, 781);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(574, 179);
            this.btnSaveChanges.TabIndex = 108;
            this.btnSaveChanges.Text = "ذخیره تغییرات";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cmbDoctorSelection
            // 
            this.cmbDoctorSelection.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbDoctorSelection.FormattingEnabled = true;
            this.cmbDoctorSelection.Location = new System.Drawing.Point(848, 139);
            this.cmbDoctorSelection.Name = "cmbDoctorSelection";
            this.cmbDoctorSelection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbDoctorSelection.Size = new System.Drawing.Size(727, 51);
            this.cmbDoctorSelection.TabIndex = 107;
            this.cmbDoctorSelection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDoctorSelection_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("A Chamran", 8F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(1429, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 41);
            this.label13.TabIndex = 106;
            this.label13.Text = "انتخاب پزشک";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage3.Controls.Add(this.lblTotal);
            this.tabPage3.Controls.Add(this.lblSelect);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.btnSelection);
            this.tabPage3.Controls.Add(this.cmbSearch);
            this.tabPage3.Controls.Add(this.dgvDoctors);
            this.tabPage3.Location = new System.Drawing.Point(10, 58);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(2326, 996);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "مشاهده پزشکان";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("B Nazanin", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Location = new System.Drawing.Point(1904, 880);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 44);
            this.lblTotal.TabIndex = 51;
            this.lblTotal.Text = "label";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("A Chamran", 8F);
            this.lblSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelect.Location = new System.Drawing.Point(2133, 737);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(147, 41);
            this.lblSelect.TabIndex = 130;
            this.lblSelect.Text = "انتخاب پزشک";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(2089, 880);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(186, 42);
            this.label21.TabIndex = 50;
            this.label21.Text = "تعداد کل پزشکان";
            // 
            // btnSelection
            // 
            this.btnSelection.BackColor = System.Drawing.Color.Azure;
            this.btnSelection.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold);
            this.btnSelection.Location = new System.Drawing.Point(1667, 775);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(105, 57);
            this.btnSelection.TabIndex = 129;
            this.btnSelection.Text = "انتخاب";
            this.btnSelection.UseVisualStyleBackColor = false;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(1822, 779);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearch.Size = new System.Drawing.Size(462, 51);
            this.cmbSearch.TabIndex = 1;
            this.cmbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSearch_KeyDown);
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.AllowUserToOrderColumns = true;
            this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDoctors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDoctors.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle50.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle50.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoctors.DefaultCellStyle = dataGridViewCellStyle50;
            this.dgvDoctors.Location = new System.Drawing.Point(1, 0);
            this.dgvDoctors.MultiSelect = false;
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle51.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle51.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle51.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctors.RowHeadersDefaultCellStyle = dataGridViewCellStyle51;
            this.dgvDoctors.RowHeadersWidth = 92;
            this.dgvDoctors.RowTemplate.Height = 37;
            this.dgvDoctors.Size = new System.Drawing.Size(2322, 697);
            this.dgvDoctors.TabIndex = 0;
            this.dgvDoctors.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.AliceBlue;
            this.label20.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 14F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(1013, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(312, 71);
            this.label20.TabIndex = 49;
            this.label20.Text = "اطلاعات پزشکان";
            this.label20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label20_MouseDown);
            // 
            // frmDoctorsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(2360, 1166);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoctorsInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmDoctorsInformation_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbMedicalSystemID;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbSpecialty;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbNationalCode;
        private System.Windows.Forms.TextBox txbFatherName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbDegree;
        private System.Windows.Forms.TextBox txbEditDegree;
        private System.Windows.Forms.TextBox txbEditMedicalSystemID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txbEditAddress;
        private System.Windows.Forms.TextBox txbEditSpecialty;
        private System.Windows.Forms.TextBox txbEditPhone;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txbEditFatherName;
        private System.Windows.Forms.TextBox txbEditName;
        private System.Windows.Forms.TextBox txbEditLastName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ComboBox cmbDoctorSelection;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnDoctorSelect;
        private System.Windows.Forms.Button btnSelectMode;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txbEditByNC;
    }
}