using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string pin = "12345";
            string cardNumber = "1234 5678 1111 1111";
            string cardNumberGuess = "";
            string pinGuess = "";

            while (cardNumberGuess != cardNumber)
            {
                Console.Write("Enter your card Number: ");
                cardNumberGuess = Console.ReadLine();
            }

            while (pinGuess != pin)
            {
                Console.Write("Enter your Pin Number: ");
                pinGuess = Console.ReadLine();

                if (pinGuess == pin)
                {
                    string x;
                    Console.Write("How much money would you like to withdraw: ");
                    x = Console.ReadLine();

                    Console.WriteLine("You have withdrawed " + x + " dollars!");
                    Console.WriteLine("Come back soon!");
                    Console.ReadLine();
                } else
                {
                    Console.WriteLine("Get lost idiot");
                    Console.ReadLine();
                }
            }
        }
    }
}
