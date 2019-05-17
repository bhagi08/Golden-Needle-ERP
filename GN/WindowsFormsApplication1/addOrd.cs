using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;


namespace WindowsFormsApplication1
{
    public partial class addOrd : Form
    {
        private DBconnect con;
        private Boolean b;
        private string trans;
        public addOrd()
        {
            InitializeComponent();
            con = new DBconnect();
            Design.curve(this);
            timer1.Start();
            this.oDate.Value = DateTime.Now;


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
            close.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time.Text = dateTime.ToString();
        }

        private void ord_Click(object sender, EventArgs e)
        {
          
        }

        private void addOrd_Load(object sender, EventArgs e)
        {

            con.DBopen();
            autoIncriment(id_txt, "SELECT MAX(ord_id) FROM Orders");
            try
            {
                
                con.SqlQuery("SELECT buyer_code FROM Buyer ORDER BY buyer_code ASC");
                foreach (DataRow dr in con.SelQryEx().Rows)
                {
                    bc_cmb.Items.Add(dr[0].ToString());
                }

                con.SqlQuery("SELECT article FROM Orders ORDER BY article ASC");
                foreach (DataRow dr in con.SelQryEx().Rows)
                {
                    ar_cmb.Items.Add(dr[0].ToString());
                }

                con.SqlQuery("SELECT ci_no FROM Orders ORDER BY article ASC");
                foreach (DataRow dr in con.SelQryEx().Rows)
                {
                    ci_cmb.Items.Add(dr[0].ToString());
                }

            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            con.DBclose();


            

        }

        private void id_lbl_Click(object sender, EventArgs e)
        {

        }

        private void bc_lbl_Click(object sender, EventArgs e)
        {

        }

        private void od_lbl_Click(object sender, EventArgs e)
        {

        }

        private void rsd_lbl_Click(object sender, EventArgs e)
        {

        }

        private void csd_lbl_Click(object sender, EventArgs e)
        {

        }

        private void hs_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ov_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ev_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ts_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ar_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ci_lbl_Click(object sender, EventArgs e)
        {

        }

        private void co_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ev_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if(addOrdEmpyt() == -1)
            {
                addOrdEmptyErr();

            }
            else
            {
                ChkHs();
                ChkCi();
            }
           
           /* if(ts_cmb.Text == "Yes")
            {
                b = true;
            }
            else
            {
                b = false;
            }*/



            if( addOrdEmpyt() == 0 || ChkHs() == 0 || ChkCi() == 0)
            {
                con.DBopen();
               string stat = ChkTrans();

                try
                {
                    con.SqlQuery("INSERT INTO Orders ([ord_id],[buyer_code],[ord_date],[req_ship_date],[conf_ship_date],[hs_code],[order_val],[trans_split],[article],[ci_no]) values ('" + id_txt.Text + "','" + bc_cmb.Text + "','" + Convert.ToDateTime(oDate.Text) + "','" + Convert.ToDateTime(rDate.Text) + "','" + Convert.ToDateTime(cDate.Text) + "','" + hs_txt.Text + "','" + double.Parse(ov_txt.Text) + "','" + stat + "','" + ar_cmb.Text + "','" + ci_cmb.Text + "')");
                    con.InsQryEx();
                    MessageBox.Show("Added  Successfully ");
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

                con.DBclose();







            }
        }




        private int addOrdEmpyt()
        {
            if (string.IsNullOrEmpty(id_txt.Text) || bc_cmb.Text == "Select a buyer" || string.IsNullOrEmpty(oDate.Text) || string.IsNullOrEmpty(rDate.Text) || string.IsNullOrEmpty(hs_txt.Text)  || string.IsNullOrEmpty(ov_txt.Text) ||  string.IsNullOrEmpty(ar_cmb.Text) || ci_cmb.Text == "Select CI")
            {
                
                if (string.IsNullOrEmpty(id_txt.Text))
                {
                    e1.ForeColor = System.Drawing.Color.Red;
                    e1.Text = "*";
                }
                else
                    e1.Text = "";

                if (bc_cmb.Text == "Select a buyer")
                {
                    e2.ForeColor = System.Drawing.Color.Red;
                    e2.Text = "*";
                }
                else
                    e2.Text = "";

                if (string.IsNullOrEmpty(oDate.Text))
                {
                    e3.ForeColor = System.Drawing.Color.Red;
                    e3.Text = "*";
                }
                else
                    e3.Text = "";

                if (string.IsNullOrEmpty(rDate.Text))
                {
                    e4.ForeColor = System.Drawing.Color.Red;
                    e4.Text = "*";
                }
                else
                    e4.Text = "";

                if (string.IsNullOrEmpty(hs_txt.Text))
                {
                    e6.ForeColor = System.Drawing.Color.Red;
                    e6.Text = "*";
                }
                else 
                    e6.Text = ""; 
                           
                    
               /* if (ts_cmb.Text == "Select")
                {
                    e7.ForeColor = System.Drawing.Color.Red;
                    e7.Text = "*";
                }
                else
                    e7.Text = "";*/

                if (string.IsNullOrEmpty(ov_txt.Text))
                {
                    e8.ForeColor = System.Drawing.Color.Red;
                    e8.Text = "*";
                }
                else
                    e8.Text = "";

               

                if (string.IsNullOrEmpty(ar_cmb.Text))
                {
                    e10.ForeColor = System.Drawing.Color.Red;
                    e10.Text = "*";
                }
                else
                    e10.Text = "";

                if (string.IsNullOrEmpty(ci_cmb.Text))
                {
                    e11.ForeColor = System.Drawing.Color.Red;
                    e11.Text = "*";
                }
                else
                {
                    e11.Text = "";
                }

                return -1;

            }
            else
            {
                eMain.Visible = false;
                e1.Visible = false;
                e2.Visible = false;
                e3.Visible = false;
                e4.Visible = false;
                e6.Visible = false;
                e7.Visible = false;
                e8.Visible = false;
                e9.Visible = false;
                e10.Visible = false;
                e11.Visible = false;
                e12.Visible = false;
                return 0;
            }
        }

        private void addOrdEmptyErr()
        {
            MessageBox.Show("Please Fill Required Fields !", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            eMain.ForeColor = System.Drawing.Color.Red;
            eMain.Text = "Required Fields *";

        }

        private void hs_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {


                e.Handled = false;
                e6.Visible = false;

            }
            else
            {
                MessageBox.Show("Only Numbers Are Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                e6.ForeColor = System.Drawing.Color.Red;
                e6.Text = "Enter Numbers Only";
                e6.Visible = true;

            }
        }

        private int ChkHs()
        {
            if (hs_txt.Text.Length == 0)
            {
                e6.Visible = false;
                return -1;
            }


            else if (hs_txt.Text.Length != 10)
            {

                MessageBox.Show("HS Code Must Be 10 Digits !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hs_txt.Clear();
                e6.ForeColor = System.Drawing.Color.Red;
                e6.Text = "Enter  a 10 Digits Number";
                e6.Visible = true;
                return -999;

            }
            else
            {
                e6.Visible = false;
                return 0;
            }

        }

        private int ChkCi()
        {
            if (ci_cmb.Text == "Select CI")
            {
                e11.Visible = false;
                return -1;
            }


            else if (ci_cmb.Text.Length != 5 )
            {

                MessageBox.Show("Color Index Must Be 5 Digits !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ci_cmb.Text = "Select a Color Index";
                e11.ForeColor = System.Drawing.Color.Red;
                e11.Text = "Enter  a 5 Digits CI No";
                e11.Visible = true;
                return -999;

            }
            else
            {
                e11.Visible = false;
                return 0;
            }
        }

        private void bc_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            bc_cmb.Text = "Select a buyer";

            if (yes_rad.Checked)
            {
                yes_rad.Checked = false;
            }

            if (no_rad.Checked)
            {
                no_rad.Checked = false;
            }
            

        }

        private void ci_cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {


                e.Handled = false;
                e11.Visible = false;

            }
            else
            {
                MessageBox.Show("Only Numbers Are Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                e11.ForeColor = System.Drawing.Color.Red;
                e11.Text = "Enter Numbers Only";
                e11.Visible = true;
            }


        }

        private void Demo_Click(object sender, EventArgs e)
        {
           
            bc_cmb.Text = "ARDMEL";
            oDate.Text = "2016/01/02";
            rDate.Text = "2016/08/03";
            cDate.Text = "2016/08/03";
            hs_txt.Text = "6103330000";
            ov_txt.Text = "2500000";
          
            ar_cmb.Text = "Padded Isolation Jacket";
            ci_cmb.Text = "09899";
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void sam_Click(object sender, EventArgs e)
        {
            sample frm = new sample();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        public static void autoIncriment(Control t, string sqlQuery)
        {
            DBconnect conn = new DBconnect();
            conn.DBopen();
            conn.SqlQuery(sqlQuery);
            SqlDataReader re = conn.SelQryRedEx();

            try
            {
                re.Read();
                string value = re[0].ToString();
                if (value == "")
                {
                    t.Text = "ORD0000001";
                }
                else
                {
                    string temp = value.Substring(3, 7);
                    int number = Convert.ToInt32(temp);
                    number++;
                    string result = number.ToString().PadLeft(7, '0');
                    t.Text = "ORD" + result.ToString();
                }
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            conn.DBclose();
        }

        public string ChkTrans()
        {
            if (yes_rad.Checked)
            {
                trans = "Yes";
                return trans;
            }
            else
            {

                trans = "No";
                return trans;
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
