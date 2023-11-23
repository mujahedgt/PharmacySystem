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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MedisineData.ScientificResult();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""||textBox2.Text=="")
            {
                MessageBox.Show("Enter your user name and password");
            }
            else
            {
                User m = UserData.IsUserExist(textBox2.Text, textBox1.Text);
                if(m != null)
                {
                    MessageBox.Show("Hello " + m.Name);
                    //Button button = new Button();
                    //button.Name = m.Name;
                    //button.Size = new Size(100, 50);
                    //button.Location = new Point(0, 0);
                    //button.Click += (object sender1, EventArgs ev) =>
                    //{
                    //    //you can use your variables inside event
                    //    MessageBox.Show("mujahed");
                    //};
                    //Controls.Add(button);
                    //button.Name = m.Name+1;
                    //button.Size = new Size(100, 50);
                    //button.Location = new Point(0, 60);
                    //button.Click += (object sender1, EventArgs ev) =>
                    //{
                    //    //you can use your variables inside event
                    //    MessageBox.Show("fuk you");
                    //};
                    //Controls.Add(button);
                }
                else
                {
                    MessageBox.Show("Yous user name or passowrd is wrong");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
