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
    public partial class gp2 : Form
    {
        public gp2()
        {
            InitializeComponent();
        }

        public string x, y;


        private void gp2_Load(object sender, EventArgs e)
        {
            p1.Text = x;
            p2.Text = y;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            double X, Y, ANS;
            X = Convert.ToDouble(p1.Text);
            Y = Convert.ToDouble(p2.Text);
            ANS = X + Y;
            ans.Text = ANS.ToString();
        }

        private void m_Click(object sender, EventArgs e)
        {
            double X, Y, ANS;
            X = Convert.ToDouble(p1.Text);
            Y = Convert.ToDouble(p2.Text);
            ANS = X - Y;
            ans.Text = ANS.ToString();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            double X, Y, ANS;
            X = Convert.ToDouble(p1.Text);
            Y = Convert.ToDouble(p2.Text);
            ANS = X * Y;
            ans.Text = ANS.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gp1.rt1 = ans.Text;
            this.Close();
        }
    }
}
