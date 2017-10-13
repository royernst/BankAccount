using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Account
    {
        //Fields
        protected string accountNumber;
        protected static double checkingBalance;
        protected static double savingsBalance;
        protected string accountType;
        protected static double totalBalance = checkingBalance + savingsBalance;

        //Properties
        public abstract string AccountNumber
        { get; set; }

        //Constructors
        public Account()
        {
            //default constructor
        }


        //Methods
        //View account information
        public void AccountInfo()
        {
            Console.WriteLine("Account number: {0}", accountNumber);
            CurrentBalance();
        }

        //Check current balance
        public virtual void CurrentBalance()
        {
            Console.WriteLine("Your current balance is ${0}.", totalBalance);
        }

        //Transactions
        protected virtual void Withdrawal(double transactionAmount)
        {
            Math.Round(transactionAmount, 2, MidpointRounding.AwayFromZero);
            totalBalance -= transactionAmount;
            Math.Round(totalBalance, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine("Deposited ${0}.", transactionAmount);
            CurrentBalance();
        }

        protected virtual void Deposit(double transactionAmount)
        {
            Math.Round(transactionAmount, 2, MidpointRounding.AwayFromZero);
            totalBalance += transactionAmount;
            Math.Round(totalBalance, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine("Deposited ${0}.", transactionAmount);
            CurrentBalance();
        }
    }
}
