using PharmacySystem.Classes;
using PharmacySystem.DataControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PharmacySystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text == ""||TxtUserName.Text=="")
            {
                MessageBox.Show("Enter your user name and password");
            }
            else
            {
                User m = UserData.IsUserExist(TxtUserName.Text, TxtPassword.Text);
                if(m != null)
                {
                    TxtPassword.Text = "";
                    TxtUserName.Text = "";
                    if (m.IsAdmin)
                    {
                        Admin admin = new Admin(m);
                        admin.Show();
                    }
                    else
                    {
                        SearchAdd searchAdd = new SearchAdd(m);
                        searchAdd.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yous user name or passowrd is wrong");
                }
            }

        }
    }
}
