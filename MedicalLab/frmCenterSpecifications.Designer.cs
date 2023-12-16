namespace MedicalLab
{
    partial class frmCenterSpecifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCenterSpecifications));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbPhone1 = new System.Windows.Forms.TextBox();
            this.txbPhone2 = new System.Windows.Forms.TextBox();
            this.txbPhone3 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvCenterSpecifications = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenterSpecifications)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1191, 128);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(42, 36);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 52);
            this.btnClose.TabIndex = 15;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "❌";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txbCity
            // 
            this.txbCity.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txbCity.Location = new System.Drawing.Point(103, 314);
            this.txbCity.Name = "txbCity";
            this.txbCity.ReadOnly = true;
            this.txbCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbCity.Size = new System.Drawing.Size(417, 50);
            this.txbCity.TabIndex = 6;
            this.txbCity.TextChanged += new System.EventHandler(this.txbCity_TextChanged);
            this.txbCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCity_KeyDown);
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txbAddress.Location = new System.Drawing.Point(103, 414);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.ReadOnly = true;
            this.txbAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbAddress.Size = new System.Drawing.Size(417, 149);
            this.txbAddress.TabIndex = 7;
            this.txbAddress.TextChanged += new System.EventHandler(this.txbAddress_TextChanged);
            this.txbAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbAddress_KeyDown);
            // 
            // txbState
            // 
            this.txbState.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txbState.Location = new System.Drawing.Point(103, 206);
            this.txbState.Name = "txbState";
            this.txbState.ReadOnly = true;
            this.txbState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbState.Size = new System.Drawing.Size(417, 50);
            this.txbState.TabIndex = 5;
            this.txbState.TextChanged += new System.EventHandler(this.txbState_TextChanged);
            this.txbState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbState_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("A Chamran", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(984, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 45);
            this.label1.TabIndex = 27;
            this.label1.Text = "نام مرکز";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("A Chamran", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(441, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 45);
            this.label2.TabIndex = 28;
            this.label2.Text = "آدرس";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("A Chamran", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(458, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 45);
            this.label5.TabIndex = 31;
            this.label5.Text = "شهر";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("A Chamran", 9F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(439, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 45);
            this.label10.TabIndex = 36;
            this.label10.Text = "استان";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("A Chamran", 9F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(985, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 45);
            this.label11.TabIndex = 37;
            this.label11.Text = "کد مرکز";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("A Chamran", 9F);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(1024, 367);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 45);
            this.label14.TabIndex = 40;
            this.label14.Text = "تلفن";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChange.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnChange.Location = new System.Drawing.Point(505, 632);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(179, 97);
            this.btnChange.TabIndex = 42;
            this.btnChange.Text = "تغییر";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txbCode
            // 
            this.txbCode.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txbCode.Location = new System.Drawing.Point(675, 206);
            this.txbCode.Name = "txbCode";
            this.txbCode.ReadOnly = true;
            this.txbCode.Size = new System.Drawing.Size(417, 50);
            this.txbCode.TabIndex = 0;
            this.txbCode.TextChanged += new System.EventHandler(this.txbCode_TextChanged);
            this.txbCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCode_KeyDown);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txbName.Location = new System.Drawing.Point(675, 314);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbName.Size = new System.Drawing.Size(417, 50);
            this.txbName.TabIndex = 1;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            this.txbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbName_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(463, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 71);
            this.label3.TabIndex = 47;
            this.label3.Text = "مشخصات مرکز";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(505, 632);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 97);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbPhone1
            // 
            this.txbPhone1.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txbPhone1.Location = new System.Drawing.Point(675, 414);
            this.txbPhone1.Name = "txbPhone1";
            this.txbPhone1.ReadOnly = true;
            this.txbPhone1.Size = new System.Drawing.Size(417, 50);
            this.txbPhone1.TabIndex = 2;
            this.txbPhone1.TextChanged += new System.EventHandler(this.txbPhone1_TextChanged);
            this.txbPhone1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPhone1_KeyDown);
            // 
            // txbPhone2
            // 
            this.txbPhone2.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txbPhone2.Location = new System.Drawing.Point(675, 470);
            this.txbPhone2.Name = "txbPhone2";
            this.txbPhone2.ReadOnly = true;
            this.txbPhone2.Size = new System.Drawing.Size(417, 50);
            this.txbPhone2.TabIndex = 3;
            this.txbPhone2.TextChanged += new System.EventHandler(this.txbPhone2_TextChanged);
            this.txbPhone2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPhone2_KeyDown);
            // 
            // txbPhone3
            // 
            this.txbPhone3.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txbPhone3.Location = new System.Drawing.Point(675, 526);
            this.txbPhone3.Name = "txbPhone3";
            this.txbPhone3.ReadOnly = true;
            this.txbPhone3.Size = new System.Drawing.Size(417, 50);
            this.txbPhone3.TabIndex = 4;
            this.txbPhone3.TextChanged += new System.EventHandler(this.txbPhone3_TextChanged);
            this.txbPhone3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPhone3_KeyDown);
            // 
            // dgvCenterSpecifications
            // 
            this.dgvCenterSpecifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCenterSpecifications.Location = new System.Drawing.Point(42, 191);
            this.dgvCenterSpecifications.Name = "dgvCenterSpecifications";
            this.dgvCenterSpecifications.RowHeadersWidth = 92;
            this.dgvCenterSpecifications.RowTemplate.Height = 37;
            this.dgvCenterSpecifications.Size = new System.Drawing.Size(198, 160);
            this.dgvCenterSpecifications.TabIndex = 53;
            this.dgvCenterSpecifications.TabStop = false;
            this.dgvCenterSpecifications.Visible = false;
            // 
            // frmCenterSpecifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1189, 773);
            this.Controls.Add(this.dgvCenterSpecifications);
            this.Controls.Add(this.txbPhone3);
            this.Controls.Add(this.txbPhone2);
            this.Controls.Add(this.txbPhone1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbState);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCenterSpecifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmCenterSpecifications_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenterSpecifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbPhone1;
        private System.Windows.Forms.TextBox txbPhone2;
        private System.Windows.Forms.TextBox txbPhone3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvCenterSpecifications;
    }
}