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
    public partial class addSamples:Form
    {
        string imgLoc = "";
        decimal i = 100;
        DBconnect conn;
        public addSamples()
        {
            InitializeComponent();
            Design.curve(this);
            timer1.Start();
            conn = new DBconnect();
            

           /* string temp = Login.profPic;
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

        private void addSamples_frm_Load(object sender, EventArgs e)
        {
            conn.DBopen();
            autoIncriment(sam_txt, "SELECT MAX(samp_id) FROM Gmnt_sample");
            string x = "Please select an order";
            oid_cmb.Text = x;
            placeHolders();

            
            try
            {
                
                conn.SqlQuery("SELECT ord_id FROM Orders ");
                foreach (DataRow dr in conn.SelQryEx().Rows)
                {
                    oid_cmb.Items.Add(dr[0].ToString());
                }

            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            conn.DBclose();
            
            
          
         

            
           
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

        private void fcBrw_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
                dlg.Title = "Insert Picture";

                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    fp_pb.ImageLocation = imgLoc;
                    fp_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    fp_pb.BorderStyle = BorderStyle.None;
                    fp_txt.Text = imgLoc;
                }
            }

            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void addSa_btn_Click(object sender, EventArgs e)
        {
            
            if(addSamEmpty() == -1)
            {
                addSamEmptyErr();
            }
            else if (Currency.getCurrencyRate("USD", "LKR") == 0)
            {
                MessageBox.Show("Please check your internet connection !", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                insertData();
            }
        }

        private void codt_txt_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void placeHolders()
        {
           
            Design.waterMark(cost_txt,"Enter the cost of sample");
            Design.waterMark(fp_txt, "Please select a picture");
           
        }

        private void oid_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

           if (oid_cmb.Text == "Please select an order")
            {
                bc_txt.Enabled = false;
            }
            else if (oid_cmb.Text == null)
            {
                bc_txt.Enabled = false;
            }
            else 
            {
                bc_txt.Enabled = true;
            }
        }

        private void oid_cmb_TextChanged(object sender, EventArgs e)
        {
            if (oid_cmb.Text == " ")
            {
                bc_txt.Enabled = false;
            }
        }

        private void loadBc()
        {

        }

        private void oid_cmb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            conn.DBopen();
            try
            {
                string oid = oid_cmb.Text;
                conn.SqlQuery("SELECT buyer_code FROM Orders WHERE ord_id  = '" + oid + "'");
                string buyer_code =(string) conn.cmd.ExecuteScalar();

                bc_txt.Text = buyer_code;

            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            conn.DBclose();
        }
       
        public static void autoIncriment(Control t,string sqlQuery)
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
                    t.Text = "SA00001";
                }
                else
                {
                    string temp = value.Substring(2,5);
                    int number = Convert.ToInt32(temp);
                    number++;
                    string result = number.ToString().PadLeft(5, '0');
                    t.Text = "SA" + result.ToString();
                }
            }

            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            conn.DBclose();
        }

        private void cost_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 46)
            {


                e.Handled = false;
               
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

        private void cost_txt_Leave(object sender, EventArgs e)
        {
            /*if(cost_txt.Text != "")
            {
                double tmp = Convert.ToDouble(cost_txt.Text);
                CultureInfo info = new CultureInfo("en-US");
                cost_txt.Text = tmp.ToString("c", info);
            }*/
            
        }

        private int addSamEmpty()
        {
            if (oid_cmb.Text == "Please select an order" || cost_txt.Text == "")
            {

                if (oid_cmb.Text == "Please select an order")
                {
                    e2.Text = "*";
                    e2.ForeColor = Color.Red;
                    e2.Visible = true;


                }
                else
                    e2.Visible = false;

                if (cost_txt.Text == "")
                {
                    e4.Text = "*";
                    e4.ForeColor = Color.Red;
                    e4.Visible = true;


                }
                else
                    e4.Visible = false;

                return -1;
            }

            else
            {
                e0.Visible = false;
                e2.Visible = false;
                e4.Visible = false;
                return -999;
            }

        }

        private void addSamEmptyErr()
        {
            MessageBox.Show("Please Fill Required Fields !", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            e0.ForeColor = System.Drawing.Color.Red;
            e0.Text = "Required Fields *";
            e0.Visible = true;
        }

        private void clrSa_btn_Click(object sender, EventArgs e)
        {
          
        }

        private void insertData()
        {
            conn.DBopen();
            try
            {
                decimal rup = Convert.ToDecimal(cost_txt.Text)             *     Currency.getCurrencyRate("USD", "LKR");
                conn.SqlQuery("INSERT INTO Gmnt_sample ([Samp_id], [ord_id], [Buyer_code], [cost_USD], [cost_LKR], [Delivered_date],[fashion_sketch] ) VALUES ('" + sam_txt.Text + "','" + oid_cmb.Text + "','" + bc_txt.Text + "','" + cost_txt.Text + "','" + rup + "','" + Convert.ToDateTime(date_dtp.Text) + "','" + fp_txt.Text + "')");
                conn.InsQryEx();
                MessageBox.Show("Added  Successfully ");
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.DBclose();
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
        
        public void storeImg()
        {
            conn.DBopen();
            decimal rup = Convert.ToDecimal(cost_txt.Text) * Currency.getCurrencyRate("USD", "LKR");
            conn.SqlQuery("INSERT INTO Gmnt_sample ([Samp_id], [ord_id], [Buyer_code], [cost_USD], [cost_LKR], [Delivered_date], [samp_status],[fp_path],[bp_path], [front_picture] ) VALUES ('" + sam_txt.Text + "','" + oid_cmb.Text + "','" + bc_txt.Text + "','" + cost_txt.Text + "','" + rup + "','" + Convert.ToDateTime(date_dtp.Text) + "','" + 1 + "','" + fp_txt.Text + "',@fPic,@bPic)");
                String strBLOBFilePath = fp_txt.Text;//Modify this path as needed.
               


              
                    //Read jpg into file stream, and from there into Byte array.
                    FileStream fsBLOBFile = new FileStream(strBLOBFilePath, FileMode.Open, FileAccess.Read);
                    Byte[] bytBLOBData = new Byte[fsBLOBFile.Length];
                    fsBLOBFile.Read(bytBLOBData, 0, bytBLOBData.Length);
                    fsBLOBFile.Close();


                     

                    //Create parameter for insert command and add to SqlCommand object.
                    SqlParameter prm = new SqlParameter("@fPic", SqlDbType.VarBinary, bytBLOBData.Length, ParameterDirection.Input, false,
                                0, 0, null, DataRowVersion.Current, bytBLOBData);
                    
                    conn.cmd.Parameters.Add(prm);
              
                conn.InsQryEx();
                MessageBox.Show("Added  Successfully ");
                conn.DBclose();

            
           
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
