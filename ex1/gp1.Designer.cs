namespace ex1
{
    partial class gp1
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
            this.tbox1 = new System.Windows.Forms.TextBox();
            this.tbox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsend1 = new System.Windows.Forms.Button();
            this.put1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.put2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbox1
            // 
            this.tbox1.Location = new System.Drawing.Point(57, 61);
            this.tbox1.Name = "tbox1";
            this.tbox1.Size = new System.Drawing.Size(169, 20);
            this.tbox1.TabIndex = 0;
            this.tbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox2
            // 
            this.tbox2.Location = new System.Drawing.Point(57, 134);
            this.tbox2.Name = "tbox2";
            this.tbox2.Size = new System.Drawing.Size(169, 20);
            this.tbox2.TabIndex = 1;
            this.tbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "y";
            // 
            // btnsend1
            // 
            this.btnsend1.Location = new System.Drawing.Point(98, 177);
            this.btnsend1.Name = "btnsend1";
            this.btnsend1.Size = new System.Drawing.Size(75, 23);
            this.btnsend1.TabIndex = 4;
            this.btnsend1.Text = "คำนวณ";
            this.btnsend1.UseVisualStyleBackColor = true;
            this.btnsend1.Click += new System.EventHandler(this.btnsend1_Click);
            // 
            // put1
            // 
            this.put1.BackColor = System.Drawing.Color.Navy;
            this.put1.ForeColor = System.Drawing.Color.White;
            this.put1.Location = new System.Drawing.Point(54, 256);
            this.put1.Name = "put1";
            this.put1.Size = new System.Drawing.Size(172, 23);
            this.put1.TabIndex = 5;
            this.put1.Text = "0";
            this.put1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "ค่าที่ 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "ไปเมนูพิเศษ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "ค่าที่ 2";
            // 
            // put2
            // 
            this.put2.BackColor = System.Drawing.Color.Navy;
            this.put2.ForeColor = System.Drawing.Color.White;
            this.put2.Location = new System.Drawing.Point(54, 297);
            this.put2.Name = "put2";
            this.put2.Size = new System.Drawing.Size(172, 23);
            this.put2.TabIndex = 8;
            this.put2.Text = "0";
            this.put2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.put2.Click += new System.EventHandler(this.put2_Click);
            // 
            // gp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 340);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.put2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.put1);
            this.Controls.Add(this.btnsend1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox2);
            this.Controls.Add(this.tbox1);
            this.Name = "gp1";
            this.Text = "gp1";
            this.Load += new System.EventHandler(this.gp1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox1;
        private System.Windows.Forms.TextBox tbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsend1;
        private System.Windows.Forms.Label put1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label put2;
    }
}