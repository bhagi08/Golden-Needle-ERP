using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;
using AccountingManagementSysem.Properties;
using Package_and_shipment.Properties;
using Project001.Properties;
using Employee.Properties;
using Manufacturing_Management_System.Properties;

namespace WindowsFormsApplication1
{
    public class Log
    {
        


        public static void login(TextBox un, TextBox pw, Label l, Form lgfrm, PictureBox p1, PictureBox p2)
        {
            DBconnect  conn = new DBconnect();
            conn.DBopen();
            
            try
             {
                conn.SqlQuery("SELECT user_name,password,desig from login WHERE user_name = '"+un.Text+"' AND password ='"+pw.Text+"' ");
                DataTable dt = conn.SelQryEx();
                SqlDataReader re = conn.SelQryRedEx();
                re.Read();

                if (un.Text == "User Name" || pw.Text == "Password")
                {
                    MessageBox.Show("Please enter the user name and the password");
                    p1.Image = Resources.userRed;
                    p2.Image = Resources.locked_padlockR;
                    un.Text = "User Name";
                    un.ForeColor = Color.FromArgb(218, 214, 218);
                    pw.Text = "Password";
                    pw.ForeColor = Color.FromArgb(218, 214, 218);
                }

                else
                {
                    if (dt.Rows.Count == 0)
                    {

                        MessageBox.Show("Invalid Username or Password.");
                        un.Clear();
                        pw.Clear();
                        l.Text = "Wrong username or password.Try again.";
                        l.ForeColor = Color.FromArgb(232, 17, 35);
                        l.Visible = true;
                        lgfrm.ActiveControl = un;
                        p1.Image = Resources.userRed;
                        p2.Image = Resources.locked_padlockR;


                    }
                    else
                    {
                        l.Visible = false;
                        if (re.HasRows)
                        {
                            string desig = (string)(re[2]);

                            if (desig == "Sales")
                            {
                                
                                dash frm = new dash();
                                lgfrm.Visible = false;
                                frm.ShowDialog();


                            }

                            else if (desig == "Account")
                            {

                                AccountingManagementSysem.Hm frm = new AccountingManagementSysem.Hm();
                               lgfrm.Visible = false;
                                frm.ShowDialog();
                            }

                            else if (desig == "Manu")
                            {

                                Manufacturing_Management_System.manudashboard frm = new Manufacturing_Management_System.manudashboard();
                                lgfrm.Visible = false; 
                                frm.ShowDialog();
                            }
                            else if (desig == "Purch")
                            {

                                Project001.viewinvoice frm = new Project001.viewinvoice();
                                lgfrm.Visible = false;
                                frm.ShowDialog();
                            }
                            else if (desig == "Ship")
                            {

                                Package_and_shipment.homepage frm = new Package_and_shipment.homepage();
                                lgfrm.Visible = false;
                                frm.ShowDialog();
                            }
                            else if (desig == "Main")
                            {

                                AccountingManagementSysem.Hm frm = new AccountingManagementSysem.Hm();
                                lgfrm.Visible = false;
                                frm.ShowDialog();
                            }
                        }

                    }
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

        public static string getProfPic(TextBox un, TextBox pw)
        {
            string img;
            DBconnect conn = new DBconnect();
            conn.DBopen();
            try
            {
                conn.SqlQuery("SELECT img from login WHERE user_name = '" + un.Text + "' AND password ='" + pw.Text + "' ");
                DataTable dt = conn.SelQryEx();
                SqlDataReader re = conn.SelQryRedEx();
                re.Read();
                img = (string)(re[0]);
                return img;    
               
               
            }
            catch(Exception er)
            {
               
                return null;
            }
            finally
            {
                conn.DBclose();
            }
            
        }

        public static string getName(TextBox un, TextBox pw)
        {
            string name;
            DBconnect conn = new DBconnect();
            conn.DBopen();
            try
            {
                conn.SqlQuery("SELECT user_name from login WHERE user_name = '" + un.Text + "' AND password ='" + pw.Text + "' ");
                DataTable dt = conn.SelQryEx();
                SqlDataReader re = conn.SelQryRedEx();
                re.Read();
                name = (string)(re[0]);
                return name;


            }
            catch (Exception er)
            {

                return null;
            }
            finally
            {
                conn.DBclose();
            }
        }

        
        
    }

   

}
