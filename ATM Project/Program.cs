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
            CardGuessMethod();

            PinGuessMethod();
        }

        public static void CardGuessMethod()
        {
            string cardNumber = "1111 1111";
            string cardNumberGuess = "";

            while (cardNumberGuess != cardNumber)
            {
                Console.Write("Enter your card Number: ");
                cardNumberGuess = Console.ReadLine();

                if(cardNumberGuess != cardNumber)
                {
                    Console.WriteLine("Card Invalid");
                    Console.WriteLine("Please Enter a valid Card");
                    Console.WriteLine(" ");
                    Console.ReadLine();
                }
            }
        }

        public static void PinGuessMethod()
        {
            string pin = "12345";
            string pinGuess = "";

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
                }
                else
                {
                    Console.WriteLine("Get lost idiot");
                }
            }
        }
    }
}
