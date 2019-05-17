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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
            Design.curve(this);
            Design.curve(addo);
            Design.curve(viewo);
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
            Application.Exit();

            
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

        }

        private void addo_MouseHover(object sender, EventArgs e)
        {
            
            Design.HoverMouseBut(addo,Resources.Add2,245,170);
           
        }

        private void addo_MouseLeave(object sender, EventArgs e)
        {
           Design.LeaveMouseBut(addo,Resources.Add,239,134);
        }

        private void viewo_MouseHover(object sender, EventArgs e)
        {
            Design.HoverMouseBut(viewo, Resources.View2, 245, 170);
        }

        private void viewo_MouseLeave(object sender, EventArgs e)
        {
            Design.LeaveMouseBut(viewo, Resources.View, 239, 134);
        }

        private void addo_Click(object sender, EventArgs e)
        {
            addOrd frm = new addOrd();
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

        private void cl_Click(object sender, EventArgs e)
        {
            clients frm = new clients();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();

        }

        private void viewo_Click(object sender, EventArgs e)
        {
            viewOrd frm = new viewOrd();
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

        private void pay_Click(object sender, EventArgs e)
        {
            Payments frm = new Payments();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        

        
    }
}
