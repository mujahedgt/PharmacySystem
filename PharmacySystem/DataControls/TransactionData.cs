using PharmacySystem.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacySystem.DataControls
{
    internal class TransactionData
    {
        private static SqlConnection sqlConnection()
        {
            const string str = "server=DESKTOP-HS1LAF8\\SQLEXPRESS;database=PharmacySystem;UID=sa;password=P@ss0wrd";
            SqlConnection con = new SqlConnection(str);
            return con;
        }
        static public void AddTransaction(Transaction transaction)
        {
                SqlConnection con = sqlConnection();
                SqlCommand cmd = new SqlCommand($"insert into transactions (totale,discont,userId,transDate) values ({transaction.Totale},'{transaction.Discont}',{transaction.TheUser.Id},'{transaction.TransactionTime}')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
        }
        static public List<Transaction> GetTransactionList()
        {
            List<Transaction> list = new List<Transaction>();
            SqlConnection con = sqlConnection();
            SqlCommand cmd = new SqlCommand($"select * from transactions ", con);
            con.Open();
            SqlDataReader rdr= cmd.ExecuteReader();
            while (rdr.Read())
            {
                Transaction t = new Transaction();
                t.Id = rdr.GetInt32(0);
                t.Totale=Convert.ToDouble(rdr.GetValue(1));
                t.Discont=Convert.ToDouble(rdr.GetValue(2));
                t.UserId=rdr.GetInt32(3);
                t.TransactionTime= rdr.GetDateTime(4);
                list.Add(t);
            }
            foreach (Transaction t in list)
            {
                t.GetUser();
            }
            con.Close();
            return list;
        }
    }
}
