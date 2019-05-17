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
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        String strCn = @"Data Source=DESKTOP-ROF2H0M\BHAGI;Initial Catalog=Golden;Integrated Security=True";
        public int Variable1 { get; private set; }

        private DBconnect conn;
        public Form2()
        {
            InitializeComponent();
           conn = new DBconnect();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String strBLOBFilePath = @"C:\Users\BHAGI\Pictures\Screenshots\b.png";
                FileStream fsBLOBFile = new FileStream(strBLOBFilePath, FileMode.Open, FileAccess.Read);
                Byte[] bytBLOBData = new Byte[fsBLOBFile.Length];
                fsBLOBFile.Read(bytBLOBData, 0, bytBLOBData.Length);
                fsBLOBFile.Close();
                conn.SqlQuery("INSERT INTO login Values('bolt','bole','1234','" + bytBLOBData + "')");
                conn.InsQryEx();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

           
            try
           {
               conn.SqlQuery("SELECT img FROM login");
               SqlDataReader re = conn.SelQryRedEx();
               re.Read();
                if (re.HasRows)
                {
                    string img = (string)(re[0]);

                    pictureBox1.Image = Image.FromFile(img);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BorderStyle = BorderStyle.None;
                }



           }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        public string _textBox1
        {
            get { return textBox1.Text; }
        }


        private void YourmethodToSetVariable()
        {
            Variable1 = 22;
        }


        private void OpenForm2()
        {
        
        }
    }
}
