namespace PharmacySystem
{
    partial class SearchAdd
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
            this.SearchBar = new System.Windows.Forms.ComboBox();
            this.Proceed = new System.Windows.Forms.Button();
            this.BrandNameSerch = new System.Windows.Forms.RadioButton();
            this.ScientificSerch = new System.Windows.Forms.RadioButton();
            this.SearchChkBox = new System.Windows.Forms.ListBox();
            this.AddChekBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.FormattingEnabled = true;
            this.SearchBar.Location = new System.Drawing.Point(332, 14);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(414, 33);
            this.SearchBar.TabIndex = 0;
            this.SearchBar.Text = "Search";
            this.SearchBar.SelectedIndexChanged += new System.EventHandler(this.SearchBar_SelectedIndexChanged);
            // 
            // Proceed
            // 
            this.Proceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proceed.Location = new System.Drawing.Point(332, 354);
            this.Proceed.Name = "Proceed";
            this.Proceed.Size = new System.Drawing.Size(138, 56);
            this.Proceed.TabIndex = 3;
            this.Proceed.Text = "Proceed";
            this.Proceed.UseVisualStyleBackColor = true;
            this.Proceed.Click += new System.EventHandler(this.Proceed_Click);
            // 
            // BrandNameSerch
            // 
            this.BrandNameSerch.AutoSize = true;
            this.BrandNameSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandNameSerch.Location = new System.Drawing.Point(200, 19);
            this.BrandNameSerch.Name = "BrandNameSerch";
            this.BrandNameSerch.Size = new System.Drawing.Size(127, 24);
            this.BrandNameSerch.TabIndex = 7;
            this.BrandNameSerch.TabStop = true;
            this.BrandNameSerch.Text = "Brand Serch";
            this.BrandNameSerch.UseVisualStyleBackColor = true;
            this.BrandNameSerch.CheckedChanged += new System.EventHandler(this.BrandNameSerch_CheckedChanged);
            // 
            // ScientificSerch
            // 
            this.ScientificSerch.AutoSize = true;
            this.ScientificSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScientificSerch.Location = new System.Drawing.Point(39, 19);
            this.ScientificSerch.Name = "ScientificSerch";
            this.ScientificSerch.Size = new System.Drawing.Size(153, 24);
            this.ScientificSerch.TabIndex = 8;
            this.ScientificSerch.TabStop = true;
            this.ScientificSerch.Text = "Scientific Serch";
            this.ScientificSerch.UseVisualStyleBackColor = true;
            this.ScientificSerch.CheckedChanged += new System.EventHandler(this.ScientificSerch_CheckedChanged);
            // 
            // SearchChkBox
            // 
            this.SearchChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchChkBox.FormattingEnabled = true;
            this.SearchChkBox.ItemHeight = 25;
            this.SearchChkBox.Location = new System.Drawing.Point(12, 53);
            this.SearchChkBox.Name = "SearchChkBox";
            this.SearchChkBox.Size = new System.Drawing.Size(387, 279);
            this.SearchChkBox.TabIndex = 9;
            this.SearchChkBox.SelectedIndexChanged += new System.EventHandler(this.SearchChkBox_SelectedIndexChanged);
            // 
            // AddChekBox
            // 
            this.AddChekBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddChekBox.FormattingEnabled = true;
            this.AddChekBox.ItemHeight = 25;
            this.AddChekBox.Location = new System.Drawing.Point(405, 53);
            this.AddChekBox.Name = "AddChekBox";
            this.AddChekBox.Size = new System.Drawing.Size(396, 279);
            this.AddChekBox.TabIndex = 10;
            this.AddChekBox.SelectedIndexChanged += new System.EventHandler(this.AddChekBox_SelectedIndexChanged);
            // 
            // SearchAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddChekBox);
            this.Controls.Add(this.SearchChkBox);
            this.Controls.Add(this.ScientificSerch);
            this.Controls.Add(this.BrandNameSerch);
            this.Controls.Add(this.Proceed);
            this.Controls.Add(this.SearchBar);
            this.Name = "SearchAdd";
            this.Text = "search and add screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchAdd_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SearchBar;
        private System.Windows.Forms.Button Proceed;
        private System.Windows.Forms.RadioButton BrandNameSerch;
        private System.Windows.Forms.RadioButton ScientificSerch;
        private System.Windows.Forms.ListBox SearchChkBox;
        private System.Windows.Forms.ListBox AddChekBox;
    }
}

