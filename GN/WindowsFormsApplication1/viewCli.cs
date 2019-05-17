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
    public partial class viewCli:Form
    {
        private DBconnect con;
        public viewCli()
        {
            InitializeComponent();
            Design.curve(this);
            timer1.Start();
            con = new DBconnect();
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
           
            order frm =new order();
            frm.Show();
            this.Hide();
           
        }

        private void da_Click(object sender, EventArgs e)
        {

        }

        private void viewo_frm_Load(object sender, EventArgs e)
        {
            con.DBopen();
            try
            {

                con.SqlQuery("SELECT buyer_code AS [Buyer Code], company AS [Company],address AS [Address] ,country AS [Country],email AS [Email]FROM Buyer ");
                viewCgrid.DataSource = con.SelQryEx();

            


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.DBclose();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            con.DBopen();
            try
            {

                con.SqlQuery("SELECT * FROM Buyer WHERE buyer_code LIKE '%" + searchtx.Text + "%' OR buyer_code LIKE '%" + searchtx.Text + "%' OR company LIKE '%" + searchtx.Text + "%'OR company LIKE '%" + searchtx.Text + "%'OR country LIKE '%" + searchtx.Text + "%'");
                viewCgrid.DataSource = con.SelQryEx();


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.DBclose();
            }
        }

        private void viewCgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <  0 || e.ColumnIndex != viewCgrid.Columns["Delete"].Index)
            return;
            else
            {

            }
        }

        private void pay_Click(object sender, EventArgs e)
        {
            Payments frm = new Payments();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void viewCgrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string email = viewCgrid.SelectedRows[0].Cells["Email"].Value.ToString();
            if (viewCgrid.Columns[e.ColumnIndex].Name == "Email")
            {

                System.Diagnostics.Process.Start("mailto:"+email+"");
            }
        }

        private void viewCgrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == viewCgrid.Columns["Email"].Index && e.RowIndex > -1)
            {


                var cell = viewCgrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

                cell.ToolTipText = "Double click to send an email";
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

            if (viewCgrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a client");
            }

            else
            {
                string bc = viewCgrid.SelectedRows[0].Cells["Buyer Code"].Value.ToString();
                string com = viewCgrid.SelectedRows[0].Cells["Company"].Value.ToString();
                string add = viewCgrid.SelectedRows[0].Cells["Address"].Value.ToString();
                string cont = viewCgrid.SelectedRows[0].Cells["Country"].Value.ToString();
                string eml = viewCgrid.SelectedRows[0].Cells["Email"].Value.ToString();




                viewCmaster frm = new viewCmaster(bc, com, add, cont, eml);

                this.Visible = false;
                frm.ShowDialog();
                this.Close();
            }
        }

     
    }
}
