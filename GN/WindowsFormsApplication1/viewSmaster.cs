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


namespace WindowsFormsApplication1
{
    public partial class viewSmaster : Form
    {
        private DBconnect conn;
        private string imgLoc;
        private  static string sId;
        private static int  chkUsd;
        private static int ordId;
        private static int dateTag;
        private static int picTag;
        private static int staTag;
        public viewSmaster(string samId, string OId,string date,string usd, string lkr,string stat)
        {
            conn = new DBconnect();
            InitializeComponent();
            new ToolTip().SetToolTip(pic_pb, "Double click to add a new picture");
            
            loadCombo();
            loadPicture(samId);
          
            sam_txt.Text = samId;
            oid_cmb.Text = OId;
            date_dtp.Text = date;
            costUsd_txt.Text = usd;
            costLkr_txt.Text = lkr;
            sat_cmb.Text = stat;
            sId = samId;
            costUsd_txt.Tag = 0;
            oid_cmb.Tag = 0;
            date_dtp.Tag = 0;
            pic_pb.Tag = 0;
            sat_cmb.Tag = 0;



        }

        private void viewSmaster_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            
            viewSamples frm = new viewSamples();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private  void loadCombo()
        {
            conn.DBopen();
            try
            {
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
            conn.DBclose();
            ((ComboBox)sender).Tag = 10;

        }

        private void costLkr_txt_MouseClick(object sender, MouseEventArgs e)
        {

        }

     
        private void Ctrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void costUsd_txt_KeyUp(object sender, KeyEventArgs e)
        {
            decimal rup = Convert.ToDecimal(costUsd_txt.Text) * Currency.getCurrencyRate("USD", "LKR");
            costLkr_txt.Text = rup.ToString("F");
        }


        private void loadPicture(string name)
        {
            conn.DBopen();
            try
            {
                
                conn.SqlQuery("SELECT [fashion_sketch] FROM Gmnt_sample WHERE [Samp_id] = '" + name + "'");
                SqlDataReader re = conn.SelQryRedEx();
                re.Read();
                string img = (string)(re[0]);
                pic_pb.Image = Image.FromFile(img);
                pic_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pic_pb.BorderStyle = BorderStyle.None;
                imgLoc = img;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            conn.DBclose();

        }



        private  void upd_btn_Click(object sender, EventArgs e)
        {
            
            Update();
            
                
        }

        private void pic_pb_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
                dlg.Title = "Insert Picture";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pic_pb.ImageLocation = imgLoc;
                    pic_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic_pb.BorderStyle = BorderStyle.None;
                    
                }
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        public  void Update()
        {
            if ((costUsd_txt.Tag != null && Convert.ToInt32(costUsd_txt.Tag) != 0) || Convert.ToInt32(oid_cmb.Tag) != 0 || Convert.ToInt32(date_dtp.Tag) != 0 || Convert.ToInt32(pic_pb.Tag) != 0 || Convert.ToInt32(sat_cmb.Tag) != 0)
            {
                chkUsd = Convert.ToInt32(costUsd_txt.Tag);
                ordId = Convert.ToInt32(oid_cmb.Tag);
                dateTag = Convert.ToInt32(date_dtp.Tag);
                picTag = Convert.ToInt32(pic_pb.Tag);
                staTag = Convert.ToInt32(sat_cmb.Tag);

                conn.DBopen();

                try
                {
                    conn.SqlQuery("UPDATE Gmnt_sample SET [ord_id] = '" + oid_cmb.Text + "',[Buyer_code] = '" + bc_txt.Text + "',[cost_USD] = '" + costUsd_txt.Text + "',[cost_LKR] = '" + costLkr_txt.Text + "',[Delivered_date] = '" + Convert.ToDateTime(date_dtp.Text) + "',[samp_status] = '"+sat_cmb.Text +"',[fashion_sketch] = '" + imgLoc + "' WHERE [Samp_id] = '" + sam_txt.Text + "'");
                    conn.InsQryEx();
                    MessageBox.Show("Updated Successfully !");
                    RefreshGrid();
                    
                   
                    




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

            else
            {
                MessageBox.Show("Please slect a field");
                chkUsd = 0;
                ordId = 0;
                dateTag = 0;
                picTag = 0;
                staTag = 0;
            }
        }

        private   void RefreshGrid()
        {
           // string samId = viewSgrid.SelectedRows[0].Cells["Sample ID"].Value.ToString();

            viewSamples frm = new viewSamples(); 
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
            
            
        }



        public DataGridView viewSgrid { get; set; }
        

        public static string ID()
        {
            return sId;
        }

        private void  costUsd_txt_TextChanged(object sender, EventArgs e)
        {

            ((TextBox)sender).Tag = 10;
           
           
            
        }

      
        public static int CheckUsd()
        {
           
            return chkUsd;
        }

        public static int CheckOid()
        {
            return ordId;
        }

        public static int CheckDate()
        {
            return dateTag;
        }

        public static int CheckPic()
        {
            return picTag;
        }

        public static int CheckSat()
        {
            return staTag;
        }

        private void date_dtp_ValueChanged(object sender, EventArgs e)
        {
            ((DateTimePicker)sender).Tag = 10;
        }

        private void pic_pb_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            ((PictureBox)sender).Tag = 10;
        }

        private void sat_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ComboBox)sender).Tag = 10;
        }

    }
}
