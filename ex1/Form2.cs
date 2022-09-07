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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            int Tbox1, Tbox2, Ans;
            Tbox1 = Convert.ToInt32(tbox1.Text);
            Tbox2 = Convert.ToInt32(tbox2.Text);
            
 

            if(Tbox1 < 10)
            {
                 Ans = 10 * Tbox2;
                 MessageBox.Show("เด็ก " + Tbox2.ToString() + " คน" + "\nผู้ใหญ่ 0 คน"+"\nคนแก่ 0 คน" + "\nรวมเป็นเงิน "+Ans.ToString() + "บาท", "คำตอบ");
            }

             else if(Tbox1 <= 60)
            {
                 Ans = 40 * Tbox2;
                 MessageBox.Show("เด็ก 0 คน " + "\nผู้ใหญ่ " + Tbox2.ToString() + "คน"+"\nคนแก่ 0 คน" + "\nรวมเป็นเงิน " + Ans.ToString() + "บาท", "คำตอบ");
            }
                
             else
            {

                Ans = 0 * Tbox2;
                MessageBox.Show("เด็ก 0 คน " + "\nผู้ใหญ่ 0 คน" + "\nคนแก่"  + Tbox2.ToString() + " คน" + "\nรวมเป็นเงิน " + Ans.ToString() + "บาท", "คำตอบ");
            }
            

            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
