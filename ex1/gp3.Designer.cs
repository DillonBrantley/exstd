namespace ex1
{
    partial class gp3
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
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.lable3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 18;
            this.lb1.Items.AddRange(new object[] {
            "เป็ดย่างตัวละ 600 บาท",
            "เป็ดย่างจานเล็ก 250 บาท",
            "เป็ดย่างจานใหญ่ 350 บาท",
            "หมูแดงจานเล็ก 200 บาท",
            "หมูแดงจานใหญ่ 300 บาท",
            "หมูกรอบจานเล็ก 250 บาท",
            "หมูกรอบจานใหญ่ 350 บาท"});
            this.lb1.Location = new System.Drawing.Point(38, 40);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(187, 238);
            this.lb1.TabIndex = 0;
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.lb1_SelectedIndexChanged);
            this.lb1.DoubleClick += new System.EventHandler(this.lb1_DoubleClick);
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(295, 40);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(187, 238);
            this.lb2.TabIndex = 1;
            this.lb2.SelectedIndexChanged += new System.EventHandler(this.lb2_SelectedIndexChanged);
            this.lb2.DoubleClick += new System.EventHandler(this.lb2_DoubleClick);
            // 
            // lable3
            // 
            this.lable3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lable3.ForeColor = System.Drawing.Color.White;
            this.lable3.Location = new System.Drawing.Point(216, 298);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(100, 23);
            this.lable3.TabIndex = 2;
            this.lable3.Text = "0";
            this.lable3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "คำนวณ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gp3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 386);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "gp3";
            this.Text = "gp3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}