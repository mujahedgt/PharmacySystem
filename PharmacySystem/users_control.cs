using PharmacySystem.Classes;
using PharmacySystem.DataControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PharmacySystem
{
    public partial class users_control : Form
    {
        List<User> AdminList = new List<User>();
        List<User> EmployList = new List<User>();
        public users_control()
        {
            InitializeComponent();
            AdminList = UserData.AdminList();
            EmployList = UserData.EmployList();
            RdEmploy.Checked = true;
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            string name = TxtUserName.Text;
            string password = TxtPassword.Text;
            string message = $"Do you wont to Add these user\nName: {name}\nPasswordd: {password}?";
            string caption = "Add User";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                bool isNotExest = UserData.AddUser(name, password,false);
                if (isNotExest)
                {
                    MessageBox.Show("User Added Successfule");
                }
                else
                {
                    MessageBox.Show("User is alrede Exest");
                }
            }
        }

        private void RdEmploy_CheckedChanged(object sender, EventArgs e)
        {
            users_list.Items.Clear();
            foreach (User u in EmployList)
            {
                users_list.Items.Add($"{u.Id} {u.Name}");
            }
        }

        private void RdAdmin_CheckedChanged(object sender, EventArgs e)
        {
            users_list.Items.Clear();

            foreach (User u in AdminList)
            {
                users_list.Items.Add($"{u.Id} {u.Name}");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();
            int id = int.Parse(users_list.SelectedItem.ToString()[0].ToString());
            if (RdEmploy.Checked)
            {
                foreach (User u in EmployList)
                {
                    if (u.Id == id)
                    {
                        user=u; 
                        break;
                    }
                }
            }
            else
            {

                foreach (User u in AdminList)
                {
                    if (u.Id == id)
                    {
                        user = u;
                        break;
                    }
                }
            }

            string name = user.Name;
            string password = user.Password;
            string admin = user.IsAdmin.ToString();
            string message = $"Do you wont to Delete these user\nName: {name}\nAdmin?: {admin}\n?";
            string caption = "Add User";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                UserData.DeleteUser(id);
                if (RdEmploy.Checked)
                {
                    EmployList.Remove(user); 
                }
                else
                {
                    AdminList.Remove(user);
                }
            }

        }

        private void BtnStateChange_Click(object sender, EventArgs e)
        {
            User user = new User();
            int id = int.Parse(users_list.SelectedItem.ToString()[0].ToString());
            if (RdEmploy.Checked)
            {
                foreach (User u in EmployList)
                {
                    if (u.Id == id)
                    {
                        user = u;
                        break;
                    }
                }
            }
            else
            {

                foreach (User u in AdminList)
                {
                    if (u.Id == id)
                    {
                        user = u;
                        break;
                    }
                }
            }

            string message = $"Do you wont to change the posetion of thes employ\nName: {user.Name}\nIs Admin?: {user.IsAdmin} \nThe next postion is admin?: {!user.IsAdmin}";
            string caption = "Cheng Posetion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                UserData.ChangeUserAccess(user.Id, !user.IsAdmin);
            }
        }
    }
}
