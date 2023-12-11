namespace PharmacySystem
{
    partial class admin_update
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
            this.AddChekBox = new System.Windows.Forms.ListBox();
            this.SearchChkBox = new System.Windows.Forms.ListBox();
            this.ScientificSerch = new System.Windows.Forms.RadioButton();
            this.BrandNameSerch = new System.Windows.Forms.RadioButton();
            this.Proceed = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddChekBox
            // 
            this.AddChekBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddChekBox.FormattingEnabled = true;
            this.AddChekBox.ItemHeight = 25;
            this.AddChekBox.Location = new System.Drawing.Point(399, 66);
            this.AddChekBox.Name = "AddChekBox";
            this.AddChekBox.Size = new System.Drawing.Size(396, 129);
            this.AddChekBox.TabIndex = 17;
            // 
            // SearchChkBox
            // 
            this.SearchChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchChkBox.FormattingEnabled = true;
            this.SearchChkBox.ItemHeight = 25;
            this.SearchChkBox.Location = new System.Drawing.Point(6, 66);
            this.SearchChkBox.Name = "SearchChkBox";
            this.SearchChkBox.Size = new System.Drawing.Size(387, 129);
            this.SearchChkBox.TabIndex = 16;
            // 
            // ScientificSerch
            // 
            this.ScientificSerch.AutoSize = true;
            this.ScientificSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScientificSerch.Location = new System.Drawing.Point(33, 32);
            this.ScientificSerch.Name = "ScientificSerch";
            this.ScientificSerch.Size = new System.Drawing.Size(153, 24);
            this.ScientificSerch.TabIndex = 15;
            this.ScientificSerch.TabStop = true;
            this.ScientificSerch.Text = "Scientific Serch";
            this.ScientificSerch.UseVisualStyleBackColor = true;
            // 
            // BrandNameSerch
            // 
            this.BrandNameSerch.AutoSize = true;
            this.BrandNameSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandNameSerch.Location = new System.Drawing.Point(194, 32);
            this.BrandNameSerch.Name = "BrandNameSerch";
            this.BrandNameSerch.Size = new System.Drawing.Size(127, 24);
            this.BrandNameSerch.TabIndex = 14;
            this.BrandNameSerch.TabStop = true;
            this.BrandNameSerch.Text = "Brand Serch";
            this.BrandNameSerch.UseVisualStyleBackColor = true;
            // 
            // Proceed
            // 
            this.Proceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proceed.Location = new System.Drawing.Point(326, 367);
            this.Proceed.Name = "Proceed";
            this.Proceed.Size = new System.Drawing.Size(138, 56);
            this.Proceed.TabIndex = 13;
            this.Proceed.Text = "Update";
            this.Proceed.UseVisualStyleBackColor = true;
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.FormattingEnabled = true;
            this.SearchBar.Location = new System.Drawing.Point(326, 27);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(414, 33);
            this.SearchBar.TabIndex = 12;
            this.SearchBar.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "enter the number of boxes ";
            // 
            // admin_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddChekBox);
            this.Controls.Add(this.SearchChkBox);
            this.Controls.Add(this.ScientificSerch);
            this.Controls.Add(this.BrandNameSerch);
            this.Controls.Add(this.Proceed);
            this.Controls.Add(this.SearchBar);
            this.Name = "admin_update";
            this.Text = "admin_update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox AddChekBox;
        private System.Windows.Forms.ListBox SearchChkBox;
        private System.Windows.Forms.RadioButton ScientificSerch;
        private System.Windows.Forms.RadioButton BrandNameSerch;
        private System.Windows.Forms.Button Proceed;
        private System.Windows.Forms.ComboBox SearchBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}