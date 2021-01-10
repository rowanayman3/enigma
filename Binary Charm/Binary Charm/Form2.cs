using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Charm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textnum.Text);
            lblbin.Text = Convert.ToString(num, 2);
            lbloct.Text = Convert.ToString(num, 8);
            lblhex.Text = Convert.ToString(num, 16);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lbloct.Text = "";
            lblbin.Text = "";
            lblhex.Text = "";
            textnum.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.DarkRed;
        }
    }
}
