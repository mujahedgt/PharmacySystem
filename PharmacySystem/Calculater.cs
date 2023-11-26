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

namespace PharmacySystem
{
    public partial class Calculater : Form
    {
        User user;
        List<Medicine> mMedicines;
        double totale=0;
        double descaont=0;
        double desc;
        public Calculater(List<Medicine> medicines,User user)
        {
            InitializeComponent();
            this.user = user;
            mMedicines = medicines;
            foreach (var medicine in mMedicines)
            {
                totale += medicine.Price;
                lts_drug_collection.Items.Add($"{medicine.Id} {medicine.BrandName} {medicine.ScientificName} {medicine.Dose}");
            }
            desc = totale;
            txt_the_final_price.Text = totale.ToString();
        }
        void Remov()
        {
            string[] Arr = lts_drug_collection.SelectedItem.ToString().Split(' ');
            int id = int.Parse(Arr[0]);
            bool exest = false;
            foreach (Medicine itm in mMedicines)
            {
                if (itm.Id == id)
                {
                    exest = true;
                }
            }
            if (exest)
                foreach (Medicine item in mMedicines)
                {
                    if (item.Id == id)
                    {
                        totale -= item.Price;
                        txt_the_final_price.Text = totale.ToString();
                        mMedicines.Remove(item);
                        item.NumberInStore++;
                        lts_drug_collection.Items.Remove($"{item.Id} {item.BrandName} {item.ScientificName} {item.Dose}");
                        desc = totale;
                        break;
                    }
                }
        }

        private void lts_drug_collection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lts_drug_collection.SelectedItem != null)
                Remov();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_dicount_amount.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_dicount_amount.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_dicount_amount.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_dicount_amount.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_dicount_amount.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_dicount_amount.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_dicount_amount.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_dicount_amount.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt_dicount_amount.Text += 9;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txt_dicount_amount.Text += 0;
        }

        private void DiscontMony_Click(object sender, EventArgs e)
        {
            descaont = double.Parse(txt_dicount_amount.Text);
            double test = totale - descaont;
            if (test < 0)
            {
                MessageBox.Show("You cant do that the result will be " + test);
            }
            else
            {
                totale = test;
            }

            txt_the_final_price.Text = totale.ToString();
        }

        private void DiscontPersunt_Click(object sender, EventArgs e)
        {
            descaont = double.Parse(txt_dicount_amount.Text);
            if (descaont > 100)
            {
                MessageBox.Show("You cant dscont mor than 100%");
            }
            else
            {
                descaont = descaont / 100;
                descaont = 1 - descaont;
                totale *= descaont;
            }
            txt_the_final_price.Text = totale.ToString();
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Totale = desc;
            transaction.Discont = totale;
            transaction.TheUser = user;
            transaction.TransactionTime = DateTime.Now;
            TransactionData.AddTransaction(transaction);
            foreach(Medicine medicine in mMedicines)
            {
                MedisineData.UpDateNumber(medicine.Id, medicine.NumberInStore);
            }
            SearchAdd f = Application.OpenForms.OfType<SearchAdd>().FirstOrDefault();
            if (f != null) f.Show();
            this.Close();
        }

        private void Calculater_FormClosed(object sender, FormClosedEventArgs e)
        {
            SearchAdd f = Application.OpenForms.OfType<SearchAdd>().FirstOrDefault();
            if (f != null) f.Show();
        }
    }
}
