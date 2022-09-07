namespace ex1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.okbtn = new System.Windows.Forms.Button();
            this.tbox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox4 = new System.Windows.Forms.TextBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ตัวเลขที่ 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(92, 213);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(75, 23);
            this.okbtn.TabIndex = 4;
            this.okbtn.Text = "OK";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // tbox1
            // 
            this.tbox1.Location = new System.Drawing.Point(126, 46);
            this.tbox1.Name = "tbox1";
            this.tbox1.Size = new System.Drawing.Size(100, 20);
            this.tbox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ตัวเลขที่ 2";
            // 
            // tbox2
            // 
            this.tbox2.Location = new System.Drawing.Point(126, 88);
            this.tbox2.Name = "tbox2";
            this.tbox2.Size = new System.Drawing.Size(100, 20);
            this.tbox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(71, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbox4
            // 
            this.tbox4.Location = new System.Drawing.Point(126, 135);
            this.tbox4.Name = "tbox4";
            this.tbox4.Size = new System.Drawing.Size(100, 20);
            this.tbox4.TabIndex = 9;
            this.tbox4.Text = "0";
            this.tbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(13, 53);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(15, 14);
            this.cb1.TabIndex = 12;
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(13, 95);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(15, 14);
            this.cb2.TabIndex = 13;
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.tbox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox1);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.TextBox tbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox4;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
    }
}

