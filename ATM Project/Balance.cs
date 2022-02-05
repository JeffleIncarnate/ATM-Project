using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Project
{
    public class Balance
    {
        public int balance { get; set; }

        public int BalanceFull()
        {
            Random random = new Random();

            int balance = random.Next(1000, 10000);
            return balance ; 
        }
    }
}
