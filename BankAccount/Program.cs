﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring the global variables I'll be using for the program class
            int topMenu;
            char subMenu;
            //instantiating 3 classes
            Client user = new Client("JJax12345", "Joe Jackson", 2, "1491721");
            Checking checkingAccount = new Checking("741776", 5000.00d);
            Savings savingsAccount = new Savings("1002119", 2500.00d);



            //Welcomes user and prompts them to select an option
            Console.WriteLine("Welcome to the Bank of Knox remote account program.");
            Console.WriteLine("\nCurrently logged in under {0}.", user.UserName);
            Console.WriteLine("\nPlease select an option below via the corresponding number:");
            Console.WriteLine();
            //main menu
            do
            {
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");
                Console.Write("\nWhat would you like to do? ");
                topMenu = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (topMenu == 1)
                {
                    user.ClientInfo();
                    Console.WriteLine("Checking account number: {0}", checkingAccount.AccountNumber);
                    Console.WriteLine("Savings account number: {0}", savingsAccount.AccountNumber);
                    Console.WriteLine();
                }
                else if (topMenu == 2)
                {
                    //sub-menu loop
                    do
                    {
                        Console.WriteLine("\nPlease choose the account you would like to check: ");
                        Console.WriteLine("a. Checking Account");
                        Console.WriteLine("b. Savings Account");
                        Console.WriteLine("c. Main Menu");
                        Console.WriteLine();
                        subMenu = char.Parse(Console.ReadLine().Trim().ToLower());
                        if (subMenu == 'a')
                        {
                            checkingAccount.CheckBalance();
                        }
                        else if (subMenu == 'b')
                        {
                            savingsAccount.CheckBalance();
                        }
                        else if (subMenu != 'a' && subMenu != 'b' && subMenu != 'c')
                        {
                            Console.WriteLine("Please enter a valid choice");
                        }
                    } while (subMenu != 'c');

                }
                else if (topMenu == 3)
                {
                    //sub-menu loop
                    do
                    {
                        Console.WriteLine("\nPlease choose the account you would like to deposit funds to: ");
                        Console.WriteLine("a. Checking Account");
                        Console.WriteLine("b. Savings Account");
                        Console.WriteLine("c. Main Menu");
                        Console.WriteLine();
                        subMenu = char.Parse(Console.ReadLine().Trim().ToLower());
                        if (subMenu == 'a')
                        {
                            Console.WriteLine("\nHow much would you like to deposit?");
                            checkingAccount.Deposit(double.Parse(Console.ReadLine()));
                        }
                        else if (subMenu == 'b')
                        {
                            Console.WriteLine("\nHow much would you like to deposit?");
                            savingsAccount.Deposit(double.Parse(Console.ReadLine()));
                        }
                        else if (subMenu != 'a' && subMenu != 'b' && subMenu != 'c')
                        {
                            Console.WriteLine("Please enter a valid choice");
                        }
                    } while (subMenu != 'c');
                }
                else if (topMenu == 4)
                {
                    //sub-menu loop
                    do
                    {
                        Console.WriteLine("\nPlease choose the account you would like to withdraw funds from: ");
                        Console.WriteLine("a. Checking Account");
                        Console.WriteLine("b. Savings Account");
                        Console.WriteLine("c. Main Menu");
                        Console.WriteLine();
                        subMenu = char.Parse(Console.ReadLine().Trim().ToLower());
                        if (subMenu == 'a')
                        {
                            Console.WriteLine("\nHow much would you like to withdraw?");
                            checkingAccount.Withdrawal(double.Parse(Console.ReadLine()));
                        }
                        else if (subMenu == 'b')
                        {
                            Console.WriteLine("\nHow much would you like to withdraw?");
                            savingsAccount.Withdrawal(double.Parse(Console.ReadLine()));
                        }
                        else if (subMenu != 'a' && subMenu != 'b' && subMenu != 'c')
                        {
                            Console.WriteLine("Please enter a valid choice");
                        }
                    } while (subMenu != 'c');
                }
                else if (topMenu > 5)
                {
                    Console.WriteLine("Please enter a valid choice.");
                    Console.WriteLine();
                }
            } while (topMenu != 5);
            Console.WriteLine("\nThank you for banking with us.");
            Console.WriteLine("\nHave a nice day!");
            Console.WriteLine();
        }
        
    }
}
