using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace MedicalLab
{
    public partial class frmBeforeStart : Form
    {
        public frmBeforeStart()
        {
            InitializeComponent();

            //use timer to generate delay
            timer1.Tick += new EventHandler(MyTimer_Tick);
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Start();
        }

        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            //delay for 4000 milliseconds
            Thread.Sleep(4000);

            //show the next form
            frmStart StartForm = new frmStart();
            StartForm.Show();

            timer1.Stop();
            timer1.Dispose();

            this.Hide();
        }
    }
}
