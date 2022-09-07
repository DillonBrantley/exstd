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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbox1.Text.Trim())) 
            {
                lbox1.Items.Add(tbox1.Text.Trim());
                tbox1.Text = "";
                tbox1.Focus();
            }
        }

        private void btnrm_Click(object sender, EventArgs e)
        {
            if (lbox1.SelectedIndex != -1)
            {
                lbox1.Items.RemoveAt(lbox1.SelectedIndex);
            }
            else 
            {
                MessageBox.Show("ไม่มีข้อมูล", "EROR");
                }
            
        }

        private void btncl_Click(object sender, EventArgs e)
        {
            lbox1.Items.Clear();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

    }
}
