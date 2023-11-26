using PharmacySystem.DataControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacySystem.Classes
{
    internal class Transaction
    {
        public int Id;
        public double Totale;
        public double Discont;
        public User TheUser;
        public int UserId;
        public DateTime TransactionTime;
        public void GetUser()
        {
            TheUser = UserData.GetUser(UserId);
        }
    }
}
