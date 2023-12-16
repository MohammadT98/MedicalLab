namespace MedicalLab
{
    partial class frmFinancialReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinancialReport));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.dgvFinancialReport = new System.Windows.Forms.DataGridView();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnSelection = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1173, 128);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(37, 36);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 52);
            this.btnClose.TabIndex = 17;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "❌";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkCyan;
            this.label5.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(481, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 71);
            this.label5.TabIndex = 48;
            this.label5.Text = "گزارش مالی";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(825, 1008);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(310, 42);
            this.label2.TabIndex = 51;
            this.label2.Text = "جمع کل درآمد مالی بدون بیمه";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Font = new System.Drawing.Font("B Nazanin", 8.1F, System.Drawing.FontStyle.Bold);
            this.lblTotal2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal2.Location = new System.Drawing.Point(626, 1008);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal2.Size = new System.Drawing.Size(106, 44);
            this.lblTotal2.TabIndex = 53;
            this.lblTotal2.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("A Chamran", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(863, 943);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(274, 42);
            this.label1.TabIndex = 50;
            this.label1.Text = "جمع کل درآمد مالی با بیمه";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Font = new System.Drawing.Font("B Nazanin", 8.1F, System.Drawing.FontStyle.Bold);
            this.lblTotal1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal1.Location = new System.Drawing.Point(626, 943);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal1.Size = new System.Drawing.Size(108, 44);
            this.lblTotal1.TabIndex = 52;
            this.lblTotal1.Text = "label3";
            // 
            // dgvFinancialReport
            // 
            this.dgvFinancialReport.AllowUserToAddRows = false;
            this.dgvFinancialReport.AllowUserToDeleteRows = false;
            this.dgvFinancialReport.AllowUserToOrderColumns = true;
            this.dgvFinancialReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFinancialReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFinancialReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinancialReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinancialReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinancialReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFinancialReport.Location = new System.Drawing.Point(0, 125);
            this.dgvFinancialReport.Name = "dgvFinancialReport";
            this.dgvFinancialReport.ReadOnly = true;
            this.dgvFinancialReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("A Chamran", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinancialReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFinancialReport.RowHeadersWidth = 92;
            this.dgvFinancialReport.RowTemplate.Height = 37;
            this.dgvFinancialReport.Size = new System.Drawing.Size(1173, 635);
            this.dgvFinancialReport.TabIndex = 54;
            this.dgvFinancialReport.TabStop = false;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("A Chamran", 8F);
            this.lblSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelect.Location = new System.Drawing.Point(928, 794);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(208, 41);
            this.lblSelect.TabIndex = 134;
            this.lblSelect.Text = "انتخاب تاریخ آزمایش";
            // 
            // btnSelection
            // 
            this.btnSelection.BackColor = System.Drawing.Color.Azure;
            this.btnSelection.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold);
            this.btnSelection.Location = new System.Drawing.Point(521, 831);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(105, 57);
            this.btnSelection.TabIndex = 1;
            this.btnSelection.Text = "انتخاب";
            this.btnSelection.UseVisualStyleBackColor = false;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(674, 836);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearch.Size = new System.Drawing.Size(462, 51);
            this.cmbSearch.TabIndex = 0;
            this.cmbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSearch_KeyDown);
            // 
            // frmFinancialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1173, 1088);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.dgvFinancialReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinancialReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmFinancialReport_Activated);
            this.Shown += new System.EventHandler(this.frmFinancialReport_Shown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.DataGridView dgvFinancialReport;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.ComboBox cmbSearch;
    }
}