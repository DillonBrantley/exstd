namespace ex1
{
    partial class Form5
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
            this.label9 = new System.Windows.Forms.Label();
            this.ansbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nbox1 = new System.Windows.Forms.NumericUpDown();
            this.nbox2 = new System.Windows.Forms.NumericUpDown();
            this.nbox3 = new System.Windows.Forms.NumericUpDown();
            this.nbox4 = new System.Windows.Forms.NumericUpDown();
            this.nbox5 = new System.Windows.Forms.NumericUpDown();
            this.nbox8 = new System.Windows.Forms.NumericUpDown();
            this.nbox7 = new System.Windows.Forms.NumericUpDown();
            this.nbox6 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "รวมเป็นเงิน";
            // 
            // ansbox
            // 
            this.ansbox.Location = new System.Drawing.Point(459, 200);
            this.ansbox.Name = "ansbox";
            this.ansbox.Size = new System.Drawing.Size(100, 20);
            this.ansbox.TabIndex = 86;
            this.ansbox.Text = "0";
            this.ansbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "ชาเย็น 20 บาท";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "โค้ก 14 บาท";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "น้ำเปล่า 7 บาท";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "คะน้าหมูกรอบ 50 บาท";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "ก๋วยเตี๋ยว 50 บาท";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "สุกี้ 50 บาท";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "กระเพรา 50 บาท";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "ข้าวผัด 50 บาท";
            // 
            // nbox1
            // 
            this.nbox1.Location = new System.Drawing.Point(169, 41);
            this.nbox1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbox1.Name = "nbox1";
            this.nbox1.Size = new System.Drawing.Size(120, 20);
            this.nbox1.TabIndex = 88;
            this.nbox1.ValueChanged += new System.EventHandler(this.nbox1_ValueChanged);
            // 
            // nbox2
            // 
            this.nbox2.Location = new System.Drawing.Point(169, 82);
            this.nbox2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbox2.Name = "nbox2";
            this.nbox2.Size = new System.Drawing.Size(120, 20);
            this.nbox2.TabIndex = 89;
            this.nbox2.ValueChanged += new System.EventHandler(this.nbox2_ValueChanged);
            // 
            // nbox3
            // 
            this.nbox3.Location = new System.Drawing.Point(169, 125);
            this.nbox3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbox3.Name = "nbox3";
            this.nbox3.Size = new System.Drawing.Size(120, 20);
            this.nbox3.TabIndex = 90;
            this.nbox3.ValueChanged += new System.EventHandler(this.nbox3_ValueChanged);
            // 
            // nbox4
            // 
            this.nbox4.Location = new System.Drawing.Point(169, 162);
            this.nbox4.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbox4.Name = "nbox4";
            this.nbox4.Size = new System.Drawing.Size(120, 20);
            this.nbox4.TabIndex = 91;
            this.nbox4.ValueChanged += new System.EventHandler(this.nbox4_ValueChanged);
            // 
            // nbox5
            // 
            this.nbox5.Location = new System.Drawing.Point(169, 201);
            this.nbox5.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbox5.Name = "nbox5";
            this.nbox5.Size = new System.Drawing.Size(120, 20);
            this.nbox5.TabIndex = 92;
            this.nbox5.ValueChanged += new System.EventHandler(this.nbox5_ValueChanged);
            // 
            // nbox8
            // 
            this.nbox8.Location = new System.Drawing.Point(474, 125);
            this.nbox8.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbox8.Name = "nbox8";
            this.nbox8.Size = new System.Drawing.Size(120, 20);
            this.nbox8.TabIndex = 95;
            this.nbox8.ValueChanged += new System.EventHandler(this.nbox8_ValueChanged);
            // 
            // nbox7
            // 
            this.nbox7.Location = new System.Drawing.Point(474, 82);
            this.nbox7.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbox7.Name = "nbox7";
            this.nbox7.Size = new System.Drawing.Size(120, 20);
            this.nbox7.TabIndex = 94;
            this.nbox7.ValueChanged += new System.EventHandler(this.nbox7_ValueChanged);
            // 
            // nbox6
            // 
            this.nbox6.Location = new System.Drawing.Point(474, 41);
            this.nbox6.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbox6.Name = "nbox6";
            this.nbox6.Size = new System.Drawing.Size(120, 20);
            this.nbox6.TabIndex = 93;
            this.nbox6.ValueChanged += new System.EventHandler(this.nbox6_ValueChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 261);
            this.Controls.Add(this.nbox8);
            this.Controls.Add(this.nbox7);
            this.Controls.Add(this.nbox6);
            this.Controls.Add(this.nbox5);
            this.Controls.Add(this.nbox4);
            this.Controls.Add(this.nbox3);
            this.Controls.Add(this.nbox2);
            this.Controls.Add(this.nbox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ansbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ansbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nbox1;
        private System.Windows.Forms.NumericUpDown nbox2;
        private System.Windows.Forms.NumericUpDown nbox3;
        private System.Windows.Forms.NumericUpDown nbox4;
        private System.Windows.Forms.NumericUpDown nbox5;
        private System.Windows.Forms.NumericUpDown nbox8;
        private System.Windows.Forms.NumericUpDown nbox7;
        private System.Windows.Forms.NumericUpDown nbox6;

    }
}