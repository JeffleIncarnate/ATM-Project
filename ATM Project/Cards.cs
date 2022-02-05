using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Project
{
    public class Cards
    {
        public string Card1 { get; set; }
        public string Pin1 { get; set; }

        public string GetFullAccount()
        {
            return "Card: " + Card1 + "\n" + "Pin: " + Pin1; 
        }
    }
}
