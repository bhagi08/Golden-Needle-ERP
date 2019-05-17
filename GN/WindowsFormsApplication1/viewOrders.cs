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
    public partial class viewOrd: Form
    {

        private DBconnect con;
        public viewOrd()
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
           
            order frm =new order();
            frm.Show();
            this.Hide();
           
        }

        private void da_Click(object sender, EventArgs e)
        {

        }

        private void viewOrd_Load(object sender, EventArgs e)
        {
           
            try
            {
                con.DBopen();

                con.SqlQuery("SELECT ord_id AS [Order ID], buyer_code AS [Buyer Code],ord_date AS [Order Date], req_ship_date AS [Requested Ship Date], conf_ship_date AS [Confirmed Ship Date],hs_code AS [HS Code],order_val AS [Order Value],trans_split AS [Transaction Split],article AS [Article],ci_no AS [CI No] FROM Orders");
                viewOgrid.DataSource = con.SelQryEx();
                viewOgrid.ClearSelection();



                foreach (DataGridViewColumn col in viewOgrid.Columns)
                {
                    col.Width = (viewOgrid.Width - 4) / viewOgrid.Columns.Count;

                }
               

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.DBclose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try 
            {
                con.SqlQuery("SELECT * FROM Orders WHERE ord_id LIKE '%" + searchtx.Text + "%' OR buyer_code LIKE '%" + searchtx.Text + "%' OR hs_code LIKE '%" + searchtx.Text + "'OR trans_split LIKE '%" + searchtx.Text + "'");
                viewOgrid.DataSource = con.SelQryEx();
            }

            catch(Exception error)
            {
                MessageBox.Show(error.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_MouseHover(object sender, EventArgs e)
        {
            Search.Image = Resources.search1;
            Search.ForeColor = Color.FromArgb(232, 126, 4);
        }

        private void Search_MouseLeave(object sender, EventArgs e)
        {
            Search.Image = Resources.search;
            Search.ForeColor = Color.FromArgb(0, 0,0);
        }

        private void viewOgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string ordId = viewOgrid.SelectedRows[0].Cells["Order ID"].Value.ToString();
            Delete(ordId);

            viewOrd frm = new viewOrd();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        public void Delete(string oId)
        {
            con.DBopen();
            try
            {
                con.SqlQuery("DELETE FROM Orders WHERE [ord_id] = '" + oId + "'");
                con.InsQryEx();
                MessageBox.Show("Deleted Succesfully!");
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.DBclose();
            }
        }

        public void displayStatus()
        {
            int index = viewOgrid.RowCount;
            for (int i = 0; i < index; i++)
            {
                DataGridViewCell cell = viewOgrid[7, i];
                if (cell.Value.ToString() == "Yes")
                {
                    cell.Style.ForeColor = Color.FromArgb(207, 0, 15);
                }
                if (cell.Value.ToString() == "No")
                {
                    cell.Style.ForeColor = Color.FromArgb(12, 111, 12);
                }

            }
        }

        private void viewOgrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            displayStatus();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (viewOgrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a sample");
            }

            else
            {
                string oId = viewOgrid.SelectedRows[0].Cells["Order ID"].Value.ToString();
                string bId = viewOgrid.SelectedRows[0].Cells["Buyer Code"].Value.ToString();
                string oD = viewOgrid.SelectedRows[0].Cells["Order Date"].Value.ToString();
                string rsd = viewOgrid.SelectedRows[0].Cells["Requested Ship Date"].Value.ToString();
                string csd = viewOgrid.SelectedRows[0].Cells["Confirmed Ship Date"].Value.ToString();
                string hs = viewOgrid.SelectedRows[0].Cells["HS Code"].Value.ToString();
                string ov = viewOgrid.SelectedRows[0].Cells["Order Value"].Value.ToString();
                string ts = viewOgrid.SelectedRows[0].Cells["Transaction Split"].Value.ToString();
                string ar = viewOgrid.SelectedRows[0].Cells["Article"].Value.ToString();
                string ci = viewOgrid.SelectedRows[0].Cells["CI No"].Value.ToString();



                viewOmaster frm = new viewOmaster(oId, bId, oD, rsd, csd, hs, ov, ts, ar, ci);
                this.Visible = false;
                frm.ShowDialog();
                this.Close();

            }
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
