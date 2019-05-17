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
using System.Globalization;
using System.Collections;
using System.Data.SqlClient;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class viewSamples : Form
    {

        DBconnect conn;
        string temp;
        int chkUsd;
        int chkOrd;
        int datChk;
        int picChk;
        int sat;
        public viewSamples()
        {
            InitializeComponent();
            Design.curve(this);
            timer1.Start();
            conn = new DBconnect();
            temp = viewSmaster.ID();
            chkUsd = viewSmaster.CheckUsd();
            chkOrd = viewSmaster.CheckOid();
            datChk = viewSmaster.CheckDate();
            picChk = viewSmaster.CheckPic();
            sat = viewSmaster.CheckSat();
            textBox1.Text =Convert.ToString( chkUsd);

            


           
               
            






            /*    string temp = Login.profPic;
                 prof_pb.Image = Image.FromFile(temp);
                 prof_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                 prof_pb.BorderStyle = BorderStyle.None;
                 profPic_pnl.BackColor = Color.FromArgb(93, 210, 85);
                 string tmpName = Login.uName;
                 nm_lbl.Text = tmpName + " !";*/

            // CultureInfo sl = new CultureInfo("EN-IN");
            //  cost_txt.Text = i.ToString("c",sl);
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
            ord.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void cl_MouseHover(object sender, EventArgs e)
        {
            cl.Image = Resources.cp2;
            cl.ForeColor = Color.FromArgb(232, 126, 4);
        }

        private void cl_MouseLeave(object sender, EventArgs e)
        {
            cl.Image = Resources.cp;
            cl.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void sam_MouseHover(object sender, EventArgs e)
        {
            sam.Image = Resources.jacket2;
            sam.ForeColor = Color.FromArgb(232, 126, 4);
        }

        private void sam_MouseLeave(object sender, EventArgs e)
        {
            sam.Image = Resources.jacket;
            sam.ForeColor = Color.FromArgb(255, 255, 255);
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
            close.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time.Text = dateTime.ToString();
        }

        private void ord_Click(object sender, EventArgs e)
        {

            order frm = new order();
            frm.Show();
            this.Hide();

        }

        private void da_Click(object sender, EventArgs e)
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


        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewSamples_Load(object sender, EventArgs e)
        {

            conn.DBopen();
            try
            {
                
                conn.SqlQuery("SELECT Samp_id AS [Sample ID],ord_id AS [Order ID],Buyer_code AS [Buyer Code],FORMAT( [cost_USD],'N2') AS  [Cost (USD)],FORMAT( [cost_LKR],'N2') AS  [Cost (LKR)],Delivered_date AS [Delivered Date],samp_status AS [Status] FROM Gmnt_sample ");
                viewSgrid.DataSource = conn.SelQryEx();
                viewSgrid.ClearSelection();

                //Add link column to end of the grid to view fashion sketch
                DataGridViewLinkColumn bcol = new DataGridViewLinkColumn();
                bcol.HeaderText = " Picture ";
                bcol.Text = "View";
                bcol.LinkColor = Color.Blue;
                bcol.Name = "FP";
                bcol.UseColumnTextForLinkValue = true;
                viewSgrid.Columns.Add(bcol);

            
                
               








                foreach (DataGridViewColumn col in viewSgrid.Columns)
                {
                    col.Width = (viewSgrid.Width - 4) / viewSgrid.Columns.Count;

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

        private void viewSamples_Click(object sender, EventArgs e)
        {
            viewSgrid.CurrentCell.Selected = false;
        }



     


        private void mid_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewSgrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string samId = viewSgrid.SelectedRows[0].Cells["Sample ID"].Value.ToString();
            string oId = viewSgrid.SelectedRows[0].Cells["Order ID"].Value.ToString();
            string bc = viewSgrid.SelectedRows[0].Cells["Buyer Code"].Value.ToString();

            if (viewSgrid.Columns[e.ColumnIndex].Name == "FP")
            {

                FP frm = new FP(samId, oId, bc);
                frm.Show();
            }
        }



        private void viewSgrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (chkUsd != 0 || chkOrd != 0 || datChk != 0 || picChk != 0 || sat != 0)
            {
                foreach (DataGridViewRow row in viewSgrid.Rows)
                {
                    if (row.Cells[0].Value.ToString() == temp)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(3,201,169);
                    }


                }
            }
            /*else if (chkUsd == 0 && (viewSgrid.DefaultCellStyle.BackColor != Color.FromArgb(3, 201, 169)) || chkOrd == 0 && (viewSgrid.DefaultCellStyle.BackColor != Color.FromArgb(3, 201, 169)))
            {
                foreach (DataGridViewRow row in viewSgrid.Rows)
                {
                    if (row.Cells[0].Value.ToString() == temp)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(3,201,169);
                    }


                }
            }*/
            displayStatus();
            
        }

        private void viewSgrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == viewSgrid.Columns["FP"].Index && e.RowIndex > -1)
            {


                var cell = viewSgrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

                cell.ToolTipText = "Double click to view the fashion sketch";
            }



        }

       

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (viewSgrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a sample");
            }

            else
            {
                string samId = viewSgrid.SelectedRows[0].Cells["Sample ID"].Value.ToString();
                string oId = viewSgrid.SelectedRows[0].Cells["Order ID"].Value.ToString();
                string date = viewSgrid.SelectedRows[0].Cells["Delivered Date"].Value.ToString();
                string cost_usd = viewSgrid.SelectedRows[0].Cells["Cost (USD)"].Value.ToString();
                string cost_lkr = viewSgrid.SelectedRows[0].Cells["Cost (LKR)"].Value.ToString();
                string status = viewSgrid.SelectedRows[0].Cells["Status"].Value.ToString();


               
                viewSmaster frm = new viewSmaster(samId, oId, date, cost_usd, cost_lkr,status);
                frm.viewSgrid = this.viewSgrid;
                this.Visible = false;
                frm.ShowDialog();
                this.Close();
                
            }
        }


        private void delete_btn_Click(object sender, EventArgs e)
        {
            string samId = viewSgrid.SelectedRows[0].Cells["Sample ID"].Value.ToString();
            Delete(samId);

            viewSamples frm = new viewSamples();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
            
        }

        public void displayStatus()
        {
            int index = viewSgrid.RowCount;
            for (int i = 0; i < index; i++)
            {
                DataGridViewCell cell = viewSgrid[6, i];
                if (cell.Value.ToString() == "Pending")
                    {
                       cell.Style.ForeColor = Color.FromArgb(154,18,179);
                    }
                if (cell.Value.ToString() == "Rejected")
                {
                    cell.Style.ForeColor = Color.FromArgb(207, 0, 15);
                }
                if (cell.Value.ToString() == "Accepted")
                {
                    cell.Style.ForeColor = Color.FromArgb(12, 111, 12);
                }
            }

            
               
         }

        public void Delete(string sId)
        {
            conn.DBopen();
            try
            {
                conn.SqlQuery("DELETE FROM Gmnt_sample WHERE [Samp_id] = '"+sId+"'");
                conn.InsQryEx();
                MessageBox.Show("Deleted Succesfully!");
            }

            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                 conn.DBclose();
            }
        }

        private void pay_Click(object sender, EventArgs e)
        {
            Payments frm = new Payments();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void viewSgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       }
    }

     


        


       









