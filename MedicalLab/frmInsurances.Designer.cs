namespace MedicalLab
{
    partial class frmInsurances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsurances));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbInsuranceType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbInsuranceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbEditInsuranceType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPatientSelection = new System.Windows.Forms.Button();
            this.btnSelectMode = new System.Windows.Forms.Button();
            this.cmbSelectInsurance = new System.Windows.Forms.ComboBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEditByName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvInsurances = new System.Windows.Forms.DataGridView();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnSelection = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsurances)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 91);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(14, 20);
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
            this.btnClean.Location = new System.Drawing.Point(882, 9);
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
            this.label3.Location = new System.Drawing.Point(351, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 71);
            this.label3.TabIndex = 48;
            this.label3.Text = "تعریف بیمه ها";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(-1, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 618);
            this.tabControl1.TabIndex = 108;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage1.Controls.Add(this.cmbInsuranceType);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txbInsuranceName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Font = new System.Drawing.Font("A Chamran", 8F);
            this.tabPage1.Location = new System.Drawing.Point(10, 58);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(961, 550);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "بیمه جدید";
            // 
            // cmbInsuranceType
            // 
            this.cmbInsuranceType.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbInsuranceType.FormattingEnabled = true;
            this.cmbInsuranceType.Items.AddRange(new object[] {
            "آزاد",
            "دولتی",
            "خصوصی",
            "تخصصی",
            "خیریه"});
            this.cmbInsuranceType.Location = new System.Drawing.Point(521, 217);
            this.cmbInsuranceType.Name = "cmbInsuranceType";
            this.cmbInsuranceType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbInsuranceType.Size = new System.Drawing.Size(389, 51);
            this.cmbInsuranceType.TabIndex = 137;
            this.cmbInsuranceType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbInsuranceType_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(353, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(248, 155);
            this.btnSave.TabIndex = 81;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(813, 162);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(102, 42);
            this.label5.TabIndex = 43;
            this.label5.Text = "نوع بیمه";
            // 
            // txbInsuranceName
            // 
            this.txbInsuranceName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbInsuranceName.Location = new System.Drawing.Point(42, 87);
            this.txbInsuranceName.Name = "txbInsuranceName";
            this.txbInsuranceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbInsuranceName.Size = new System.Drawing.Size(868, 50);
            this.txbInsuranceName.TabIndex = 42;
            this.txbInsuranceName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbInsuranceName_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(822, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 42);
            this.label4.TabIndex = 41;
            this.label4.Text = "نام بیمه";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage2.Controls.Add(this.cmbEditInsuranceType);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btnPatientSelection);
            this.tabPage2.Controls.Add(this.btnSelectMode);
            this.tabPage2.Controls.Add(this.cmbSelectInsurance);
            this.tabPage2.Controls.Add(this.btnSaveChanges);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txbEditByName);
            this.tabPage2.Font = new System.Drawing.Font("A Chamran", 8F);
            this.tabPage2.Location = new System.Drawing.Point(10, 58);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(961, 550);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "تغییر بیمه";
            // 
            // cmbEditInsuranceType
            // 
            this.cmbEditInsuranceType.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbEditInsuranceType.FormattingEnabled = true;
            this.cmbEditInsuranceType.Items.AddRange(new object[] {
            "آزاد",
            "دولتی",
            "خصوصی",
            "تخصصی",
            "خیریه"});
            this.cmbEditInsuranceType.Location = new System.Drawing.Point(521, 217);
            this.cmbEditInsuranceType.Name = "cmbEditInsuranceType";
            this.cmbEditInsuranceType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbEditInsuranceType.Size = new System.Drawing.Size(389, 51);
            this.cmbEditInsuranceType.TabIndex = 136;
            this.cmbEditInsuranceType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEditInsuranceType_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("A Chamran", 8F);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(646, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 41);
            this.label13.TabIndex = 135;
            this.label13.Text = "انتخاب بیمه";
            // 
            // btnPatientSelection
            // 
            this.btnPatientSelection.BackColor = System.Drawing.Color.Azure;
            this.btnPatientSelection.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold);
            this.btnPatientSelection.Location = new System.Drawing.Point(203, 81);
            this.btnPatientSelection.Name = "btnPatientSelection";
            this.btnPatientSelection.Size = new System.Drawing.Size(105, 57);
            this.btnPatientSelection.TabIndex = 134;
            this.btnPatientSelection.Text = "انتخاب";
            this.btnPatientSelection.UseVisualStyleBackColor = false;
            this.btnPatientSelection.Click += new System.EventHandler(this.btnPatientSelection_Click);
            // 
            // btnSelectMode
            // 
            this.btnSelectMode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectMode.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelectMode.Location = new System.Drawing.Point(146, 187);
            this.btnSelectMode.Name = "btnSelectMode";
            this.btnSelectMode.Size = new System.Drawing.Size(205, 149);
            this.btnSelectMode.TabIndex = 132;
            this.btnSelectMode.Text = "انتخاب بیمه";
            this.btnSelectMode.UseVisualStyleBackColor = false;
            this.btnSelectMode.Click += new System.EventHandler(this.btnSelectMode_Click);
            // 
            // cmbSelectInsurance
            // 
            this.cmbSelectInsurance.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbSelectInsurance.FormattingEnabled = true;
            this.cmbSelectInsurance.Location = new System.Drawing.Point(376, 87);
            this.cmbSelectInsurance.Name = "cmbSelectInsurance";
            this.cmbSelectInsurance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSelectInsurance.Size = new System.Drawing.Size(389, 51);
            this.cmbSelectInsurance.TabIndex = 110;
            this.cmbSelectInsurance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSelectInsurance_KeyDown);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveChanges.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.Location = new System.Drawing.Point(571, 324);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(294, 150);
            this.btnSaveChanges.TabIndex = 109;
            this.btnSaveChanges.Text = "ذخیره تغییرات";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(96, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(321, 68);
            this.btnDelete.TabIndex = 108;
            this.btnDelete.Text = "حذف این بیمه";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(813, 162);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(102, 42);
            this.label1.TabIndex = 84;
            this.label1.Text = "نوع بیمه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(822, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 42);
            this.label2.TabIndex = 82;
            this.label2.Text = "نام بیمه";
            // 
            // txbEditByName
            // 
            this.txbEditByName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEditByName.Location = new System.Drawing.Point(42, 89);
            this.txbEditByName.Name = "txbEditByName";
            this.txbEditByName.ReadOnly = true;
            this.txbEditByName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbEditByName.Size = new System.Drawing.Size(868, 50);
            this.txbEditByName.TabIndex = 138;
            this.txbEditByName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEditByName_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage3.Controls.Add(this.dgvInsurances);
            this.tabPage3.Controls.Add(this.lblSelect);
            this.tabPage3.Controls.Add(this.btnSelection);
            this.tabPage3.Controls.Add(this.cmbSearch);
            this.tabPage3.Location = new System.Drawing.Point(10, 58);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(961, 550);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "مشاهده بیمه ها";
            // 
            // dgvInsurances
            // 
            this.dgvInsurances.AllowUserToAddRows = false;
            this.dgvInsurances.AllowUserToDeleteRows = false;
            this.dgvInsurances.AllowUserToOrderColumns = true;
            this.dgvInsurances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInsurances.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInsurances.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsurances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInsurances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInsurances.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInsurances.Location = new System.Drawing.Point(0, 0);
            this.dgvInsurances.MultiSelect = false;
            this.dgvInsurances.Name = "dgvInsurances";
            this.dgvInsurances.ReadOnly = true;
            this.dgvInsurances.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsurances.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInsurances.RowHeadersWidth = 92;
            this.dgvInsurances.RowTemplate.Height = 37;
            this.dgvInsurances.Size = new System.Drawing.Size(959, 322);
            this.dgvInsurances.TabIndex = 132;
            this.dgvInsurances.TabStop = false;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("A Chamran", 8F);
            this.lblSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelect.Location = new System.Drawing.Point(601, 366);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(156, 41);
            this.lblSelect.TabIndex = 131;
            this.lblSelect.Text = "انتخاب آزمایش";
            // 
            // btnSelection
            // 
            this.btnSelection.BackColor = System.Drawing.Color.Azure;
            this.btnSelection.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold);
            this.btnSelection.Location = new System.Drawing.Point(143, 402);
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
            this.cmbSearch.Location = new System.Drawing.Point(296, 407);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearch.Size = new System.Drawing.Size(462, 51);
            this.cmbSearch.TabIndex = 32;
            this.cmbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSearch_KeyDown);
            // 
            // frmInsurances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(983, 720);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInsurances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmInsurances_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsurances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbInsuranceName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.ComboBox cmbSelectInsurance;
        private System.Windows.Forms.Button btnSelectMode;
        private System.Windows.Forms.DataGridView dgvInsurances;
        private System.Windows.Forms.Button btnPatientSelection;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbInsuranceType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEditInsuranceType;
        private System.Windows.Forms.TextBox txbEditByName;
    }
}