using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings : Account
    {
        //Fields
        private int minBalance = 0;
        
        //Properties
        public override string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //Constructors
        //default constructor
        public Savings()
        {
            accountType = "Savings";
        }

        //constructor to populate class fields
        public Savings(string accountNumber, double accountBalance)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.accountType = "Savings";
        }

        //Methods
        //account info
        

        //check current balance

        public override void ProjectRequirement()
        {
            //just putting this here because we're required to...
        }

        //transactions
        protected override void Withdrawal(double transactionAmount)
        {
            Math.Round(transactionAmount, 2, MidpointRounding.AwayFromZero);
            do
            {
                if (transactionAmount <= (accountBalance - minBalance))
                {
                    accountBalance -= transactionAmount;
                    Math.Round(accountBalance, 2, MidpointRounding.AwayFromZero);
                    Console.WriteLine("Deposited ${0}.", transactionAmount);
                }
                else
                {
                    Console.WriteLine("Invalid amount.  Cannot withdraw more than ${0}.", minBalance);
                }
            } while (transactionAmount > accountBalance);
            CheckBalance();
        }
    }
}
