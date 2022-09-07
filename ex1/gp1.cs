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
    public partial class gp1 : Form
    {
        public gp1()
        {
            InitializeComponent();
        }

        public static string rt1,rt2;

        private void btnsend1_Click(object sender, EventArgs e)
        {
            gp2 send1 = new gp2();
            if (tbox1.Text != "")
            {
                if (tbox2.Text != "")
                {
                    send1.x = tbox1.Text;
                    send1.y = tbox2.Text;
                    send1.ShowDialog();
                    put1.Text = rt1;
                }
                else 
                {
                    MessageBox.Show("ยังไม่ได้ใส่ตัวแปร y", "Error");
                }
            }
            else
            {
                MessageBox.Show("ยังไม่ได้ใส่ตัวแปร x", "Error");
            }
            put1.Text = rt1;
        }


        private void gp1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gp3 ngp = new gp3();
            ngp.ShowDialog();
            put2.Text = rt2;
            
        }

        private void put2_Click(object sender, EventArgs e)
        {

        }
    }
}
