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
    public partial class addPay:Form
    {
        DBconnect conn;
        public addPay()
        {
           InitializeComponent();
           Design.curve(this);
           timer1.Start();
           conn = new DBconnect();
           pd_dtp.Value = DateTime.Now;
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

            placeHolders();
            conn.DBopen();
            try 
            {
                autoIncriment(pid_txt, "SELECT MAX(payment_id) FROM GmntPayment");

                conn.SqlQuery("SELECT ord_id FROM Orders ");

                foreach (DataRow dr in conn.SelQryEx().Rows)
                {
                    oid_cmb.Items.Add(dr[0].ToString());
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
                    t.Text = "PMT0001";
                }
                else
                {
                    string temp = value.Substring(3, 4);
                    int number = Convert.ToInt32(temp);
                    number++;
                    string result = number.ToString().PadLeft(4, '0');
                    t.Text = "PMT" + result.ToString();
                }
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            conn.DBclose();
        }

        private void oid_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.DBopen();
            try
            {
                string oid = oid_cmb.Text;
                conn.SqlQuery("SELECT buyer_code FROM Orders WHERE ord_id  = '" + oid + "'");
                string buyer_code = (string)conn.cmd.ExecuteScalar();

                bc_txt.Text = buyer_code;


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

        private void val_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 46 || e.KeyChar == 13)
            {


                e.Handled = false;

            }

            else if (e.KeyChar == 45)
            {
                MessageBox.Show("Minus values are not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                e4.ForeColor = System.Drawing.Color.Red;
                e4.Text = "Enter a non negative value";
                e4.Visible = true;
            }
            else
            {
                MessageBox.Show("Only Numbers Are Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                e4.ForeColor = System.Drawing.Color.Red;
                e4.Text = "Enter Numbers Only";
                e4.Visible = true;

            }
        }


        private void placeHolders()
        {

            Design.waterMark(val_txt, "Enter the amount recieved");
            

        }

        private int addPayEmpyt()
        {
            if (oid_cmb.Text == "Select" || string.IsNullOrEmpty(pd_dtp.Text) || string.IsNullOrEmpty(val_txt.Text) || pt_cmb.Text == "Select") 
            {
                e0.Visible = true;

                if (oid_cmb.Text == "Select")
                {
                    e2.ForeColor = System.Drawing.Color.Red;
                    e2.Text = "*";
                    e2.Visible = true;
                }
                else
                    e2.Visible = false;


                if  (string.IsNullOrEmpty(pd_dtp.Text))
                {
                    e5.ForeColor = System.Drawing.Color.Red;
                    e5.Text = "*";
                    e5.Visible = true;
                }
                else
                    e5.Visible = false;

                if (string.IsNullOrEmpty(val_txt.Text))
                {
                    e4.ForeColor = System.Drawing.Color.Red;
                    e4.Text = "*";
                    e4.Visible = true;
                }
                else
                    e4.Visible = false;

                if (pt_cmb.Text == "Select ")
                {
                    e6.ForeColor = System.Drawing.Color.Red;
                    e6.Text = "*";
                    e6.Visible = true;
                }
                else
                    e6.Visible = false;



                return -1;

            }
            else
            {
                e0.Visible = false;
                e1.Visible = false;
                e2.Visible = false;
                e3.Visible = false;
                e4.Visible = false;
                e6.Visible = false;
                
                return 0;
            }
        }

        private void addPayEmptyErr()
        {
            MessageBox.Show("Please Fill Required Fields !", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            e0.ForeColor = System.Drawing.Color.Red;
            e0.Text = "Required Fields *";

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (addPayEmpyt()== -1 )
            {
                addPayEmptyErr();
            }
            else
            {
                addPayDet();
            }
        }


        private void addPayDet()
        {
            conn.DBopen();
            decimal rup = Convert.ToDecimal(val_txt.Text) * Currency.getCurrencyRate("USD", "LKR");

            try
            {
                conn.SqlQuery("INSERT INTO GmntPayment ([payment_id],[ord_id],[buyer_code],[val_USD],[val_LKR],[paydate],[payment_terms]) values ('" + pid_txt.Text + "','" + oid_cmb.Text + "','" + bc_txt.Text + "','" + val_txt.Text + "','"+ rup +"','" + Convert.ToDateTime(pd_dtp.Text) + "','" + pt_cmb.Text + "')");
                conn.InsQryEx();
                MessageBox.Show("Added  Successfully ");
                ClearTextBoxes();
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

        private void clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
           
            

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

            oid_cmb.Text = "Select";
            pt_cmb.Text = "Select";
            
            try
            {
                autoIncriment(pid_txt, "SELECT MAX(payment_id) FROM GmntPayment");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
           
        }

     
    }
}
