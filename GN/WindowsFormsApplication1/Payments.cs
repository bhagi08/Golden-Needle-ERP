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
    public partial class Payments:Form
    {
        public Payments()
        {
           InitializeComponent();
           Design.curve(this);
           timer1.Start();
          /* string temp = Login.profPic;
           prof_pb.Image = Image.FromFile(temp);
           prof_pb.SizeMode = PictureBoxSizeMode.StretchImage;
           prof_pb.BorderStyle = BorderStyle.None;
           profPic_pnl.BackColor = Color.FromArgb(93,210,85);
           string tmpName = Login.uName;
           nm_lbl.Text = tmpName + " !";*/
          


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
           
            order frm2 =new order();
            this.Visible = false;
            frm2.ShowDialog();
            this.Close();
            
           
        }

        private void da_Click(object sender, EventArgs e)
        {
            dash frm = new dash();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void viewo_frm_Load(object sender, EventArgs e)
        {
            
        }

        private void cl_Click(object sender, EventArgs e)
        {
           clients frm = new clients();
           this.Visible = false;
           frm.ShowDialog();
           this.Close();
        }

        private void pay_Click(object sender, EventArgs e)
        {

        }

        private void addpa_MouseHover(object sender, EventArgs e)
        {
            addpa.Image = Resources.apR;
            addpa.ForeColor = Color.FromArgb(232, 126, 4);
        }

        private void addpa_MouseLeave(object sender, EventArgs e)
        {
            addpa.Image = Resources.ap;
            addpa.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void viewpa_MouseHover(object sender, EventArgs e)
        {
            viewpa.Image = Resources.vp;
            viewpa.ForeColor = Color.FromArgb(232, 126, 4);
        }

        private void viewpa_MouseLeave(object sender, EventArgs e)
        {
            viewpa.Image = Resources.vpR;
            viewpa.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void addpa_Click(object sender, EventArgs e)
        {
            addPay frm2 = new addPay();
            this.Visible = false;
            frm2.ShowDialog();
            this.Close();
        }

        private void viewpa_Click(object sender, EventArgs e)
        {
            viewPay frm2 = new viewPay();
            this.Visible = false;
            frm2.ShowDialog();
            this.Close();
        }

     
    }
}
