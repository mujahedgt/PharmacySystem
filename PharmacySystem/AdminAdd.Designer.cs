namespace PharmacySystem
{
    partial class AdminAdd
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
            this.TxtOutbot = new System.Windows.Forms.TextBox();
            this.TxtNumberOfBoxes = new System.Windows.Forms.TextBox();
            this.BtnTest = new System.Windows.Forms.Button();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtSName = new System.Windows.Forms.TextBox();
            this.TxtBName = new System.Windows.Forms.TextBox();
            this.TxtDose = new System.Windows.Forms.TextBox();
            this.CmbTypeList = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtColomen = new System.Windows.Forms.TextBox();
            this.TxtRow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtOutbot
            // 
            this.TxtOutbot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtOutbot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOutbot.Location = new System.Drawing.Point(14, 290);
            this.TxtOutbot.Name = "TxtOutbot";
            this.TxtOutbot.Size = new System.Drawing.Size(559, 31);
            this.TxtOutbot.TabIndex = 26;
            // 
            // TxtNumberOfBoxes
            // 
            this.TxtNumberOfBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumberOfBoxes.Location = new System.Drawing.Point(300, 123);
            this.TxtNumberOfBoxes.Name = "TxtNumberOfBoxes";
            this.TxtNumberOfBoxes.Size = new System.Drawing.Size(254, 31);
            this.TxtNumberOfBoxes.TabIndex = 25;
            this.TxtNumberOfBoxes.Text = "Number of Boxes";
            // 
            // BtnTest
            // 
            this.BtnTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTest.Location = new System.Drawing.Point(122, 327);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(117, 33);
            this.BtnTest.TabIndex = 23;
            this.BtnTest.Text = "Test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(12, 123);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(254, 31);
            this.TxtPrice.TabIndex = 22;
            this.TxtPrice.Text = "Price";
            // 
            // TxtSName
            // 
            this.TxtSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSName.Location = new System.Drawing.Point(300, 24);
            this.TxtSName.Name = "TxtSName";
            this.TxtSName.Size = new System.Drawing.Size(254, 31);
            this.TxtSName.TabIndex = 21;
            this.TxtSName.Text = "Scientific Name";
            // 
            // TxtBName
            // 
            this.TxtBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBName.Location = new System.Drawing.Point(12, 24);
            this.TxtBName.Name = "TxtBName";
            this.TxtBName.Size = new System.Drawing.Size(254, 31);
            this.TxtBName.TabIndex = 20;
            this.TxtBName.Text = "Brand Name";
            // 
            // TxtDose
            // 
            this.TxtDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDose.Location = new System.Drawing.Point(12, 77);
            this.TxtDose.Name = "TxtDose";
            this.TxtDose.Size = new System.Drawing.Size(254, 31);
            this.TxtDose.TabIndex = 19;
            this.TxtDose.Text = "Dose";
            // 
            // CmbTypeList
            // 
            this.CmbTypeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTypeList.FormattingEnabled = true;
            this.CmbTypeList.Location = new System.Drawing.Point(300, 75);
            this.CmbTypeList.Name = "CmbTypeList";
            this.CmbTypeList.Size = new System.Drawing.Size(254, 33);
            this.CmbTypeList.TabIndex = 18;
            this.CmbTypeList.Text = "Pharmaceutical Form";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(283, 327);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(117, 33);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Colomen";
            // 
            // TxtColomen
            // 
            this.TxtColomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColomen.Location = new System.Drawing.Point(225, 191);
            this.TxtColomen.Name = "TxtColomen";
            this.TxtColomen.Size = new System.Drawing.Size(54, 31);
            this.TxtColomen.TabIndex = 32;
            // 
            // TxtRow
            // 
            this.TxtRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRow.Location = new System.Drawing.Point(349, 191);
            this.TxtRow.Name = "TxtRow";
            this.TxtRow.Size = new System.Drawing.Size(51, 31);
            this.TxtRow.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Row";
            // 
            // AdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 386);
            this.Controls.Add(this.TxtRow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtColomen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtOutbot);
            this.Controls.Add(this.TxtNumberOfBoxes);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtSName);
            this.Controls.Add(this.TxtBName);
            this.Controls.Add(this.TxtDose);
            this.Controls.Add(this.CmbTypeList);
            this.Controls.Add(this.BtnAdd);
            this.Name = "AdminAdd";
            this.Text = "AdminAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtOutbot;
        private System.Windows.Forms.TextBox TxtNumberOfBoxes;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtSName;
        private System.Windows.Forms.TextBox TxtBName;
        private System.Windows.Forms.TextBox TxtDose;
        private System.Windows.Forms.ComboBox CmbTypeList;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtColomen;
        private System.Windows.Forms.TextBox TxtRow;
        private System.Windows.Forms.Label label3;
    }
}