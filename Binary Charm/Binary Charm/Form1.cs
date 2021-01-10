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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 b = new Form2();
            b.ShowDialog();


            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            

            Binary_Charm.MainWindow v = new MainWindow(true);
            v.Visibility = System.Windows.Visibility.Visible;

            v.ShowDialog();
            
           
        }
    }
}
