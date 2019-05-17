using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
  
    public partial class addCli:Form
    {
        private DBconnect con;
        
        public addCli()
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
            dash frm = new dash();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void viewo_frm_Load(object sender, EventArgs e)
        {
            
            phc_txt.TextAlign = HorizontalAlignment.Center;
            RegionInfo country = new RegionInfo(new CultureInfo("en-US", false).LCID);
            List<string> countryNames = new List<string>();
            foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                country = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                countryNames.Add(country.DisplayName.ToString());
            }

            IEnumerable nameAdded = countryNames.OrderBy(names => names).Distinct();

            foreach (string item in nameAdded)
            {
                cntry_cmb.Items.Add(item);
                con.DBopen();

                try
                {
                   
                    /* con.SqlQuery("SELECT nicename FROM country ORDER BY nicename ASC");
                     foreach (DataRow dr in con.SelQryEx().Rows)
                     {
                         cntry_txt.Items.Add(dr[0].ToString());
                     }*/



                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                con.DBclose();
            }
        }

        private void ov_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ar_lbl_Click(object sender, EventArgs e)
        {

        }

        private void cl_Click(object sender, EventArgs e)
        {
            clients frm = new clients();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();

        }

        private void cntry_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.DBopen();
            try
            {
                string code = cntry_cmb.Text;
                con.SqlQuery("SELECT phonecode FROM country where nicename = @parameter ");
                con.cmd.Parameters.AddWithValue("@parameter", code);
                Int32 no = (Int32)con.cmd.ExecuteScalar();

               
                phc_txt.Text = "+" + no.ToString();
                phc_txt.Enabled = false;


            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.DBclose();
           
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (addCliEmpty() == -1)
            {
                addCliEmptyErr();
            }
            
            else if (Validation.valEml(eml_txt.Text) ==false)
           {
               MessageBox.Show("Invalid Email !", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               e11.ForeColor = System.Drawing.Color.Red;
               e11.Text = "Enter a Valid Email Address";
           }
            else if (Validation.valTel(phn_txt) == false)
            {
                MessageBox.Show("Invalid Phone Number !", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e9.ForeColor = System.Drawing.Color.Red;
                e9.Text = "Enter a 10 Digit Phone Number !";
            }
            else
            {


                con.DBopen();
                try
                {
                    con.SqlQuery("INSERT INTO Buyer ([buyer_code],[company],[address],[country],[email]) values ('" + bc_txt.Text + "','" + cmp_txt.Text + "','" + st1_txt.Text + "','" + cntry_cmb.Text + "','" + eml_txt.Text + "')");
                    con.InsQryEx();
                    con.SqlQuery("INSERT INTO BuyerPhone ([buyer_code],[phone]) values (@code,@num)");
                    con.cmd.Parameters.AddWithValue("@code", bc_txt.Text);
                    con.cmd.Parameters.Add("@num", SqlDbType.Text);
                    con.cmd.Parameters["@num"].Value = phc_txt.Text +' '+ phn_txt.Text;
                    con.InsQryEx();
                    MessageBox.Show("Added  Successfully ");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.DBclose();
            }
         
        }
        private int addCliEmpty()
        {
            if (string.IsNullOrEmpty(bc_txt.Text) || string.IsNullOrEmpty(cmp_txt.Text) || string.IsNullOrEmpty(st1_txt.Text) || string.IsNullOrEmpty(cty_txt.Text) || string.IsNullOrEmpty(re_txt.Text) || string.IsNullOrEmpty(zp_txt.Text) || string.IsNullOrEmpty(phc_txt.Text) || string.IsNullOrEmpty(phn_txt.Text) || cntry_cmb.Text == "Select a country" || string.IsNullOrEmpty(eml_txt.Text))
            {
               

                if (string.IsNullOrEmpty(bc_txt.Text))
                {
                    e1.ForeColor = System.Drawing.Color.Red;
                    e1.Text = "*";
                }
                else
                    e1.Text = "";

                if (string.IsNullOrEmpty(cmp_txt.Text))
                {
                    e2.ForeColor = System.Drawing.Color.Red;
                    e2.Text = "*";
                }
                else
                    e2.Text = "";

                if (string.IsNullOrEmpty(st1_txt.Text))
                {
                    e3.ForeColor = System.Drawing.Color.Red;
                    e3.Text = "*";
                }
                else
                    e3.Text = "";

                if (string.IsNullOrEmpty(cty_txt.Text))
                {
                    e4.ForeColor = System.Drawing.Color.Red;
                    e4.Text = "*";
                }
                else
                    e4.Text = "";

                if (string.IsNullOrEmpty(re_txt.Text))
                {
                    e5.ForeColor = System.Drawing.Color.Red;
                    e5.Text = "*";
                }
                else
                    e5.Text = "";


                if (string.IsNullOrEmpty(zp_txt.Text))
                {
                    e7.ForeColor = System.Drawing.Color.Red;
                    e7.Text = "*";
                }
                else
                    e7.Text = "";

                if (string.IsNullOrEmpty(phc_txt.Text))
                {
                    e10.ForeColor = System.Drawing.Color.Red;
                    e10.Text = "*";
                }
                else
                    e10.Text = "";

                if (string.IsNullOrEmpty(phn_txt.Text))
                {
                    e9.ForeColor = System.Drawing.Color.Red;
                    e9.Text = "*";
                }
                else
                    e9.Text = "";
                if (string.IsNullOrEmpty(eml_txt.Text))
                {
                    e11.ForeColor = System.Drawing.Color.Red;
                    e11.Text = "*";
                }
                else
                    e11.Text = "";
                if (cntry_cmb.Text == "Select a country")
                {
                    e8.ForeColor = System.Drawing.Color.Red;
                    e8.Text = "*";
                }
                else
                    e8.Text = "";

                return -1;

            }
            else
            {
                eMain.Visible = false;
                e1.Visible = false;
                e2.Visible = false;
                e3.Visible = false;
                e4.Visible = false;
                e5.Visible = false;
                e7.Visible = false;
                e8.Visible = false;
                e9.Visible = false;
                return 0;
            }

        }
        private void addCliEmptyErr()
        {
            MessageBox.Show("Please Fill Required Fields !", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            eMain.ForeColor = System.Drawing.Color.Red;
            eMain.Text = "Required Fields *";
        }

        private void st2_txt_MouseClick(object sender, MouseEventArgs e)
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
            cntry_cmb.Text = "Select a county";
        }

        private void phn_txt_KeyPress(object sender, KeyPressEventArgs e)
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
                e9.ForeColor = System.Drawing.Color.Red;
                e9.Text = "Enter Numbers Only";
                e9.Visible = true;

            }
        }

        private void Demo_Click(object sender, EventArgs e)
        {
            bc_txt.Text = "JOBMAN";
            cmp_txt.Text = "Jobman Workwear AB";
            st1_txt.Text = "Jupitervagen 2A";
            st2_txt.Text = "Upplands Vasby";
            cty_txt.Text = "Stockholm";
            re_txt.Text = "Uppland";
            zp_txt.Text = "11130";
            cntry_cmb.Text = "Sweden";
            eml_txt.Text = "LarsPerslid@gmail.com";
            phn_txt.Text = "878640000";
        }

        private void sam_Click(object sender, EventArgs e)
        {
            sample frm = new sample();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void phn_txt_TextChanged(object sender, EventArgs e)
        {

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
