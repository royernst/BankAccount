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
        public string AccountNumber
        {
            get { return this.accountNumber; }
        }

        public double AccountBalance
        {
            get { return this.accountBalance; }
        }

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
        }
            
        //Check current balance
        public void CurrentBalance()
        {
            Console.WriteLine("Your current balance is ${0}.", accountBalance);
        }

        //Transactions
        protected virtual void Withdrawal(double transactionAmount)
        {
            Math.Round(transactionAmount, 2, MidpointRounding.AwayFromZero);
            accountBalance -= transactionAmount;
            Math.Round(accountBalance, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine("Withdrew ${0}.", transactionAmount);
            CurrentBalance();
        }

        protected void Deposit(double transactionAmount)
        {
            Math.Round(transactionAmount, 2, MidpointRounding.AwayFromZero);
            accountBalance += transactionAmount;
            Math.Round(accountBalance, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine("Deposited ${0}.", transactionAmount);
            CurrentBalance();
        }
    }
}
