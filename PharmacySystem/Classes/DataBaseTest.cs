using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PharmacySystem.Classes
{
    internal class DataBaseTest
    {
        public DataBaseTest() 
        {
            String str = "server=DESKTOP-HS1LAF8;database=PharmacySystem;UID=sa;password=P@ss0wrd";

            String query = "select * from cars";

            SqlConnection con = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            string j = cmd.ExecuteReader().ToString();
            DataSet ds = new DataSet();

            MessageBox.Show("connect with sql server");

            con.Close();
        }
    }
}
