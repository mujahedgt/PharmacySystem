namespace PharmacySystem
{
    partial class users_control
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
            this.users_list = new System.Windows.Forms.ListBox();
            this.ScientificSerch = new System.Windows.Forms.RadioButton();
            this.BrandNameSerch = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // users_list
            // 
            this.users_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_list.FormattingEnabled = true;
            this.users_list.ItemHeight = 24;
            this.users_list.Location = new System.Drawing.Point(366, 12);
            this.users_list.Name = "users_list";
            this.users_list.Size = new System.Drawing.Size(329, 100);
            this.users_list.TabIndex = 0;
            // 
            // ScientificSerch
            // 
            this.ScientificSerch.AutoSize = true;
            this.ScientificSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScientificSerch.Location = new System.Drawing.Point(383, 150);
            this.ScientificSerch.Name = "ScientificSerch";
            this.ScientificSerch.Size = new System.Drawing.Size(103, 24);
            this.ScientificSerch.TabIndex = 17;
            this.ScientificSerch.TabStop = true;
            this.ScientificSerch.Text = "employee";
            this.ScientificSerch.UseVisualStyleBackColor = true;
            // 
            // BrandNameSerch
            // 
            this.BrandNameSerch.AutoSize = true;
            this.BrandNameSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandNameSerch.Location = new System.Drawing.Point(565, 150);
            this.BrandNameSerch.Name = "BrandNameSerch";
            this.BrandNameSerch.Size = new System.Drawing.Size(75, 24);
            this.BrandNameSerch.TabIndex = 16;
            this.BrandNameSerch.TabStop = true;
            this.BrandNameSerch.Text = "admin";
            this.BrandNameSerch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(315, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "----note----: make a popup message if the admin want to change\r\nthe state";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(373, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "----note----: make a popup message if the admin want \r\nadd a user";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(538, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 26);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "password";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(366, 269);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 26);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "user name";
            // 
            // users_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 430);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScientificSerch);
            this.Controls.Add(this.BrandNameSerch);
            this.Controls.Add(this.users_list);
            this.Name = "users_control";
            this.Text = "user control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox users_list;
        private System.Windows.Forms.RadioButton ScientificSerch;
        private System.Windows.Forms.RadioButton BrandNameSerch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}