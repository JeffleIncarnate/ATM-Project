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
                    Console.ReadLine();
                }
            }
        }

        public static void MethodsBank()
        {
            string functions;

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Withdraw, Log out, Transfer into your account");
            Console.Write("Please write here: ");
            functions = Console.ReadLine();

            if (functions == "Withdraw")
            {
                WithdrawMoney();
            }
            else if (functions == "Log out")
            {
                Console.WriteLine("Thanks for Banking with us.");
                Console.WriteLine("Press enter to log out");
                Console.ReadLine();
                CardGuessMethod();
            }
            else if (functions == "Transfer")
            {
                TransferMoney();
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
                    MethodsBank();
                }
                else
                {
                    Console.WriteLine("Get lost idiot");
                }
            }
        }

        public static void WithdrawMoney()
        {
            int withDrawnMoney;

            Console.Write("How much money would you like to Withdraw: ");
            withDrawnMoney = Convert.ToInt64(Console.ReadLine());

            if (withDrawnMoney >= 1000)
            {
                Console.WriteLine("Error 20182: Invalid ammount withdraw has to be less that $1000");
            }else
            {
                Console.WriteLine("You have Withdrawn " + withDrawnMoney + " dollars!");
            }
        }

        public static void TransferMoney()
        {
            float transfer;

            Console.Write("How much money would you like to Transfer: ");
            transfer = Convert.ToInt64(Console.ReadLine());

            if (transfer >= 1000)
            {
                Console.WriteLine("You have Transfered " + transfer + " dollars!");
                MethodsBank();
            }
        }
    }
}
