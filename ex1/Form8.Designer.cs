namespace ex1
{
    partial class Form8
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
            this.lv1 = new System.Windows.Forms.ListView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnrm = new System.Windows.Forms.Button();
            this.btncl = new System.Windows.Forms.Button();
            this.tbox1 = new System.Windows.Forms.TextBox();
            this.tbox2 = new System.Windows.Forms.TextBox();
            this.tbox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv1.FullRowSelect = true;
            this.lv1.GridLines = true;
            this.lv1.HoverSelection = true;
            this.lv1.Location = new System.Drawing.Point(33, 29);
            this.lv1.MultiSelect = false;
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(532, 263);
            this.lv1.TabIndex = 0;
            this.lv1.UseCompatibleStateImageBehavior = false;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(602, 31);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 30);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnrm
            // 
            this.btnrm.Location = new System.Drawing.Point(602, 73);
            this.btnrm.Name = "btnrm";
            this.btnrm.Size = new System.Drawing.Size(100, 30);
            this.btnrm.TabIndex = 2;
            this.btnrm.Text = "Remove";
            this.btnrm.UseVisualStyleBackColor = true;
            this.btnrm.Click += new System.EventHandler(this.btnrm_Click);
            // 
            // btncl
            // 
            this.btncl.Location = new System.Drawing.Point(602, 116);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(100, 30);
            this.btncl.TabIndex = 3;
            this.btncl.Text = "Clear";
            this.btncl.UseVisualStyleBackColor = true;
            this.btncl.Click += new System.EventHandler(this.btncl_Click);
            // 
            // tbox1
            // 
            this.tbox1.Location = new System.Drawing.Point(33, 333);
            this.tbox1.Name = "tbox1";
            this.tbox1.Size = new System.Drawing.Size(532, 20);
            this.tbox1.TabIndex = 4;
            // 
            // tbox2
            // 
            this.tbox2.Location = new System.Drawing.Point(33, 381);
            this.tbox2.Name = "tbox2";
            this.tbox2.Size = new System.Drawing.Size(532, 20);
            this.tbox2.TabIndex = 5;
            // 
            // tbox3
            // 
            this.tbox3.Location = new System.Drawing.Point(33, 434);
            this.tbox3.Name = "tbox3";
            this.tbox3.Size = new System.Drawing.Size(532, 20);
            this.tbox3.TabIndex = 6;
            this.tbox3.Text = "0";
            this.tbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "รหัสสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ชื่อสินค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ราคาสินค้า";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "รหัสสินค้า";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ชื่อสินค้า";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ราคา";
            this.columnHeader3.Width = 50;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 490);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox3);
            this.Controls.Add(this.tbox2);
            this.Controls.Add(this.tbox1);
            this.Controls.Add(this.btncl);
            this.Controls.Add(this.btnrm);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lv1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnrm;
        private System.Windows.Forms.Button btncl;
        private System.Windows.Forms.TextBox tbox1;
        private System.Windows.Forms.TextBox tbox2;
        private System.Windows.Forms.TextBox tbox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}