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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            int Tbox1 = 0, Tbox2 = 0, Tbox3 = 0, Tbox4 = 0, Tbox5 = 0, Tbox6 = 0, Tbox7 = 0, Tbox8 = 0, Ans = 0;
            if (cb1.Checked == true) 
            {
                Tbox1 = Convert.ToInt32(tbox1.Text);
            }
            if (cb2.Checked == true)
            {
                Tbox2 = Convert.ToInt32(tbox2.Text);
            }
            if (cb3.Checked == true)
            {
                Tbox3 = Convert.ToInt32(tbox3.Text);
            }
            if (cb4.Checked == true)
            {
                Tbox4 = Convert.ToInt32(tbox4.Text);
            }
            if (cb5.Checked == true)
            {
                Tbox5 = Convert.ToInt32(tbox5.Text);
            }
            if (cb6.Checked == true)
            {
                Tbox6 = Convert.ToInt32(tbox6.Text);
            }
            if (cb7.Checked == true)
            {
                Tbox7 = Convert.ToInt32(tbox7.Text);
            }
            if (cb8.Checked == true)
            {
                Tbox8 = Convert.ToInt32(tbox8.Text);
            }
            Ans = (50 * Tbox1) + (50 * Tbox2) + (50 * Tbox3) + (50 * Tbox4) + (50 * Tbox5) + (7 * Tbox6) + (14 * Tbox7) + (20 * Tbox8);
            ansbox.Text = Ans.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

    }
}
