namespace MedicalLab
{
    partial class frmMessageBox1
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
            this.btnNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNo.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F);
            this.btnNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNo.Location = new System.Drawing.Point(485, 255);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(136, 86);
            this.btnNo.TabIndex = 0;
            this.btnNo.Text = "خیر";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btn1_Click);
            this.btnNo.MouseEnter += new System.EventHandler(this.btn1_MouseEnter);
            this.btnNo.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("A Chamran", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(155, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "آیا از خارج شدن خود مطمئن هستید؟";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 53);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYes.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnYes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYes.Location = new System.Drawing.Point(167, 255);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(136, 86);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "بله";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btn2_Click);
            this.btnYes.MouseEnter += new System.EventHandler(this.btn2_MouseEnter);
            this.btnYes.MouseLeave += new System.EventHandler(this.btn2_MouseLeave);
            // 
            // frmMessageBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(785, 433);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(785, 433);
            this.MinimumSize = new System.Drawing.Size(785, 433);
            this.Name = "frmMessageBox1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYes;
    }
}