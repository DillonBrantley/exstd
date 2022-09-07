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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            int Tbox6 = 0, Tbox7 = 0, Tbox8 = 0, Ans = 0;
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
            Ans = (10 * Tbox6) + (14 * Tbox7) + (20 * Tbox8);
            ansbox.Text = Ans.ToString();
            Form9.RTD = Convert.ToDouble(ansbox.Text);
            this.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
