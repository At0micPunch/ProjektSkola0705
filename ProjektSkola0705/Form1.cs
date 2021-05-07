using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektSkola0705
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello_world");  ///To je blbost
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello_home");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello_pp");
            MessageBox.Show("a jsem tady taky");
        }
    }
}
