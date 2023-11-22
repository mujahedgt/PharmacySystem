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

namespace PharmacySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataBaseTest dataBaseTest = new DataBaseTest();
            User m = new User();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
