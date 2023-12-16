namespace MedicalLab
{
    partial class frmSupport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupport));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbDetails = new System.Windows.Forms.TextBox();
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(999, 91);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(26, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 52);
            this.btnClose.TabIndex = 15;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "❌";
            this.toolTip1.SetToolTip(this.btnClose, "خروج");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txbLastName
            // 
            this.txbLastName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbLastName.Location = new System.Drawing.Point(174, 187);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbLastName.Size = new System.Drawing.Size(263, 50);
            this.txbLastName.TabIndex = 1;
            this.txbLastName.TextChanged += new System.EventHandler(this.txbLastName_TextChanged);
            this.txbLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbLastName_KeyDown);
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbEmail.Location = new System.Drawing.Point(174, 304);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(641, 50);
            this.txbEmail.TabIndex = 2;
            this.txbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEmail_KeyDown);
            // 
            // txbDetails
            // 
            this.txbDetails.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbDetails.Location = new System.Drawing.Point(174, 512);
            this.txbDetails.Multiline = true;
            this.txbDetails.Name = "txbDetails";
            this.txbDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbDetails.Size = new System.Drawing.Size(641, 196);
            this.txbDetails.TabIndex = 4;
            // 
            // txbSubject
            // 
            this.txbSubject.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbSubject.Location = new System.Drawing.Point(174, 410);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbSubject.Size = new System.Drawing.Size(641, 50);
            this.txbSubject.TabIndex = 3;
            this.txbSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSubject_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("A Chamran", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(768, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 45);
            this.label1.TabIndex = 21;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("A Chamran", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(673, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 45);
            this.label2.TabIndex = 22;
            this.label2.Text = "آدرس ایمیل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("A Chamran", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(722, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 45);
            this.label3.TabIndex = 23;
            this.label3.Text = "موضوع";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("A Chamran", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(719, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 45);
            this.label4.TabIndex = 24;
            this.label4.Text = "جزئیات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("A Chamran", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(289, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 45);
            this.label5.TabIndex = 25;
            this.label5.Text = "نام خانوادگی";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.txbName.Location = new System.Drawing.Point(603, 187);
            this.txbName.Name = "txbName";
            this.txbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbName.Size = new System.Drawing.Size(211, 50);
            this.txbName.TabIndex = 0;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            this.txbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbName_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Azure;
            this.btnSend.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSend.Location = new System.Drawing.Point(402, 744);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(183, 98);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "ارسال";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClean.BackgroundImage")));
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClean.Location = new System.Drawing.Point(899, 6);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(85, 76);
            this.btnClean.TabIndex = 28;
            this.btnClean.TabStop = false;
            this.toolTip1.SetToolTip(this.btnClean, "پاک کردن");
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(446, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 45);
            this.label6.TabIndex = 29;
            this.label6.Text = "پشتیبانی";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label6_MouseDown);
            // 
            // frmSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(993, 885);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSubject);
            this.Controls.Add(this.txbDetails);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSupport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmSupport_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbDetails;
        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
    }
}