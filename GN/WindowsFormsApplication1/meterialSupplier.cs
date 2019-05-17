using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project001
{
    public partial class meterialSupplier : Form
    {
        public meterialSupplier()
        {
            InitializeComponent();
        }
        SqlConnection CON = new SqlConnection("Data Source=CSASWCHATHURANG;Initial Catalog=Golden;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

        private void btnback_Click(object sender, EventArgs e)
        {
            new details().Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(tbname.Text=="")
            {
                MessageBox.Show("Please Enter Name..");
                tbname.Focus();
            }
          
            else if (tbaddress.Text == "")
            {
                MessageBox.Show("Please Enter Address..");
                tbaddress.Focus();
            }
            else if (tbcountry.Text == "")
            {
                MessageBox.Show("Please Enter Country..");
                tbcountry.Focus();
            }
            else if (tbagent.Text == "")
            {
                MessageBox.Show("Please Enter Agent..");
                tbagent.Focus();
            }
            else if (tbphone.Text == "")
            {
                MessageBox.Show("Please Enter Phone no..");
            }
                 
            else if (tbemail.Text == "")
            {
                MessageBox.Show("Please Enter Email..");
                tbemail.Focus();
            }

            else if (tbemail.Text.IndexOf('@') == -1 || tbemail.Text.IndexOf("com") == -1)
            {
                MessageBox.Show("Invalide Email Address");
            }

            else 
            {
                CON.Open();
                SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO meterialsup (id,name,address,country,agent,phone,email) VALUES ('" + textBox1.Text + "','" + tbname.Text + "','" + tbaddress.Text + "','" + tbcountry.Text + "','" + tbagent.Text + "','" + tbphone.Text + "','" + tbemail.Text + "')", CON);
                SDA.SelectCommand.ExecuteNonQuery();
                CON.Close();
                MessageBox.Show(" Saved successfull...");
            }
          
           // tbname.Clear();
            //tbphone.Clear();
            //tbagent.Clear();
            //tbcountry.Clear();
           // tbaddress.Clear();
            //tbphone.Clear();
            //tbemail.Clear();
            //textBox1.Clear();
           
        }

      

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndashBoard_MouseHover(object sender, EventArgs e)
        {
            btndashBoard.Image = Properties.Resources.dashboard3;

        }

        private void btndashBoard_MouseLeave(object sender, EventArgs e)
        {
            btndashBoard.Image = Properties.Resources.dashboard2;
        }

        private void btnsupplierDetails_MouseHover(object sender, EventArgs e)
        {
            btnsupplierDetails.Image = Properties.Resources.sd2;
        }

        private void btnsupplierDetails_MouseLeave(object sender, EventArgs e)
        {
            btnsupplierDetails.Image = Properties.Resources.sd;
        }

        private void btnpurchaseDetails_MouseHover(object sender, EventArgs e)
        {
            btnpurchaseDetails.Image = Properties.Resources.pi2;
        }

        private void btnpurchaseDetails_MouseLeave(object sender, EventArgs e)
        {
            btnpurchaseDetails.Image = Properties.Resources.pi;
        }

        private void btngenarateReport_MouseHover(object sender, EventArgs e)
        {
            btngenarateReport.Image = Properties.Resources.gr2;
        }

        private void btngenarateReport_MouseLeave(object sender, EventArgs e)
        {
            btngenarateReport.Image = Properties.Resources.gr;
        }

        private void btndashBoard_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void btnsupplierDetails_Click(object sender, EventArgs e)
        {
            new details().Show();
            this.Hide();
        }

        private void btnpurchaseDetails_Click(object sender, EventArgs e)
        {
            new invoice().Show();
            this.Hide();
        }

        private void btngenarateReport_Click(object sender, EventArgs e)
        {
            new Report().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar >'9')
            {
                MessageBox.Show("Please Enter Number only..");
                e.KeyChar = (char)0;
            }
        }

        private void meterialSupplier_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
