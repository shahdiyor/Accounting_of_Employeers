﻿namespace AOE_Accounting_of_Employees_
{
    partial class Add
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
            this.fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_sev = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.MaskedTextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pos = new System.Windows.Forms.ComboBox();
            this.sex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name";
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fname.Location = new System.Drawing.Point(75, 38);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(188, 20);
            this.fname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Position";
            // 
            // add_sev
            // 
            this.add_sev.AutoSize = true;
            this.add_sev.Location = new System.Drawing.Point(14, 172);
            this.add_sev.Name = "add_sev";
            this.add_sev.Size = new System.Drawing.Size(82, 17);
            this.add_sev.TabIndex = 8;
            this.add_sev.Text = "Add several";
            this.add_sev.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.WhiteSmoke;
            this.date.Location = new System.Drawing.Point(75, 69);
            this.date.Mask = "00/00/0000";
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(187, 20);
            this.date.TabIndex = 12;
            this.date.ValidatingType = typeof(System.DateTime);
            // 
            // num
            // 
            this.num.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num.Location = new System.Drawing.Point(75, 9);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(188, 20);
            this.num.TabIndex = 14;
            this.num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID";
            // 
            // pos
            // 
            this.pos.FormattingEnabled = true;
            this.pos.Location = new System.Drawing.Point(75, 128);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(187, 21);
            this.pos.TabIndex = 15;
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Location = new System.Drawing.Point(75, 98);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(187, 21);
            this.sex.TabIndex = 16;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(274, 193);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_sev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox add_sev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox date;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pos;
        private System.Windows.Forms.ComboBox sex;
    }
}