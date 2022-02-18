using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Project
{
    internal class Balance
    {
        public int _balance { get; set; }

        public int BalanceFull()
        {
            Random rnd = new Random();
            int _balance = rnd.Next(1000, 10000);

            return _balance;
        }
    }
}
