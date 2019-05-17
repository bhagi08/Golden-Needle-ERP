using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project001
{
    public partial class getdepartment : Form
    {
        public getdepartment()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new invoice().Show();
            this.Hide();
        }
    }
}
