namespace ex1
{
    partial class Form7
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
            this.lbox1 = new System.Windows.Forms.ListBox();
            this.tbox1 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnrm = new System.Windows.Forms.Button();
            this.btncl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbox1
            // 
            this.lbox1.FormattingEnabled = true;
            this.lbox1.Location = new System.Drawing.Point(53, 50);
            this.lbox1.Name = "lbox1";
            this.lbox1.Size = new System.Drawing.Size(364, 368);
            this.lbox1.TabIndex = 0;
            // 
            // tbox1
            // 
            this.tbox1.Location = new System.Drawing.Point(471, 50);
            this.tbox1.Multiline = true;
            this.tbox1.Name = "tbox1";
            this.tbox1.Size = new System.Drawing.Size(260, 368);
            this.tbox1.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(759, 50);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnrm
            // 
            this.btnrm.Location = new System.Drawing.Point(759, 102);
            this.btnrm.Name = "btnrm";
            this.btnrm.Size = new System.Drawing.Size(75, 23);
            this.btnrm.TabIndex = 3;
            this.btnrm.Text = "Remove";
            this.btnrm.UseVisualStyleBackColor = true;
            this.btnrm.Click += new System.EventHandler(this.btnrm_Click);
            // 
            // btncl
            // 
            this.btncl.Location = new System.Drawing.Point(759, 154);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(75, 23);
            this.btncl.TabIndex = 4;
            this.btncl.Text = "Clear";
            this.btncl.UseVisualStyleBackColor = true;
            this.btncl.Click += new System.EventHandler(this.btncl_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 461);
            this.Controls.Add(this.btncl);
            this.Controls.Add(this.btnrm);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.tbox1);
            this.Controls.Add(this.lbox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox1;
        private System.Windows.Forms.TextBox tbox1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnrm;
        private System.Windows.Forms.Button btncl;
    }
}