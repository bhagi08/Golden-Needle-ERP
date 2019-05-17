using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class sample : Form
    {
        public sample()
        {
            InitializeComponent();
            Design.curve(this);
            Design.curve(addsa);
            Design.curve(viewsa);
            timer1.Start();
        }

        private void da_MouseHover(object sender, EventArgs e)
        {
            da.Image = Resources.db2;
            da.ForeColor = Color.FromArgb(232, 126, 4);
        }

        private void da_MouseLeave(object sender, EventArgs e)
        {
            da.Image = Resources.db;
            da.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void ord_MouseHover(object sender, EventArgs e)
        {
            ord.Image = Resources.list2;
            ord.ForeColor = Color.FromArgb(232, 126, 4);
        }

        private void ord_MouseLeave(object sender, EventArgs e)
        {
            ord.Image = Resources.list;
            ord.ForeColor = Color.FromArgb(255,255,255);
        }

        private void cl_MouseHover(object sender, EventArgs e)
        {
            cl.Image = Resources.cp2;
            cl.ForeColor = Color.FromArgb(232, 126, 4);
        }

        private void cl_MouseLeave(object sender, EventArgs e)
        {
            cl.Image = Resources.cp;
            cl.ForeColor = Color.FromArgb(255,255,255);
        }

        private void sam_MouseHover(object sender, EventArgs e)
        {
            sam.Image = Resources.jacket2;
            sam.ForeColor = Color.FromArgb(232, 126, 4);
        }

        private void sam_MouseLeave(object sender, EventArgs e)
        {
            sam.Image = Resources.jacket;
            sam.ForeColor = Color.FromArgb(255,255,255);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.FromArgb(0,0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time.Text = dateTime.ToString();
        }

        private void ord_Click(object sender, EventArgs e)
        {

            sample frm = new sample();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
           
        }

        private void da_Click(object sender, EventArgs e)
        {
            dash frm = new dash();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void sub_d_Click(object sender, EventArgs e)
        {

        }

        private void addsa_Click(object sender, EventArgs e)
        {
            addSamples frm = new addSamples();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void addsa_MouseHover(object sender, EventArgs e)
        {
            Design.HoverMouseBut(addsa,Resources.addSa2,250,170);
        }

        private void addsa_MouseLeave(object sender, EventArgs e)
        {
            Design.LeaveMouseBut(addsa, Resources.addSa, 239, 134);
        }

        private void viewsa_MouseHover(object sender, EventArgs e)
        {
            Design.HoverMouseBut(viewsa, Resources.viewSa2, 250, 170);
        }

        private void viewsa_MouseLeave(object sender, EventArgs e)
        {
            Design.LeaveMouseBut(viewsa, Resources.viewSa, 239, 134);
        }

        private void sample_Load(object sender, EventArgs e)
        {

        }

        private void cl_Click(object sender, EventArgs e)
        {
            clients frm = new clients();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void sam_Click(object sender, EventArgs e)
        {
            sample frm = new sample();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void viewsa_Click(object sender, EventArgs e)
        {
            viewSamples frm = new viewSamples();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void pay_Click(object sender, EventArgs e)
        {
            Payments frm = new Payments();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

      
     
    }
}
