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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // discount percentage   ,, some of drugs have 0% discaout some have 10% or 15% 
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
    }
}
