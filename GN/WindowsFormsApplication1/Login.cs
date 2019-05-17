using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {

        private static string pic;
        private static string name;
        public Login()
        {
            InitializeComponent();
            pw_txt.MaxLength = 20;
           
            
           
                  

        }

        private void close_btn_MouseHover(object sender, EventArgs e)
        {
            close_btn.ForeColor = Color.FromArgb(255,255,255);
        }

        private void close_btn_MouseLeave(object sender, EventArgs e)
        {
            close_btn.ForeColor = Color.FromArgb(0,0,0);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    
        

     

        private void un_txt_MouseClick(object sender, MouseEventArgs e)
        {
            un_pnl.BackColor = Color.FromArgb(245, 245, 245);
            unli_pnl.BackColor = Color.FromArgb(232, 126, 4);
            pw_pnl.BackColor = Color.FromArgb(255, 255, 255);
            pwli_pnl.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void pw_txt_MouseClick(object sender, MouseEventArgs e)
        {
            pw_pnl.BackColor = Color.FromArgb(245,245,245);
            pwli_pnl.BackColor = Color.FromArgb(232,126,4);
            un_pnl.BackColor = Color.FromArgb(255, 255, 255);
            unli_pnl.BackColor = Color.FromArgb(255, 255, 255);
        
        }

        private void un_pb_MouseClick(object sender, MouseEventArgs e)
        {
            un_pnl.BackColor = Color.FromArgb(245, 245, 245);
            unli_pnl.BackColor = Color.FromArgb(232, 126, 4);
            pw_pnl.BackColor = Color.FromArgb(255, 255, 255);
            pwli_pnl.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void pw_pb_MouseClick(object sender, MouseEventArgs e)
        {
            pw_pnl.BackColor = Color.FromArgb(245, 245, 245);
            pwli_pnl.BackColor = Color.FromArgb(232, 126, 4);
            un_pnl.BackColor = Color.FromArgb(255, 255, 255);
            unli_pnl.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Login_Load(object sender, EventArgs e)
        {
          this.ActiveControl = logo_lbl;
          un_txt.Text = "User Name";
          un_txt.ForeColor = Color.FromArgb(218,214,218);
          pw_txt.Text = "Password";
          pw_txt.ForeColor = Color.FromArgb(218,214,218);
          
       

        }

        private void lg_btn_Click(object sender, EventArgs e)
        {
            
            pic = Log.getProfPic(un_txt, pw_txt);
            name = Log.getName(un_txt, pw_txt);
            Log.login(un_txt, pw_txt, Error_lbl,this,un_pb,pw_pb);
            
            
           
        }

        private void un_txt_Enter(object sender, EventArgs e)
        {
            Design.placeHolderIn(un_txt, "User Name");

        }

        private void pw_txt_Leave(object sender, EventArgs e)
        {
            Design.placeHolderOut(pw_txt,"Password");
        }

        private void un_txt_Leave(object sender, EventArgs e)
        {
            Design.placeHolderOut(un_txt, "User Name");
            
        }

        private void pw_txt_Enter(object sender, EventArgs e)
        {
            Design.placeHolderIn(pw_txt, "Password");
            if (un_txt.Text == "User Name")
            {
                MessageBox.Show("Please Enter the User name ");
                un_pb.Image = Resources.userRed;
                this.ActiveControl = un_txt;
                pw_txt.Text = "Password";
                pw_txt.ForeColor = Color.FromArgb(218, 214, 218);
            }
           

        }

        private void Login_MouseClick(object sender, MouseEventArgs e)
        {
            Design.placeHolderOut(un_txt, "User Name");
            Design.placeHolderOut(pw_txt, "Password");

            pw_pnl.BackColor = Color.FromArgb(255, 255, 255);
            pwli_pnl.BackColor = Color.FromArgb(255, 255, 255);
            un_pnl.BackColor = Color.FromArgb(255, 255, 255);
            unli_pnl.BackColor = Color.FromArgb(255, 255, 255);
            this.ActiveControl = logo_lbl;
        }

        private void pw_txt_KeyDown(object sender, KeyEventArgs e)
        {
            pw_txt.PasswordChar = '•';
            pw_txt.Font = new Font("Microsoft segoe UI", 20f);
        }

        public static string profPic
        {
            
            get // this makes you to access value in form2
            {
                return pic;
            }
        }

        public static string uName
        {

            get // this makes you to access value in form2
            {
                return name;
            }
        }  
        

        
      }
    }

