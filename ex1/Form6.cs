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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            lb1.Items.Add("hello");
            lb1.Items.Add("it");
            lb1.Items.Add("me");
            /*lb1.SelectedIndex = 0;*/
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string st = lb1.SelectedItem.ToString();
            MessageBox.Show(st, "รายการที่เลือก");
            
        }

    }
}
