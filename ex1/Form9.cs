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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        public static double RTF, RTD, RTDC, ANS;
        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 F10 = new Form10();
            F10.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 F11 = new Form11();
            F11.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 F12 = new Form12();
            F12.ShowDialog();
        }

        private void tbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          ANS =  (RTF + RTD) * RTDC;
          tbox1.Text = ANS.ToString();
        }
    }
}
