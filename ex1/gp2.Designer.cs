namespace ex1
{
    partial class gp2
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
            this.p1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.m = new System.Windows.Forms.Button();
            this.cross = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.LightSlateGray;
            this.p1.ForeColor = System.Drawing.Color.White;
            this.p1.Location = new System.Drawing.Point(93, 37);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 23);
            this.p1.TabIndex = 0;
            this.p1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.LightSlateGray;
            this.p2.ForeColor = System.Drawing.Color.White;
            this.p2.Location = new System.Drawing.Point(93, 102);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 22);
            this.p2.TabIndex = 1;
            this.p2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "x";
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(22, 174);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(103, 174);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(75, 23);
            this.m.TabIndex = 7;
            this.m.Text = "-";
            this.m.UseVisualStyleBackColor = true;
            this.m.Click += new System.EventHandler(this.m_Click);
            // 
            // cross
            // 
            this.cross.Location = new System.Drawing.Point(184, 174);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(75, 23);
            this.cross.TabIndex = 8;
            this.cross.Text = "x";
            this.cross.UseVisualStyleBackColor = true;
            this.cross.Click += new System.EventHandler(this.cross_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "ผลลัพธ์";
            // 
            // ans
            // 
            this.ans.BackColor = System.Drawing.Color.LightSlateGray;
            this.ans.ForeColor = System.Drawing.Color.White;
            this.ans.Location = new System.Drawing.Point(93, 233);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(100, 22);
            this.ans.TabIndex = 9;
            this.ans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(103, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "return";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 305);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.cross);
            this.Controls.Add(this.m);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Name = "gp2";
            this.Text = "gp2";
            this.Load += new System.EventHandler(this.gp2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button m;
        private System.Windows.Forms.Button cross;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.Button button4;
    }
}