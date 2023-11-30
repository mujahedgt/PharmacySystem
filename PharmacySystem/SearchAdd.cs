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
using System.Web;
using System.Windows.Forms;

namespace PharmacySystem
{
    public partial class SearchAdd : Form
    {
        User user;
        List<string> Brand,Seantefic;
        List<Medicine> BoxAdd, SerchResult;

        private void BrandNameSerch_CheckedChanged(object sender, EventArgs e)
        {
            if (BrandNameSerch.Checked)
            {
                SearchBar.Items.Clear();
                foreach (string s in Brand)
                    SearchBar.Items.Add(s);
            }
        }

        private void ScientificSerch_CheckedChanged(object sender, EventArgs e)
        {

            if (ScientificSerch.Checked)
            {
                SearchBar.Items.Clear();
                foreach (string s in Seantefic)
                    SearchBar.Items.Add(s);
            }
        }

        private void SearchBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerchAdd();
        }
        private void SerchAdd()
        {
            if (ScientificSerch.Checked)
            {
                SerchResult = MedisineData.ScientificResearch(SearchBar.Text);
            }
            else
            {
                SerchResult = MedisineData.BrandResearch(SearchBar.Text);
            }
            SearchChkBox.Items.Clear();
            foreach (Medicine item in SerchResult)
            {
                if (item.NumberInStore > 0)
                {
                    string itm = $"{item.Id} {item.BrandName} {item.ScientificName} {item.Dose}";
                    SearchChkBox.Items.Add(itm);
                }
            }
        }
        void Detals(Medicine target)
        {
            drug_information.Items.Clear();
            drug_information.Items.Add($"Drug posetion Row:{target.RCPoint.X} ,  Colmin:{target.RCPoint.Y}");
            drug_information.Items.Add($"Drug Brand Name : {target.BrandName} ,Scientific Name: {target.ScientificName}");
            drug_information.Items.Add($"Drug Dose :{target.Dose} ,Prise : {target.Price}jd");
            drug_information.Items.Add($"Drug number in store :{target.NumberInStore} , Form:{target.Type}");
        }
        Medicine medicine(int id)
        {
            foreach (Medicine item in SerchResult)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        private void SearchChkBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Arr = SearchChkBox.SelectedItem.ToString().Split(' ');
            int id = int.Parse(Arr[0]);
            bool exest =false;
            Medicine target = new Medicine();
            foreach(Medicine itm in BoxAdd)
            {
                if(itm.Id == id)
                {
                    target= itm;
                    exest = true;
                }
            }
            if (!exest)
            {
                target = medicine(id);
                BoxAdd.Add(target);
                target.NumberInStore--;
                AddChekBox.Items.Add($"{target.Id} {target.BrandName} {target.ScientificName} {target.Dose}");
                SerchAdd();
            }
            Detals(target);
        }
        void Remov()
        {
            string[] Arr = AddChekBox.SelectedItem.ToString().Split(' ');
            int id = int.Parse(Arr[0]);
            bool exest = false;
            foreach (Medicine itm in BoxAdd)
            {
                if (itm.Id == id)
                {
                    exest = true;
                }
            }
            if (exest)
                foreach (Medicine item in BoxAdd)
                {
                    if (item.Id == id)
                    {
                        BoxAdd.Remove(item);
                        item.NumberInStore++;
                        AddChekBox.Items.Remove($"{item.Id} {item.BrandName} {item.ScientificName} {item.Dose}");
                        SerchAdd();
                        break;
                    }
                }
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            Calculater calculater = new Calculater(BoxAdd,user);
            calculater.Show();
            this.Hide();
        }

        private void SearchAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login f = Application.OpenForms.OfType<Login>().FirstOrDefault();
            if (f != null) f.Show();
        }
        private void AddChekBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddChekBox.SelectedItem != null)
            {

                string message = "Do you wont to delete these druge from the list?";
                string caption = "Delet";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if(result == DialogResult.Yes)
                {
                    Remov();
                }
            }
        }
        public SearchAdd(User user)
        {
            InitializeComponent();
            Brand = MedisineData.BrandResult();
            Seantefic = MedisineData.ScientificResult();
            BoxAdd = new List<Medicine>();
            this.user = user;
        }
    }
}
