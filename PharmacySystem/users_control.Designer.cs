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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
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
            // RdEmploy
            // 
            this.RdEmploy.AutoSize = true;
            this.RdEmploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdEmploy.Location = new System.Drawing.Point(480, 150);
            this.RdEmploy.Name = "RdEmploy";
            this.RdEmploy.Size = new System.Drawing.Size(103, 24);
            this.RdEmploy.TabIndex = 17;
            this.RdEmploy.TabStop = true;
            this.RdEmploy.Text = "employee";
            this.RdEmploy.UseVisualStyleBackColor = true;
            this.RdEmploy.CheckedChanged += new System.EventHandler(this.RdEmploy_CheckedChanged);
            // 
            // RdAdmin
            // 
            this.RdAdmin.AutoSize = true;
            this.RdAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdAdmin.Location = new System.Drawing.Point(619, 150);
            this.RdAdmin.Name = "RdAdmin";
            this.RdAdmin.Size = new System.Drawing.Size(75, 24);
            this.RdAdmin.TabIndex = 16;
            this.RdAdmin.TabStop = true;
            this.RdAdmin.Text = "admin";
            this.RdAdmin.UseVisualStyleBackColor = true;
            this.RdAdmin.CheckedChanged += new System.EventHandler(this.RdAdmin_CheckedChanged);
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
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(465, 355);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(118, 38);
            this.BtnAddUser.TabIndex = 20;
            this.BtnAddUser.Text = "Add";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
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
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(538, 269);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(156, 26);
            this.TxtPassword.TabIndex = 22;
            this.TxtPassword.Text = "password";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(366, 269);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(156, 26);
            this.TxtUserName.TabIndex = 23;
            this.TxtUserName.Text = "user name";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Red;
            this.BtnDelete.Location = new System.Drawing.Point(366, 144);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(84, 37);
            this.BtnDelete.TabIndex = 24;
            this.BtnDelete.Text = "delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // users_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 430);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Button BtnDelete;
    }
}