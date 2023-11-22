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
        private static SqlCommand Comand(string com)
        {
            const string str = "server=DESKTOP-HS1LAF8\\SQLEXPRESS;database=PharmacySystem;UID=sa;password=P@ss0wrd";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(com, con);
            return cmd;
        }
        static bool IsUserExist(string UserName,string Password)
        {
            SqlCommand cmd = Comand($"select * from users where userId='{UserName}' and userPassword='{Password}'");
            return true;
        }
    }
}
