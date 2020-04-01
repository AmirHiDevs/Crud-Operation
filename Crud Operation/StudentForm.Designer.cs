namespace Crud_Operation
{
    partial class StudentForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtn = new System.Windows.Forms.Button();
            this.upbtn = new System.Windows.Forms.Button();
            this.rmbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgv.Location = new System.Drawing.Point(0, 124);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 3, 4, 6);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 42;
            this.dgv.Size = new System.Drawing.Size(345, 150);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(51, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(89, 20);
            this.txtid.TabIndex = 2;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(51, 51);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(163, 20);
            this.txtname.TabIndex = 4;
            this.txtname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(51, 77);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(163, 20);
            this.txtmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail";
            // 
            // cbtn
            // 
            this.cbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbtn.Location = new System.Drawing.Point(258, 19);
            this.cbtn.Name = "cbtn";
            this.cbtn.Size = new System.Drawing.Size(75, 23);
            this.cbtn.TabIndex = 7;
            this.cbtn.Text = "Create";
            this.cbtn.UseVisualStyleBackColor = true;
            this.cbtn.Click += new System.EventHandler(this.cbtn_Click);
            // 
            // upbtn
            // 
            this.upbtn.Location = new System.Drawing.Point(258, 48);
            this.upbtn.Name = "upbtn";
            this.upbtn.Size = new System.Drawing.Size(75, 23);
            this.upbtn.TabIndex = 8;
            this.upbtn.Text = "Update";
            this.upbtn.UseVisualStyleBackColor = true;
            this.upbtn.Click += new System.EventHandler(this.upbtn_Click);
            // 
            // rmbtn
            // 
            this.rmbtn.Location = new System.Drawing.Point(258, 76);
            this.rmbtn.Name = "rmbtn";
            this.rmbtn.Size = new System.Drawing.Size(75, 23);
            this.rmbtn.TabIndex = 9;
            this.rmbtn.Text = "Remove";
            this.rmbtn.UseVisualStyleBackColor = true;
            this.rmbtn.Click += new System.EventHandler(this.rmbtn_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 274);
            this.Controls.Add(this.rmbtn);
            this.Controls.Add(this.upbtn);
            this.Controls.Add(this.cbtn);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students Form";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cbtn;
        private System.Windows.Forms.Button upbtn;
        private System.Windows.Forms.Button rmbtn;
    }
}