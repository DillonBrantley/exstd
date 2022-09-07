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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbox1.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(tbox2.Text.Trim()))
                {
                    if (!string.IsNullOrEmpty(tbox3.Text.Trim()))
                    {
                        ListViewItem listv1 = default(ListViewItem);
                        /* รหัสสินค้่า */
                        listv1 = lv1.Items.Add(tbox1.Text.Trim());
                        /* ชื่อสินค้า */
                        listv1.SubItems.Add(tbox2.Text.Trim());
                        /* ราคาสินค้า */
                        listv1.SubItems.Add(tbox3.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("ไม่ได้กรอกราคาสินค้า", "ERROR");
                    }

                }
                else
                {
                    MessageBox.Show("ไม่ได้กรอกชื่อสินค้า", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("ไม่ได้กรอกรหัสสินค้า", "ERROR");
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            lv1.View = View.Details;
        }

        private void btnrm_Click(object sender, EventArgs e)
        {
            lv1.Items.Remove(lv1.SelectedItems[0]);
        }

        private void btncl_Click(object sender, EventArgs e)
        {
            lv1.Items.Clear();
        }

    }
}
