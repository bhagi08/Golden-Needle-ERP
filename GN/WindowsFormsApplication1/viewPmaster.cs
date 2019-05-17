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
    public partial class viewPmaster : Form
    {
        private DBconnect conn;
        public viewPmaster(string pId, string oId, string bc, string val_usd, string val_lkr, string pdate, string pt)
        {
            InitializeComponent();
            conn = new DBconnect();
            loadCombo();

            pid_txt.Text = pId;
            oid_cmb.Text = oId;
            bc_txt.Text = bc;
            val_txt.Text = val_usd;
            pd_dtp.Text = pdate;
            pt_cmb.Text = pt;
            lkr_txt.Text = val_lkr;

            pid_txt.Tag = 0;
            oid_cmb.Tag = 0;
            bc_txt.Tag = 0;
            val_txt.Tag = 0;
            pd_dtp.Tag= 0;
            pt_cmb.Tag = 0;

        }

        private void viewPmaster_Load(object sender, EventArgs e)
        {

        }


        private void loadCombo()
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


        public void Update()
        {
            if (Convert.ToInt32(pid_txt.Tag) != 0 || Convert.ToInt32(oid_cmb.Tag) != 0 || Convert.ToInt32(bc_txt.Tag) != 0 || Convert.ToInt32(val_txt.Tag) != 0 || Convert.ToInt32( pd_dtp.Tag) != 0 || Convert.ToInt32( pt_cmb.Tag) != 0)
            {
                

                conn.DBopen();

                try
                {
                    conn.SqlQuery("UPDATE GmntPayment SET [ord_id] = '" + oid_cmb.Text + "',[buyer_code] = '" + bc_txt.Text + "',[val_USD] = '" + val_txt.Text + "',[val_LKR] = '" +lkr_txt.Text +"',[paydate] = '" + Convert.ToDateTime(pd_dtp.Text) + "',[payment_terms] = '" + pt_cmb.Text + "' WHERE [payment_id] = '" + pid_txt.Text + "'");
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
              
            }
        }

        private void RefreshGrid()
        {
            // string samId = viewSgrid.SelectedRows[0].Cells["Sample ID"].Value.ToString();

            viewPay frm = new viewPay();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void oid_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ComboBox)sender).Tag = 10;
        }

        private void val_txt_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).Tag = 10;
        }

        private void pd_dtp_ValueChanged(object sender, EventArgs e)
        {
            ((DateTimePicker)sender).Tag = 10;
        }

        private void pt_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ComboBox)sender).Tag = 10;
        }

        
    }
}
