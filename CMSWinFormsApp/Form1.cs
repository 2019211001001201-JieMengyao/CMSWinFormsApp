using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void workertoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WorkerForm workerForm = new WorkerForm();
                workerForm.ShowDialog();
        }
       
         private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
                customerForm.ShowDialog();
        }
       
         private void jobDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobDetalisForm2 jobDetailsForm2 = new JobDetalisForm2();
            jobDetailsForm2.ShowDialog();
        }
       
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
