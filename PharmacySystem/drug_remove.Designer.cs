namespace PharmacySystem
{
    partial class drug_remove
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
            this.SearchBar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddChekBox
            // 
            this.AddChekBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddChekBox.FormattingEnabled = true;
            this.AddChekBox.ItemHeight = 25;
            this.AddChekBox.Location = new System.Drawing.Point(405, 109);
            this.AddChekBox.Name = "AddChekBox";
            this.AddChekBox.Size = new System.Drawing.Size(391, 229);
            this.AddChekBox.TabIndex = 15;
            this.AddChekBox.SelectedIndexChanged += new System.EventHandler(this.AddChekBox_SelectedIndexChanged);
            // 
            // SearchChkBox
            // 
            this.SearchChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchChkBox.FormattingEnabled = true;
            this.SearchChkBox.ItemHeight = 25;
            this.SearchChkBox.Location = new System.Drawing.Point(12, 109);
            this.SearchChkBox.Name = "SearchChkBox";
            this.SearchChkBox.Size = new System.Drawing.Size(387, 229);
            this.SearchChkBox.TabIndex = 14;
            this.SearchChkBox.SelectedIndexChanged += new System.EventHandler(this.SearchChkBox_SelectedIndexChanged);
            // 
            // ScientificSerch
            // 
            this.ScientificSerch.AutoSize = true;
            this.ScientificSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScientificSerch.Location = new System.Drawing.Point(26, 75);
            this.ScientificSerch.Name = "ScientificSerch";
            this.ScientificSerch.Size = new System.Drawing.Size(153, 24);
            this.ScientificSerch.TabIndex = 13;
            this.ScientificSerch.TabStop = true;
            this.ScientificSerch.Text = "Scientific Serch";
            this.ScientificSerch.UseVisualStyleBackColor = true;
            // 
            // BrandNameSerch
            // 
            this.BrandNameSerch.AutoSize = true;
            this.BrandNameSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandNameSerch.Location = new System.Drawing.Point(187, 75);
            this.BrandNameSerch.Name = "BrandNameSerch";
            this.BrandNameSerch.Size = new System.Drawing.Size(127, 24);
            this.BrandNameSerch.TabIndex = 12;
            this.BrandNameSerch.TabStop = true;
            this.BrandNameSerch.Text = "Brand Serch";
            this.BrandNameSerch.UseVisualStyleBackColor = true;
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.FormattingEnabled = true;
            this.SearchBar.Location = new System.Drawing.Point(319, 70);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(414, 33);
            this.SearchBar.TabIndex = 11;
            this.SearchBar.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "DELETE A DRUG  ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(277, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(433, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // drug_remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddChekBox);
            this.Controls.Add(this.SearchChkBox);
            this.Controls.Add(this.ScientificSerch);
            this.Controls.Add(this.BrandNameSerch);
            this.Controls.Add(this.SearchBar);
            this.Name = "drug_remove";
            this.Text = "drug_remove";
            this.Load += new System.EventHandler(this.drug_remove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AddChekBox;
        private System.Windows.Forms.ListBox SearchChkBox;
        private System.Windows.Forms.RadioButton ScientificSerch;
        private System.Windows.Forms.RadioButton BrandNameSerch;
        private System.Windows.Forms.ComboBox SearchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}