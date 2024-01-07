using System;
using System.Windows.Forms;

namespace StoreManageMent_1
{
    public partial class StoreManagement : Form
    {
        private ProgressBar progressBar1;
        private Timer timer1;
        private Label label2;

        public StoreManagement()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 39);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(326, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "0%";
            // 
            // StoreManagement
            // 
            this.ClientSize = new System.Drawing.Size(350, 119);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Name = "StoreManagement";
            this.Text = "Store Management";
            this.Load += new System.EventHandler(this.StoreManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void StoreManagement_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            timer1.Interval = 1000; // 1 second interval
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(4);
            label2.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == 100)
                timer1.Stop();
        }
    }
}
