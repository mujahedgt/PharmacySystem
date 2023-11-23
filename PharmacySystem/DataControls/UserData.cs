using PharmacySystem.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacySystem.DataControls
{
    class UserData
    {
        private static SqlConnection sqlConnection()
        {
            const string str = "server=DESKTOP-HS1LAF8\\SQLEXPRESS;database=PharmacySystem;UID=sa;password=P@ss0wrd";
            SqlConnection con = new SqlConnection(str);
            return con;
        }
        static public User IsUserExist(string UserName,string Password)
        {
            User user = null;
            SqlConnection con = sqlConnection();
            SqlCommand cmd = new SqlCommand ($"select * from users where userName='{UserName}' and userPassword='{Password}'",con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read()) 
            { 
                user = new User();
                user.Id = rdr.GetInt32(0);
                user.Name = rdr.GetString(1);
                user.IsAdmin = rdr.GetBoolean(3);
            }
            return user;
        }
    }
}
