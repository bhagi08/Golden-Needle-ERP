using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project001
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new details().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new invoice().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btndashBoard_MouseHover(object sender, EventArgs e)
        {
            btndashBoard.Image = Properties.Resources.dashboard3;
        }

        private void btndashBoard_MouseLeave(object sender, EventArgs e)
        {
            btndashBoard.Image = Properties.Resources.dashboard2;
        }

        private void btnsupplierDetails_MouseHover(object sender, EventArgs e)
        {
            btnsupplierDetails.Image = Properties.Resources.sd2;
        }

        private void btnsupplierDetails_MouseLeave(object sender, EventArgs e)
        {
            btnsupplierDetails.Image = Properties.Resources.sd;
        }

        private void btnpurchaseDetails_MouseHover(object sender, EventArgs e)
        {
            btnpurchaseDetails.Image = Properties.Resources.pi2;
        }

        private void btnpurchaseDetails_MouseLeave(object sender, EventArgs e)
        {
            btnpurchaseDetails.Image = Properties.Resources.pi;
        }

        private void btngenarateReport_MouseHover(object sender, EventArgs e)
        {
            btngenarateReport.Image = Properties.Resources.gr2;
        }

        private void btngenarateReport_MouseLeave(object sender, EventArgs e)
        {
            btngenarateReport.Image = Properties.Resources.gr;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label1.Text = dateTime.ToString();
        }

        private void meterialSupplier_MouseHover(object sender, EventArgs e)
        {
            btnmonthlyReport.Image = Properties.Resources.analytic_report;
        }

        private void btnmonthlyReport_MouseLeave(object sender, EventArgs e)
        {
            btnmonthlyReport.Image = Properties.Resources.analytic_report__1_;
        }

        private void btnanualReport_MouseHover(object sender, EventArgs e)
        {
            btnanualReport.Image = Properties.Resources.progress_report;
        }

        private void btnanualReport_MouseLeave(object sender, EventArgs e)
        {
            btnanualReport.Image = Properties.Resources.progress_report__1_;
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        
    }
}
