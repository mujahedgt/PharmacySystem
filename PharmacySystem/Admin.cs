using PharmacySystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacySystem;
namespace PharmacySystem
{
    public partial class Admin : Form
    {
        User user;
        public Admin(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void BtnSearchAdd_Click(object sender, EventArgs e)
        {
            SearchAdd search = new SearchAdd(user);
            search.Show();
        }

        private void BtnAddDrug_Click(object sender, EventArgs e)
        {
            AdminAdd adminAdd = new AdminAdd();
            adminAdd.Show();
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            history history = new history();
            history.Show();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login f = Application.OpenForms.OfType<Login>().FirstOrDefault();
            if (f != null) f.Show();
        }
    }
}
