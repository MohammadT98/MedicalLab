namespace MedicalLab
{
    partial class frmPatientReception
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientReception));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbNC = new System.Windows.Forms.ComboBox();
            this.dgvSamp = new System.Windows.Forms.DataGridView();
            this.dgvDoc = new System.Windows.Forms.DataGridView();
            this.cmbSamplingPhysicianLastName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDoctorLastName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSamplingPhysicianName = new System.Windows.Forms.ComboBox();
            this.cmbDoctorName = new System.Windows.Forms.ComboBox();
            this.cmbExperiment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvforShow = new System.Windows.Forms.DataGridView();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnSelection = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.dgvPatientReception = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvforShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientReception)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1815, 91);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(26, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 52);
            this.btnClose.TabIndex = 16;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "❌";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(14, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1786, 870);
            this.tabControl1.TabIndex = 30;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cmbNC);
            this.tabPage1.Controls.Add(this.dgvSamp);
            this.tabPage1.Controls.Add(this.dgvDoc);
            this.tabPage1.Controls.Add(this.cmbSamplingPhysicianLastName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbDoctorLastName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbSamplingPhysicianName);
            this.tabPage1.Controls.Add(this.cmbDoctorName);
            this.tabPage1.Controls.Add(this.cmbExperiment);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Location = new System.Drawing.Point(10, 58);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1766, 802);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "پذیرش جدید";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(38, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 57);
            this.button2.TabIndex = 132;
            this.button2.Text = "انتخاب";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(598, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 57);
            this.button1.TabIndex = 131;
            this.button1.Text = "انتخاب";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbNC
            // 
            this.cmbNC.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbNC.FormattingEnabled = true;
            this.cmbNC.Location = new System.Drawing.Point(1312, 100);
            this.cmbNC.Name = "cmbNC";
            this.cmbNC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbNC.Size = new System.Drawing.Size(306, 51);
            this.cmbNC.TabIndex = 77;
            this.cmbNC.TextChanged += new System.EventHandler(this.cmbNC_TextChanged);
            // 
            // dgvSamp
            // 
            this.dgvSamp.AllowUserToAddRows = false;
            this.dgvSamp.AllowUserToDeleteRows = false;
            this.dgvSamp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSamp.Location = new System.Drawing.Point(38, 474);
            this.dgvSamp.Name = "dgvSamp";
            this.dgvSamp.RowHeadersWidth = 92;
            this.dgvSamp.RowTemplate.Height = 37;
            this.dgvSamp.Size = new System.Drawing.Size(267, 246);
            this.dgvSamp.TabIndex = 76;
            this.dgvSamp.TabStop = false;
            // 
            // dgvDoc
            // 
            this.dgvDoc.AllowUserToAddRows = false;
            this.dgvDoc.AllowUserToDeleteRows = false;
            this.dgvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoc.Location = new System.Drawing.Point(386, 474);
            this.dgvDoc.Name = "dgvDoc";
            this.dgvDoc.RowHeadersWidth = 92;
            this.dgvDoc.RowTemplate.Height = 37;
            this.dgvDoc.Size = new System.Drawing.Size(267, 246);
            this.dgvDoc.TabIndex = 75;
            this.dgvDoc.TabStop = false;
            // 
            // cmbSamplingPhysicianLastName
            // 
            this.cmbSamplingPhysicianLastName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbSamplingPhysicianLastName.FormattingEnabled = true;
            this.cmbSamplingPhysicianLastName.Location = new System.Drawing.Point(166, 342);
            this.cmbSamplingPhysicianLastName.Name = "cmbSamplingPhysicianLastName";
            this.cmbSamplingPhysicianLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSamplingPhysicianLastName.Size = new System.Drawing.Size(306, 51);
            this.cmbSamplingPhysicianLastName.TabIndex = 72;
            this.cmbSamplingPhysicianLastName.TextChanged += new System.EventHandler(this.cmbSamplingPhysicianLastName_TextChanged);
            this.cmbSamplingPhysicianLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSamplingPhysicianLastName_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label5.Location = new System.Drawing.Point(231, 298);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(244, 42);
            this.label5.TabIndex = 71;
            this.label5.Text = "نام خانوادگی نمونه بردار";
            // 
            // cmbDoctorLastName
            // 
            this.cmbDoctorLastName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbDoctorLastName.FormattingEnabled = true;
            this.cmbDoctorLastName.Location = new System.Drawing.Point(728, 342);
            this.cmbDoctorLastName.Name = "cmbDoctorLastName";
            this.cmbDoctorLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbDoctorLastName.Size = new System.Drawing.Size(306, 51);
            this.cmbDoctorLastName.TabIndex = 70;
            this.cmbDoctorLastName.TextChanged += new System.EventHandler(this.cmbDoctorLastName_TextChanged);
            this.cmbDoctorLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDoctorLastName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label1.Location = new System.Drawing.Point(835, 298);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(204, 42);
            this.label1.TabIndex = 69;
            this.label1.Text = "نام خانوادگی پزشک";
            // 
            // cmbSamplingPhysicianName
            // 
            this.cmbSamplingPhysicianName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbSamplingPhysicianName.FormattingEnabled = true;
            this.cmbSamplingPhysicianName.Location = new System.Drawing.Point(166, 100);
            this.cmbSamplingPhysicianName.Name = "cmbSamplingPhysicianName";
            this.cmbSamplingPhysicianName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSamplingPhysicianName.Size = new System.Drawing.Size(306, 51);
            this.cmbSamplingPhysicianName.TabIndex = 68;
            this.cmbSamplingPhysicianName.TextChanged += new System.EventHandler(this.cmbSamplingPhysicianName_TextChanged);
            this.cmbSamplingPhysicianName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSamplingPhysicianName_KeyDown);
            // 
            // cmbDoctorName
            // 
            this.cmbDoctorName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbDoctorName.FormattingEnabled = true;
            this.cmbDoctorName.Location = new System.Drawing.Point(729, 100);
            this.cmbDoctorName.Name = "cmbDoctorName";
            this.cmbDoctorName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbDoctorName.Size = new System.Drawing.Size(306, 51);
            this.cmbDoctorName.TabIndex = 67;
            this.cmbDoctorName.TextChanged += new System.EventHandler(this.cmbDoctorName_TextChanged);
            this.cmbDoctorName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDoctorName_KeyDown);
            // 
            // cmbExperiment
            // 
            this.cmbExperiment.Font = new System.Drawing.Font("B Nazanin", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbExperiment.FormattingEnabled = true;
            this.cmbExperiment.Location = new System.Drawing.Point(1190, 342);
            this.cmbExperiment.Name = "cmbExperiment";
            this.cmbExperiment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbExperiment.Size = new System.Drawing.Size(428, 48);
            this.cmbExperiment.TabIndex = 66;
            this.cmbExperiment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbExperiment_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label7.Location = new System.Drawing.Point(1498, 298);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(125, 42);
            this.label7.TabIndex = 65;
            this.label7.Text = "نام آزمایش";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(733, 616);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(298, 153);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label17.Location = new System.Drawing.Point(1481, 57);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(140, 42);
            this.label17.TabIndex = 52;
            this.label17.Text = "کد ملی بیمار";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label16.Location = new System.Drawing.Point(926, 57);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(115, 42);
            this.label16.TabIndex = 51;
            this.label16.Text = "نام پزشک";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label15.Location = new System.Drawing.Point(321, 56);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(155, 42);
            this.label15.TabIndex = 50;
            this.label15.Text = "نام نمونه بردار";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.dgvforShow);
            this.tabPage2.Controls.Add(this.lblSelect);
            this.tabPage2.Controls.Add(this.btnSelection);
            this.tabPage2.Controls.Add(this.cmbSearch);
            this.tabPage2.Controls.Add(this.dgvPatientReception);
            this.tabPage2.Controls.Add(this.lblTotal);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(10, 58);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1766, 802);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "مشاهده پذیرش ها";
            // 
            // dgvforShow
            // 
            this.dgvforShow.AllowUserToAddRows = false;
            this.dgvforShow.AllowUserToDeleteRows = false;
            this.dgvforShow.AllowUserToOrderColumns = true;
            this.dgvforShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvforShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvforShow.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvforShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvforShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvforShow.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvforShow.Location = new System.Drawing.Point(1, 0);
            this.dgvforShow.MultiSelect = false;
            this.dgvforShow.Name = "dgvforShow";
            this.dgvforShow.ReadOnly = true;
            this.dgvforShow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvforShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvforShow.RowHeadersWidth = 92;
            this.dgvforShow.RowTemplate.Height = 37;
            this.dgvforShow.Size = new System.Drawing.Size(1762, 560);
            this.dgvforShow.TabIndex = 132;
            this.dgvforShow.TabStop = false;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("A Chamran", 8F);
            this.lblSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelect.Location = new System.Drawing.Point(1587, 591);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(132, 41);
            this.lblSelect.TabIndex = 131;
            this.lblSelect.Text = "انتخاب بیمار";
            // 
            // btnSelection
            // 
            this.btnSelection.BackColor = System.Drawing.Color.Azure;
            this.btnSelection.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold);
            this.btnSelection.Location = new System.Drawing.Point(1093, 625);
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
            this.cmbSearch.Location = new System.Drawing.Point(1249, 633);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearch.Size = new System.Drawing.Size(462, 51);
            this.cmbSearch.TabIndex = 32;
            this.cmbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSearch_KeyDown);
            // 
            // dgvPatientReception
            // 
            this.dgvPatientReception.AllowUserToAddRows = false;
            this.dgvPatientReception.AllowUserToDeleteRows = false;
            this.dgvPatientReception.AllowUserToOrderColumns = true;
            this.dgvPatientReception.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPatientReception.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPatientReception.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientReception.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvPatientReception.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientReception.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvPatientReception.Location = new System.Drawing.Point(0, 0);
            this.dgvPatientReception.MultiSelect = false;
            this.dgvPatientReception.Name = "dgvPatientReception";
            this.dgvPatientReception.ReadOnly = true;
            this.dgvPatientReception.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientReception.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvPatientReception.RowHeadersWidth = 92;
            this.dgvPatientReception.RowTemplate.Height = 37;
            this.dgvPatientReception.Size = new System.Drawing.Size(915, 560);
            this.dgvPatientReception.TabIndex = 31;
            this.dgvPatientReception.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("B Nazanin", 8.1F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(1249, 721);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 44);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1544, 723);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "تعداد پذیرش ها";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.AliceBlue;
            this.btnClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClean.BackgroundImage")));
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClean.Location = new System.Drawing.Point(1715, 7);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(85, 76);
            this.btnClean.TabIndex = 53;
            this.btnClean.TabStop = false;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(787, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 71);
            this.label4.TabIndex = 54;
            this.label4.Text = "پذیرش بیمار";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // frmPatientReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1814, 986);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPatientReception";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmPatientReception_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvforShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientReception)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPatientReception;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSamplingPhysicianName;
        private System.Windows.Forms.ComboBox cmbDoctorName;
        private System.Windows.Forms.ComboBox cmbExperiment;
        private System.Windows.Forms.DataGridView dgvforShow;
        private System.Windows.Forms.ComboBox cmbSamplingPhysicianLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDoctorLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDoc;
        private System.Windows.Forms.DataGridView dgvSamp;
        private System.Windows.Forms.ComboBox cmbNC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}