using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                Form9.RTDC = 1;
            }
            else if (rb2.Checked)
            {
                Form9.RTDC = 0.95;
            }
            else if (rb3.Checked)
            {
                Form9.RTDC = 0.9;
            }
            this.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
