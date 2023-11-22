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
            SqlCommand Comand (string com)
            {
                String str = "server=DESKTOP-HS1LAF8\\SQLEXPRESS;database=PharmacySystem;UID=sa;password=P@ss0wrd";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(com, con);
                return cmd;
            }

            String query = "select * from cars";

            SqlConnection con = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            string j = rdr[0].ToString();

            DataSet ds = new DataSet();

            MessageBox.Show(j);

            con.Close();
        }
    }
}
