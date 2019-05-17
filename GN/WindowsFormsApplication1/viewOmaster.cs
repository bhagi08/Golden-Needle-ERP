using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class viewOmaster : Form
    {
        DBconnect con;
        private string trans;
        public viewOmaster(string oId, string bId, string oD, string rsd, string csd, string hs, string ov, string ts, string ar, string ci)
        {
            InitializeComponent();
            con = new DBconnect();

            loadCombo();
            setRadio(ts);

            id_txt.Text = oId;
            oDate.Text = oD;
            rDate.Text = rsd;
            cDate.Text = csd;
            hs_txt.Text = hs;
            ov_txt.Text = ov;
            bc_cmb.Text = bId;
            ar_cmb.Text = ar;
            ci_cmb.Text = ci;


            bc_cmb.Tag = 0;
            oDate.Tag = 0;
            rDate.Tag = 0;
            cDate.Tag = 0;
            hs_txt.Tag = 0;
            yes_rad.Tag = 0;
            no_rad.Tag = 0;
            ci_cmb.Tag = 0;
            ar_cmb.Tag = 0;
            ov_txt.Tag = 0;


        }

        private void viewOmaster_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            viewOrd frm = new viewOrd();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }


        private void loadCombo()
        {
            con.DBopen();
            try
            {
                con.SqlQuery("SELECT buyer_code FROM Buyer ");
                foreach (DataRow dr in con.SelQryEx().Rows)
                {
                    bc_cmb.Items.Add(dr[0].ToString());
                }


                con.SqlQuery("SELECT article FROM Orders ");
                foreach (DataRow dr in con.SelQryEx().Rows)
                {
                    ar_cmb.Items.Add(dr[0].ToString());
                }


                con.SqlQuery("SELECT ci_no FROM Orders ");
                foreach (DataRow dr in con.SelQryEx().Rows)
                {
                    ci_cmb.Items.Add(dr[0].ToString());
                }

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

        private void setRadio(string x)
        {
            if(x == "Yes")
            {
                yes_rad.Checked = true;
            }

            if(x == "No")
            {
                no_rad.Checked = true;
            }
        }

        private void bc_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ComboBox)sender).Tag = 10;
        }

        private void ar_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ComboBox)sender).Tag = 10;
        }

        private void ci_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ComboBox)sender).Tag = 10;
        }

        private void oDate_ValueChanged(object sender, EventArgs e)
        {
            ((DateTimePicker)sender).Tag = 10;
        }

        private void rDate_ValueChanged(object sender, EventArgs e)
        {
            ((DateTimePicker)sender).Tag = 10;
        }

        private void cDate_ValueChanged(object sender, EventArgs e)
        {
            ((DateTimePicker)sender).Tag = 10;
        }

        private void ov_txt_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).Tag = 10;
        }

     

      

        public void Update()
        {
            if (Convert.ToInt32(bc_cmb.Tag) != 0 || Convert.ToInt32(oDate.Tag) != 0 || Convert.ToInt32(rDate.Tag) != 0  || Convert.ToInt32(cDate.Tag) != 0 || Convert.ToInt32(hs_txt.Tag) != 0 || Convert.ToInt32(yes_rad.Tag) != 0 || Convert.ToInt32(no_rad.Tag) != 0 || Convert.ToInt32(ov_txt.Tag) != 0 || Convert.ToInt32(ar_cmb.Tag) != 0 || Convert.ToInt32(ci_cmb.Tag) != 0)
            {
                

                con.DBopen();
                string stat = ChkTrans();

                try
                {
                    con.SqlQuery("UPDATE Orders SET [Buyer_code] = '" + bc_cmb.Text + "',[ord_date] = '" + Convert.ToDateTime(oDate.Text) + "',[req_ship_date] = '" + Convert.ToDateTime(rDate.Text) + "',[conf_ship_date] = '" + Convert.ToDateTime(cDate.Text) + "',[hs_code] = '" + hs_txt.Text + "',[order_val] = '" + ov_txt.Text + "',[trans_split]  = '" + stat +"',[article] = '" + ar_cmb.Text + "',[ci_no] = '" + ci_cmb.Text + "' WHERE [ord_id] = '" + id_txt.Text + "'");
                    con.InsQryEx();
                    MessageBox.Show("Updated Successfully !");
                    RefreshGrid();







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

            else
            {
                MessageBox.Show("Please select a field");
                
            }
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

        private void RefreshGrid()
        {
            // string samId = viewSgrid.SelectedRows[0].Cells["Sample ID"].Value.ToString();

            viewOrd frm = new viewOrd();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();


        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void yes_rad_TextChanged(object sender, EventArgs e)
        {
            ((RadioButton)sender).Tag = 10;
        }

        private void no_rad_TextChanged(object sender, EventArgs e)
        {
            ((RadioButton)sender).Tag = 10;
        }

      
       

    }
}
