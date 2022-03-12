using System;
using System.IO;
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
            // Start the Program
            CardNewMethod();
        }

        // Card New Guess method
        public static void CardNewMethod()
        {
            Console.Write("Existing account or New Account: ");
            string newAccOrNew = Console.ReadLine();

            // New account variables
            string newAcc = "";
            string newPin = "";

            // This is a loop that iterates tnrough itself to make sure no funny buisness happens
            while (true)
            {
                if (newAccOrNew == "New Account" || newAccOrNew == "New account" || newAccOrNew == "new Account" || newAccOrNew == "new account")
                {
                    Console.Write("Please enter your new Card Number: ");
                    newAcc = Console.ReadLine();

                    Console.Write("Please enter your new Pin: ");
                    newPin = Console.ReadLine();

                    Console.WriteLine("Your Account has been Created");
                    Console.WriteLine("Your account number is: " + newAcc);
                    Console.WriteLine("Your Pin number is " + newPin);
                    Console.ReadLine();

                    CardGuessMethod(newAcc, newPin);
                }
                else if (newAccOrNew == "Existing Account" || newAccOrNew == "Exisiting account"  || newAccOrNew == "existing Account" || newAccOrNew == "existing account")
                {
                    CardGuessMethod(newAcc, newPin);
                }
                else
                {
                    Console.WriteLine("Choose one of the options");
                    CardNewMethod();
                }
            }
        }

        // Card Guess Method, this gives you access to each Card
        public static void CardGuessMethod(string aString, string bString)
        {
            string cardNumber = "1111 1111";
            string cardNumberGuess;

            while (true)
            {
                Console.Write("Enter your card Number: ");
                cardNumberGuess = Console.ReadLine();

                if(cardNumberGuess == cardNumber)
                {
                    PinGuessMethod(bString);
                }
                if (cardNumberGuess == aString)
                {
                    PinGuessMethod(bString);
                }
                else
                {
                    Console.WriteLine("Card Invalid");
                    Console.WriteLine("Please Enter a valid Card");
                    Console.ReadLine();
                }
            }
        }

        // Pin guess makes sure you know the pin before you are given access
        public static void PinGuessMethod(string bString)
        {
            string pin = "12345";
            string pinGuess = "";

            string[] gueses = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            
            foreach (string guess in gueses)
            {
                while (pinGuess != pin || pinGuess != bString)
                {
                    Console.Write("Please enter your pin: ");
                    pinGuess = Console.ReadLine();

                    if (pinGuess == pin)
                    {
                        MethodsBank();
                        break;
                    }
                    else if (pinGuess == bString)
                    {
                        MethodsBank();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter your pin.");
                    }
                }
                Console.WriteLine("You've been locked out");
                Console.WriteLine("Quit Now.");
                Environment.Exit(0);
            }
        }

        // This method transfers you to what funtion you want to go to. It's like the house funtion
        public static void MethodsBank()
        {
            string functions;

            List<string> withDraws = new List<string>();
            withDraws.Add("Withdraw");
            withDraws.Add("withdraw");
            withDraws.Add("with draw");


            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Withdraw, Transfer, Balance, History or Log out");
                Console.Write("Please write here: ");
                functions = Console.ReadLine();

                if (withDraws.Contains(functions))
                {
                    WithdrawMoney();
                    break;
                }
                else if (functions == "Transfer" || functions == "transfer")
                {
                    TransferMoney();
                    break;
                }
                else if (functions == "Balance" || functions == "balance")
                {
                    Balance();
                    break;
                }
                else if (functions == "History" || functions == "history")
                {
                    History();
                    break;
                }
                else if (functions == "Log out" || functions == "log out" || functions == "logout")
                {
                    Console.WriteLine("Thanks for Banking with us");
                    Console.WriteLine("Press enter to log out.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please write one of the options.");
                }
            }
        }

        // This method allows you to withdraw money. But it has a limit of $1000
        public static void WithdrawMoney()
        {
            int withDrawnMoney;

            try
            {
                Console.Write("How much money would you like to Withdraw: ");
                withDrawnMoney = Convert.ToInt32(Console.ReadLine());


                if (withDrawnMoney >= 1000)
                {
                    Console.WriteLine("Error 20182: Invalid ammount withdraw has to be less that $1000");
                    WithdrawMoney();
                }
                else
                {
                    Console.WriteLine("You have Withdrawn " + withDrawnMoney + " dollars!");
                    MethodsBank();
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                WithdrawMoney();
            }
        }
        
        // This method allows you to Transfer money. But also has a limit of $1000
        public static void TransferMoney()
        {
            while (true)
            {
                int transfer;

                Console.Write("How much money would you like to Transfer: ");
                transfer = Convert.ToInt32(Console.ReadLine());

                if (transfer >= 1000)
                {
                    Console.WriteLine("Error 20182: Invalid ammount transfer has to be less that $1000");
                }
                else
                {
                    Console.WriteLine("You have Transfered " + transfer + " dollars!");
                    MethodsBank();
                    break;
                }
            }
        }

        // This method calles a class which then gives you a random number between 1000 and 10000
        public static void Balance()
        {
            Balance balance = new Balance();
            int balance_Full = 0;

            if(balance._isExecuted == false)
            {
                balance_Full = balance.BalanceFull();
                balance._isExecuted = true;
            }

            Console.WriteLine("You have $" + balance_Full + "!");

            MethodsBank();
        }

        public static void History()
        {
            String line;

            try 
            {
                StreamReader sr = new StreamReader("C:\\Users\\dhruv\\Desktop\\Visual Studio 2022\\ATM Project\\History.txt");
                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }   
            catch (Exception e)
            {
                Console.WriteLine("Exception " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block");
            } 
        }
    }
}
