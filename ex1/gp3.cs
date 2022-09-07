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
    public partial class gp3 : Form
    {
        public gp3()
        {
            InitializeComponent();
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb2.Items.Add(lb1.Text);
        }

        private void lb1_DoubleClick(object sender, EventArgs e)
        {
            foreach (var item in lb1.Items) 
            {
                lb2.Items.Add(item);
            }
        }

        private void lb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb2.SelectedIndex != -1)
            {
                if (MessageBox.Show("ต้องการจะลบใช่ไหม?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lb2.Items.RemoveAt(lb2.SelectedIndex);
                }
            }   
        }

        private void lb2_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการจะลบใช่ไหม?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lb2.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double price = 0;
            foreach (var item in lb2.Items)
            {
                string sp = item.ToString();
                string[] p = sp.Split(' ');
                price += Convert.ToDouble(p[1]);
            }
            lable3.Text = price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gp1.rt2 = lable3.Text;
            this.Close();
        }
    }
}
