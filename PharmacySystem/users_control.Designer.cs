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
            this.RdEmploy = new System.Windows.Forms.RadioButton();
            this.RdAdmin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnStateChange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // users_list
            // 
            this.users_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_list.FormattingEnabled = true;
            this.users_list.ItemHeight = 24;
            this.users_list.Location = new System.Drawing.Point(222, 154);
            this.users_list.Name = "users_list";
            this.users_list.Size = new System.Drawing.Size(329, 100);
            this.users_list.TabIndex = 0;
            // 
            // RdEmploy
            // 
            this.RdEmploy.AutoSize = true;
            this.RdEmploy.BackColor = System.Drawing.Color.Transparent;
            this.RdEmploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdEmploy.Location = new System.Drawing.Point(399, 97);
            this.RdEmploy.Name = "RdEmploy";
            this.RdEmploy.Size = new System.Drawing.Size(103, 24);
            this.RdEmploy.TabIndex = 17;
            this.RdEmploy.TabStop = true;
            this.RdEmploy.Text = "employee";
            this.RdEmploy.UseVisualStyleBackColor = false;
            this.RdEmploy.CheckedChanged += new System.EventHandler(this.RdEmploy_CheckedChanged);
            // 
            // RdAdmin
            // 
            this.RdAdmin.AutoSize = true;
            this.RdAdmin.BackColor = System.Drawing.Color.Transparent;
            this.RdAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdAdmin.Location = new System.Drawing.Point(290, 97);
            this.RdAdmin.Name = "RdAdmin";
            this.RdAdmin.Size = new System.Drawing.Size(75, 24);
            this.RdAdmin.TabIndex = 16;
            this.RdAdmin.TabStop = true;
            this.RdAdmin.Text = "admin";
            this.RdAdmin.UseVisualStyleBackColor = false;
            this.RdAdmin.CheckedChanged += new System.EventHandler(this.RdAdmin_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(292, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Employee List";
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddUser.Location = new System.Drawing.Point(318, 463);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(108, 38);
            this.BtnAddUser.TabIndex = 20;
            this.BtnAddUser.Text = "Add";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(407, 418);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(156, 26);
            this.TxtPassword.TabIndex = 22;
            this.TxtPassword.Text = "password";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(180, 418);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(156, 26);
            this.TxtUserName.TabIndex = 23;
            this.TxtUserName.Text = "user name";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Red;
            this.BtnDelete.Location = new System.Drawing.Point(222, 286);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(123, 36);
            this.BtnDelete.TabIndex = 24;
            this.BtnDelete.Text = "delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Add An Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Serch";
            // 
            // BtnStateChange
            // 
            this.BtnStateChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStateChange.ForeColor = System.Drawing.Color.Red;
            this.BtnStateChange.Location = new System.Drawing.Point(366, 286);
            this.BtnStateChange.Name = "BtnStateChange";
            this.BtnStateChange.Size = new System.Drawing.Size(185, 36);
            this.BtnStateChange.TabIndex = 28;
            this.BtnStateChange.Text = "Demote/Promote user";
            this.BtnStateChange.UseVisualStyleBackColor = true;
            this.BtnStateChange.Click += new System.EventHandler(this.BtnStateChange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(315, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "طيب واذا ما عملت هيييييك";
            // 
            // users_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmacySystem.Properties.Resources.istockphoto_1350046657_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 531);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnStateChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RdEmploy);
            this.Controls.Add(this.RdAdmin);
            this.Controls.Add(this.users_list);
            this.Name = "users_control";
            this.Text = "user control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox users_list;
        private System.Windows.Forms.RadioButton RdEmploy;
        private System.Windows.Forms.RadioButton RdAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnStateChange;
        private System.Windows.Forms.Label label4;
    }
}