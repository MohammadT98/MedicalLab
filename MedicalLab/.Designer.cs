namespace MedicalLab
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.btnEnter = new System.Windows.Forms.Button();
            this.txbUserPass = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvTemp = new System.Windows.Forms.DataGridView();
            this.btnPassChar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 17F, System.Drawing.FontStyle.Bold);
            this.btnEnter.Location = new System.Drawing.Point(392, 606);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(303, 136);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "ورود";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            this.btnEnter.MouseEnter += new System.EventHandler(this.btnEnter_MouseEnter);
            this.btnEnter.MouseLeave += new System.EventHandler(this.btnEnter_MouseLeave);
            // 
            // txbUserPass
            // 
            this.txbUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F);
            this.txbUserPass.Location = new System.Drawing.Point(264, 448);
            this.txbUserPass.Name = "txbUserPass";
            this.txbUserPass.Size = new System.Drawing.Size(551, 109);
            this.txbUserPass.TabIndex = 1;
            this.txbUserPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbUserPass_KeyDown);
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F);
            this.txbUserName.Location = new System.Drawing.Point(264, 242);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(551, 109);
            this.txbUserName.TabIndex = 0;
            this.txbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbUserName_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(42, 38);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 52);
            this.btnClose.TabIndex = 14;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "❌";
            this.toolTip1.SetToolTip(this.btnClose, "خروج");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("A Chamran", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(666, 173);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(154, 56);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "نام کاربری";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("A Chamran", 12F);
            this.lbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl2.Location = new System.Drawing.Point(686, 376);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(139, 60);
            this.lbl2.TabIndex = 16;
            this.lbl2.Text = "رمز عبور";
            // 
            // dgvTemp
            // 
            this.dgvTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemp.Location = new System.Drawing.Point(14, 187);
            this.dgvTemp.Name = "dgvTemp";
            this.dgvTemp.RowHeadersWidth = 92;
            this.dgvTemp.RowTemplate.Height = 37;
            this.dgvTemp.Size = new System.Drawing.Size(243, 193);
            this.dgvTemp.TabIndex = 17;
            this.dgvTemp.TabStop = false;
            this.dgvTemp.Visible = false;
            // 
            // btnPassChar
            // 
            this.btnPassChar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPassChar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPassChar.BackgroundImage")));
            this.btnPassChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPassChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassChar.Location = new System.Drawing.Point(897, 466);
            this.btnPassChar.Name = "btnPassChar";
            this.btnPassChar.Size = new System.Drawing.Size(93, 65);
            this.btnPassChar.TabIndex = 18;
            this.btnPassChar.TabStop = false;
            this.btnPassChar.UseVisualStyleBackColor = false;
            this.btnPassChar.Click += new System.EventHandler(this.btnPassChar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1081, 137);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(470, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 102);
            this.label1.TabIndex = 20;
            this.label1.Text = "ورود";
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(144)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1079, 813);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPassChar);
            this.Controls.Add(this.dgvTemp);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.txbUserPass);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1081, 815);
            this.MinimumSize = new System.Drawing.Size(1081, 815);
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmStart_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txbUserPass;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvTemp;
        private System.Windows.Forms.Button btnPassChar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

