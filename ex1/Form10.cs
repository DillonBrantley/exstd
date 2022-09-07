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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }


        private void okbtn_Click(object sender, EventArgs e)
        {
            int Tbox1 = 0, Tbox2 = 0, Tbox3 = 0, Tbox4 = 0, Tbox5 = 0, Ans = 0;
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
            Ans = (50 * Tbox1) + (50 * Tbox2) + (50 * Tbox3) + (50 * Tbox4) + (50 * Tbox5);
            ansbox.Text = Ans.ToString();
            Form9.RTF = Convert.ToDouble(ansbox.Text);
            this.Close();
        }
    }
}
