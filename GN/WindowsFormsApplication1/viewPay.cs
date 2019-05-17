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
    public partial class viewPay:Form
    {
        DBconnect conn;
        public viewPay()
        {
           InitializeComponent();
           conn = new DBconnect();
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
            try
            {

                conn.SqlQuery("SELECT payment_id AS [Payment ID],ord_id AS [Order ID],buyer_code AS [Buyer Code],FORMAT( [val_USD],'N2') AS  [Value (USD)],FORMAT( [val_LKR],'N2') AS  [Value (LKR)],paydate AS [Date],payment_terms AS [Payment Terms] FROM GmntPayment ");
                viewPgrid.DataSource = conn.SelQryEx();
                viewPgrid.ClearSelection();












                foreach (DataGridViewColumn col in viewPgrid.Columns)
                {
                    col.Width = (viewPgrid.Width - 4) / viewPgrid.Columns.Count;

                }


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            finally
            {
                conn.DBclose();
            }
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (viewPgrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a sample");
            }

            else
            {
                string pId = viewPgrid.SelectedRows[0].Cells["Payment ID"].Value.ToString();
                string oId = viewPgrid.SelectedRows[0].Cells["Order ID"].Value.ToString();
                string bc = viewPgrid.SelectedRows[0].Cells["Buyer Code"].Value.ToString();
                string val_usd = viewPgrid.SelectedRows[0].Cells["Value (USD)"].Value.ToString();
                string val_lkr = viewPgrid.SelectedRows[0].Cells["Value (LKR)"].Value.ToString();
                string pdate = viewPgrid.SelectedRows[0].Cells["Date"].Value.ToString();
                string pt = viewPgrid.SelectedRows[0].Cells["Payment Terms"].Value.ToString();



                viewPmaster frm = new viewPmaster(pId, oId, bc, val_usd, val_lkr, pdate, pt);
                this.Visible = false;
                frm.ShowDialog();
                this.Close();

            }
        }

        public void Delete(string sId)
        {
            conn.DBopen();
            try
            {
                conn.SqlQuery("DELETE FROM GmntPayment WHERE [payment_id] = '" + sId + "'");
                conn.InsQryEx();
                MessageBox.Show("Deleted Succesfully!");
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                conn.DBclose();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

            if (viewPgrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row");
            }
            else
            {
                string pId = viewPgrid.SelectedRows[0].Cells["Payment ID"].Value.ToString();
                Delete(pId);

                viewPay frm = new viewPay();
                this.Visible = false;
                frm.ShowDialog();
                this.Close();
            }
        }

     
    }
}
