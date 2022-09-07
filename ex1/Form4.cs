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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tbox1_TextChanged(object sender, EventArgs e)
        {
            int Tbox1, Tbox2, Tbox3, Tbox4, Tbox5, Tbox6, Tbox7, Tbox8, Ans;
            Tbox2 = Convert.ToInt32(tbox2.Text);
            Tbox3 = Convert.ToInt32(tbox3.Text);
            Tbox4 = Convert.ToInt32(tbox4.Text);
            Tbox5 = Convert.ToInt32(tbox5.Text);
            Tbox6 = Convert.ToInt32(tbox6.Text);
            Tbox7 = Convert.ToInt32(tbox7.Text);
            Tbox8 = Convert.ToInt32(tbox8.Text);
            if (tbox1.Text == "")
            {
                Tbox1 = 0;
                
            }
            else 
            {
                Tbox1 = Convert.ToInt32(tbox1.Text);
            }
            Ans = (50 * Tbox1) + (50 * Tbox2) + (50 * Tbox3) + (50 * Tbox4) + (50 * Tbox5) + (7 * Tbox6) + (14 * Tbox7) + (20 * Tbox8);
            ansbox.Text = Ans.ToString();
        }

        private void tbox2_TextChanged(object sender, EventArgs e)
        {
            int Tbox1, Tbox2, Tbox3, Tbox4, Tbox5, Tbox6, Tbox7, Tbox8, Ans;
            Tbox1 = Convert.ToInt32(tbox1.Text);
            Tbox3 = Convert.ToInt32(tbox3.Text);
            Tbox4 = Convert.ToInt32(tbox4.Text);
            Tbox5 = Convert.ToInt32(tbox5.Text);
            Tbox6 = Convert.ToInt32(tbox6.Text);
            Tbox7 = Convert.ToInt32(tbox7.Text);
            Tbox8 = Convert.ToInt32(tbox8.Text);
            if (tbox2.Text == "")
            {
                Tbox2 = 0;

            }
            else
            {
                Tbox2 = Convert.ToInt32(tbox2.Text);
            }
            Ans = (50 * Tbox1) + (50 * Tbox2) + (50 * Tbox3) + (50 * Tbox4) + (50 * Tbox5) + (7 * Tbox6) + (14 * Tbox7) + (20 * Tbox8);
            ansbox.Text = Ans.ToString();
        }

        private void tbox3_TextChanged(object sender, EventArgs e)
        {
            int Tbox1, Tbox2, Tbox3, Tbox4, Tbox5, Tbox6, Tbox7, Tbox8, Ans;
            Tbox1 = Convert.ToInt32(tbox2.Text);
            Tbox2 = Convert.ToInt32(tbox2.Text);
            Tbox4 = Convert.ToInt32(tbox4.Text);
            Tbox5 = Convert.ToInt32(tbox5.Text);
            Tbox6 = Convert.ToInt32(tbox6.Text);
            Tbox7 = Convert.ToInt32(tbox7.Text);
            Tbox8 = Convert.ToInt32(tbox8.Text);
            if (tbox3.Text == "")
            {
                Tbox3 = 0;

            }
            else
            {
                Tbox3 = Convert.ToInt32(tbox3.Text);
            }
            Ans = (50 * Tbox1) + (50 * Tbox2) + (50 * Tbox3) + (50 * Tbox4) + (50 * Tbox5) + (7 * Tbox6) + (14 * Tbox7) + (20 * Tbox8);
            ansbox.Text = Ans.ToString();
        }

        private void tbox4_TextChanged(object sender, EventArgs e)
        {
            int Tbox1, Tbox2, Tbox3, Tbox4, Tbox5, Tbox6, Tbox7, Tbox8, Ans;
            Tbox1 = Convert.ToInt32(tbox1.Text);
            Tbox2 = Convert.ToInt32(tbox2.Text);
            Tbox3 = Convert.ToInt32(tbox3.Text);
            Tbox5 = Convert.ToInt32(tbox5.Text);
            Tbox6 = Convert.ToInt32(tbox6.Text);
            Tbox7 = Convert.ToInt32(tbox7.Text);
            Tbox8 = Convert.ToInt32(tbox8.Text);
            if (tbox4.Text == "")
            {
                Tbox4 = 0;

            }
            else
            {
                Tbox4 = Convert.ToInt32(tbox4.Text);
            }
            Ans = (50 * Tbox1) + (50 * Tbox2) + (50 * Tbox3) + (50 * Tbox4) + (50 * Tbox5) + (7 * Tbox6) + (14 * Tbox7) + (20 * Tbox8);
            ansbox.Text = Ans.ToString();
        }

        private void tbox5_TextChanged(object sender, EventArgs e)
        {
            int Tbox1, Tbox2, Tbox3, Tbox4, Tbox5, Tbox6, Tbox7, Tbox8, Ans;
            Tbox1 = Convert.ToInt32(tbox1.Text);
            Tbox2 = Convert.ToInt32(tbox2.Text);
            Tbox3 = Convert.ToInt32(tbox3.Text);
            Tbox4 = Convert.ToInt32(tbox4.Text);
            Tbox6 = Convert.ToInt32(tbox6.Text);
            Tbox7 = Convert.ToInt32(tbox7.Text);
            Tbox8 = Convert.ToInt32(tbox8.Text);
            if (tbox5.Text == "")
            {
                Tbox5 = 0;

            }
            else
            {
                Tbox5 = Convert.ToInt32(tbox5.Text);
            }
            Ans = (50 * Tbox1) + (50 * Tbox2) + (50 * Tbox3) + (50 * Tbox4) + (50 * Tbox5) + (7 * Tbox6) + (14 * Tbox7) + (20 * Tbox8);
            ansbox.Text = Ans.ToString();
        }

        private void tbox6_TextChanged(object sender, EventArgs e)
        {
            int Tbox1, Tbox2, Tbox3, Tbox4, Tbox5, Tbox6, Tbox7, Tbox8, Ans;
            Tbox1 = Convert.ToInt32(tbox1.Text);
            Tbox2 = Convert.ToInt32(tbox2.Text);
            Tbox3 = Convert.ToInt32(tbox3.Text);
            Tbox4 = Convert.ToInt32(tbox4.Text);
            Tbox5 = Convert.ToInt32(tbox5.Text);
            Tbox7 = Convert.ToInt32(tbox7.Text);
            Tbox8 = Convert.ToInt32(tbox8.Text);
            if (tbox6.Text == "")
            {
                Tbox6 = 0;

            }
            else
            {
                Tbox6 = Convert.ToInt32(tbox6.Text);
            }
            Ans = (50 * Tbox1) + (50 * Tbox2) + (50 * Tbox3) + (50 * Tbox4) + (50 * Tbox5) + (7 * Tbox6) + (14 * Tbox7) + (20 * Tbox8);
            ansbox.Text = Ans.ToString();
        }

        private void tbox7_TextChanged(object sender, EventArgs e)
        {
            int Tbox1, Tbox2, Tbox3, Tbox4, Tbox5, Tbox6, Tbox7, Tbox8, Ans;
            Tbox1 = Convert.ToInt32(tbox1.Text);
            Tbox2 = Convert.ToInt32(tbox2.Text);
            Tbox3 = Convert.ToInt32(tbox3.Text);
            Tbox4 = Convert.ToInt32(tbox4.Text);
            Tbox5 = Convert.ToInt32(tbox5.Text);
            Tbox6 = Convert.ToInt32(tbox6.Text);
            Tbox8 = Convert.ToInt32(tbox8.Text);
            if (tbox7.Text == "")
            {
                Tbox7 = 0;
                
            }
            else 
            {
                Tbox7 = Convert.ToInt32(tbox7.Text);
            }
            Ans = (50 * Tbox1) + (50 * Tbox2) + (50 * Tbox3) + (50 * Tbox4) + (50 * Tbox5) + (7 * Tbox6) + (14 * Tbox7) + (20 * Tbox8);
            ansbox.Text = Ans.ToString();
        }

        private void tbox8_TextChanged(object sender, EventArgs e)
        {
            int Tbox1, Tbox2, Tbox3, Tbox4, Tbox5, Tbox6, Tbox7, Tbox8, Ans;
            Tbox1 = Convert.ToInt32(tbox1.Text);
            Tbox2 = Convert.ToInt32(tbox2.Text);
            Tbox3 = Convert.ToInt32(tbox3.Text);
            Tbox4 = Convert.ToInt32(tbox4.Text);
            Tbox5 = Convert.ToInt32(tbox5.Text);
            Tbox6 = Convert.ToInt32(tbox6.Text);
            Tbox7 = Convert.ToInt32(tbox7.Text);
            if (tbox8.Text == "")
            {
                Tbox8 = 0;
                
            }
            else 
            {
                Tbox8 = Convert.ToInt32(tbox8.Text);
            }
            Ans = (50 * Tbox1) + (50 * Tbox2) + (50 * Tbox3) + (50 * Tbox4) + (50 * Tbox5) + (7 * Tbox6) + (14 * Tbox7) + (20 * Tbox8);
            ansbox.Text = Ans.ToString();
        }
    }
}
