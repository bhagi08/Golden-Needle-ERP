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
    public partial class FP : Form
    {
        private DBconnect conn;
        public FP(string samId, string ord, string buyCode)
        {
            InitializeComponent();
            conn = new DBconnect();
            loadPicture(samId);
            loadLabels(samId, ord, buyCode);


        }

        private void FP_Load(object sender, EventArgs e)
        {

        }

        private void loadPicture(string name)
        {
            conn.DBopen();
           try
           {

               conn.SqlQuery("SELECT [fashion_sketch] FROM Gmnt_sample WHERE [Samp_id] = '" + name + "'");
                SqlDataReader re =conn.SelQryRedEx();
                re.Read();
               string img = (string)(re[0]);
               
                FP_pb.Image = Image.FromFile(img);
                FP_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                FP_pb.BorderStyle = BorderStyle.None;
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
           }
           conn.DBclose();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadLabels(string samId,string oId, string buyCode)
        {
            conn.DBopen();
            sam2_lbl.Text = samId;
            oId2_lbl.Text = oId;
            conn.SqlQuery("SELECT company FROM Orders O INNER JOIN Buyer B ON O.buyer_code=B.buyer_code WHERE O.buyer_code = '" + buyCode + "'");
            SqlDataReader red = conn.SelQryRedEx();
            red.Read();
            string buyer = (string)(red[0]);
            conn.DBclose();
            buy2_lbl.Text = buyer;


        }

        private void oId_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
