namespace PharmacySystem
{
    partial class Admin
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
            this.notification_list = new System.Windows.Forms.ListBox();
            this.BtnSearchAdd = new System.Windows.Forms.Button();
            this.BtnAddDrug = new System.Windows.Forms.Button();
            this.BtnUserControle = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notification_list
            // 
            this.notification_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_list.FormattingEnabled = true;
            this.notification_list.ItemHeight = 24;
            this.notification_list.Location = new System.Drawing.Point(12, 75);
            this.notification_list.Name = "notification_list";
            this.notification_list.Size = new System.Drawing.Size(324, 292);
            this.notification_list.TabIndex = 0;
            // 
            // BtnSearchAdd
            // 
            this.BtnSearchAdd.Location = new System.Drawing.Point(516, 29);
            this.BtnSearchAdd.Name = "BtnSearchAdd";
            this.BtnSearchAdd.Size = new System.Drawing.Size(122, 108);
            this.BtnSearchAdd.TabIndex = 1;
            this.BtnSearchAdd.Text = "Search For Drug";
            this.BtnSearchAdd.UseVisualStyleBackColor = true;
            this.BtnSearchAdd.Click += new System.EventHandler(this.BtnSearchAdd_Click);
            // 
            // BtnAddDrug
            // 
            this.BtnAddDrug.Location = new System.Drawing.Point(516, 143);
            this.BtnAddDrug.Name = "BtnAddDrug";
            this.BtnAddDrug.Size = new System.Drawing.Size(122, 108);
            this.BtnAddDrug.TabIndex = 2;
            this.BtnAddDrug.Text = "Add a Drug";
            this.BtnAddDrug.UseVisualStyleBackColor = true;
            this.BtnAddDrug.Click += new System.EventHandler(this.BtnAddDrug_Click);
            // 
            // BtnUserControle
            // 
            this.BtnUserControle.Location = new System.Drawing.Point(516, 257);
            this.BtnUserControle.Name = "BtnUserControle";
            this.BtnUserControle.Size = new System.Drawing.Size(122, 108);
            this.BtnUserControle.TabIndex = 3;
            this.BtnUserControle.Text = "Users control";
            this.BtnUserControle.UseVisualStyleBackColor = true;
            this.BtnUserControle.Click += new System.EventHandler(this.BtnUserControle_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Location = new System.Drawing.Point(360, 29);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(122, 108);
            this.BtnHistory.TabIndex = 4;
            this.BtnHistory.Text = "the history";
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(360, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 108);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(360, 257);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 108);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Notification";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnHistory);
            this.Controls.Add(this.BtnUserControle);
            this.Controls.Add(this.BtnAddDrug);
            this.Controls.Add(this.BtnSearchAdd);
            this.Controls.Add(this.notification_list);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox notification_list;
        private System.Windows.Forms.Button BtnSearchAdd;
        private System.Windows.Forms.Button BtnAddDrug;
        private System.Windows.Forms.Button BtnUserControle;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
    }
}