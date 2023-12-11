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
    public partial class AdminAdd : Form
    {
        string BName, SName, FTyp;
        double Dose, Praice;
        int NumberOfBox;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string message = "Do you wont to Add these druge To you'r list?";
            string caption = "Add Druge";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                Medicine medicine = new Medicine();
                medicine.BrandName = BName;
                medicine.ScientificName = SName;
                medicine.RCPoint = RCPoint;
                medicine.Dose = Dose;
                medicine.Price = Praice;
                medicine.NumberInStore = NumberOfBox;
                medicine.Type = FTyp;
                bool resulte =MedisineData.AddMid(medicine);
                if (resulte)
                {
                    MessageBox.Show("Added Succesfole");
                }
                else
                {
                    MessageBox.Show("These druge is olrede in the database");
                }
            }
        }

        Point RCPoint;
        private void BtnTest_Click(object sender, EventArgs e)
        {
            BName = TxtBName.Text;
            SName = TxtSName.Text;
            FTyp = CmbTypeList.Text;
            try
            {
                Dose = double.Parse(TxtDose.Text);
                Praice = double.Parse(TxtPrice.Text);
                NumberOfBox = int.Parse(TxtNumberOfBoxes.Text);
                RCPoint.X = int.Parse(TxtColomen.Text);
                RCPoint.Y = int.Parse(TxtRow.Text);
                TxtOutbot.Text = $"{BName} {SName} {FTyp} {Dose} {Praice} {NumberOfBox} {RCPoint.ToString()}";
            }catch (Exception ex)
            {
                TxtColomen.Text = "";
                TxtRow.Text = "";
                TxtNumberOfBoxes.Text = "";
                TxtDose.Text = "";
                TxtPrice.Text = "";
                MessageBox.Show("Unbrobreat data");
            }
            
        }
        public AdminAdd()
        {
            InitializeComponent();
            RCPoint = new Point();
            List<string> list = new List<string>();
            list = MedisineData.GetTypes();
            foreach (string s in list)
            {
                CmbTypeList.Items.Add(s);
            }
        }

    }
}
