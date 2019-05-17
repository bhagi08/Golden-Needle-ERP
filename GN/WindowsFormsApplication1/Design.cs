using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Design
    {
        TextBox t;
        public Design()
        {
        }

        public static void HoverMouseBut(Button name, Image img, int w, int h)
        {
            name.Image = img;
            name.ForeColor = Color.FromArgb(232, 126, 4);
            name.Size = new Size(w, h);
            name.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            name.TextAlign = ContentAlignment.BottomCenter;
            name.ImageAlign = ContentAlignment.MiddleCenter;
            Design.curve(name);
        }

        public static  void LeaveMouseBut(Button name, Image img, int w, int h)
        {
            name.Image = img;
            name.ForeColor = Color.FromArgb(255, 255, 255);
            name.Size = new Size(w, h);
            name.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            name.TextAlign = ContentAlignment.BottomCenter;
            name.ImageAlign = ContentAlignment.MiddleCenter;
            Design.curve(name);
        }


         [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect, // x-coordinate of upper-left corner
           int nTopRect, // y-coordinate of upper-left corner
           int nRightRect, // x-coordinate of lower-right corner
           int nBottomRect, // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public static void curve(Form name)
        {

            
            name.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, name.Width, name.Height, 20, 20));
        }

        public static void curve(Button name)
        {

            
            name.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, name.Width, name.Height, 15, 15));
        }


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public static void waterMark(TextBox t,String txt)
        {
            SendMessage(t.Handle, 0x1501, 2, txt);
        }

        public static void waterMark(ComboBox t, String txt)
        {
            SendMessage(t.Handle, 0x1501, 2, txt);
        }

      

        public static void placeHolderIn(TextBox t,String txt)
        {
           
            if (t.Text == txt)
            {
                t.Text = "";
                t.ForeColor = Color.FromArgb(0, 0, 0);
                
            }
       
        }

        public static void placeHolderOut(TextBox t,String txt)
        {
            if (t.Text == "")
            {
                t.Text = txt;
                t.ForeColor = Color.FromArgb(218, 214, 218);
            }
        }

        

        
    }
}
