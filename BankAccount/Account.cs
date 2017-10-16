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
        protected double accountBalance;
        protected string accountType;

        //Properties
        public abstract string AccountNumber
        { get; set; }

        //Constructors
        public Account()
        {
            //default constructor
        }


        //Methods
        //Because I have to
        public abstract void ProjectRequirement();
        
        //View account information
        protected void AccountInfo()
        {
            Console.WriteLine("Account Number: {0}", accountNumber);
            Console.WriteLine("Account Type: {0}", accountType);
            CheckBalance();
        }

        //Check current balance
        public void CheckBalance()
        {
            Console.WriteLine("Current Balance: {0}", accountBalance);
        }

        //Transactions
        //Withdrawal
        protected virtual void Withdrawal(double transactionAmount)
        {
            Math.Round(transactionAmount, 2, MidpointRounding.AwayFromZero);
            accountBalance -= transactionAmount;
            Math.Round(accountBalance, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine("Withdrew ${0}.", transactionAmount);
            CheckBalance();
        }

        //Deposit
        protected void Deposit(double transactionAmount)
        {
            Math.Round(transactionAmount, 2, MidpointRounding.AwayFromZero);
            accountBalance += transactionAmount;
            Math.Round(accountBalance, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine("Deposited ${0}.", transactionAmount);
            CheckBalance();
        }
    }
}
