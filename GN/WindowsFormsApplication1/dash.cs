using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class dash:Form
    {
        public dash()
        {
           InitializeComponent();
           Design.curve(this);
           timer1.Start();
           string temp = Login.profPic;
           prof_pb.Image = Image.FromFile(temp);
           prof_pb.SizeMode = PictureBoxSizeMode.StretchImage;
           prof_pb.BorderStyle = BorderStyle.None;
           profPic_pnl.BackColor = Color.FromArgb(93,210,85);
           string tmpName = Login.uName;
           nm_lbl.Text = tmpName + " !";
          


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
           /* using (GoldenEntities db = new GoldenEntities())
            {
                var data = db.GetTotOrd();
                ColumnSeries col = new ColumnSeries() { Title = "Orders",DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                Axis ax = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
                ax.Labels = new List<string>();
                foreach(var x in data)
                {
                    col.Values.Add(x.Total.Value);
                    ax.Labels.Add(x.Month.ToString());
                    cartesianChart1.Series.Add(col);
                    cartesianChart1.AxisX.Add(ax);
                    cartesianChart1.AxisY.Add(new Axis 

                    { 
                        //Title = "Months",
                        LabelFormatter = value =>value.ToString() ,
                        Separator = new Separator()
                    });*/

               
           
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
            Payments frm = new Payments();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void pay_MouseHover(object sender, EventArgs e)
        {
            pay.Image = Resources.ccr;
            pay.ForeColor = Color.FromArgb(232, 126, 4);
        }

        private void pay_MouseLeave(object sender, EventArgs e)
        {
            pay.Image = Resources.cc;
            pay.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void nm_lbl_DoubleClick(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

     
    }
}
