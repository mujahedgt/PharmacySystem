using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // the dose  ,, for examble (panda ----500----) the 500 is the dose 
            // it might be in Ml or Mg or G 
            // i deleted bu it didnt
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pharmaceutical form    ,, tablet , Suppositories ... etc. 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // the dose  ,, for examble (panda ----500----) the 500 is the dose 
            // it might be in Ml or Mg or G 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // brand name 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // scientific name
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // price
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // when you add a drug just make a pop up message that said "success" or something 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // it will display the final name 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // this will only appear if the admin chose "remove/hide drug" 
            //and it for search for delete/hide a drug 
            // the text result will appear in the same one that we use for the final result in adding situation
            // let the search be for the final name and dont make room for guessing
            // change the button add in the bottom to delete/hide 
        }
    }
}
