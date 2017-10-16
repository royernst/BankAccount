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
            Console.WriteLine();//intentionally left blank
            Console.WriteLine("Account Number: {0}", accountNumber);
            Console.WriteLine("Account Type: {0}", accountType);
            CheckBalance();
        }

        //Check current balance
        public void CheckBalance()
        {
            if (accountBalance < 0)
            {
                Console.WriteLine();//intentionally left blank
                Console.WriteLine("Account overdrawn.  Please deposit more funds");
                Console.WriteLine("Current Balance: ${0}", Math.Round(accountBalance, 2));
            }
            else
            {
                Console.WriteLine();//intentionally left blank
                Console.WriteLine("Current Balance: ${0}", Math.Round(accountBalance, 2));
            }
        }

        //Transactions
        //Withdrawal
        public virtual void Withdrawal(double withdrawalAmount)
        {
            Math.Round(withdrawalAmount, 2, MidpointRounding.AwayFromZero);
            accountBalance -= withdrawalAmount;
            Math.Round(accountBalance, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine("\nWithdrew ${0}.", withdrawalAmount);
            CheckBalance();
        }

        //Deposit
        public void Deposit(double depositAmount)
        {
            Math.Round(depositAmount, 2, MidpointRounding.AwayFromZero);
            accountBalance += depositAmount;
            Math.Round(accountBalance, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine("\nDeposited ${0}.", depositAmount);
            CheckBalance();
        }
    }
}
