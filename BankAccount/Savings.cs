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
        private double minBalance = 10d;
        
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
        public override void Withdrawal(double transactionAmount)
        {
            double withdrawalAmount = transactionAmount;
            Math.Round(withdrawalAmount, 2, MidpointRounding.AwayFromZero);
            while ((accountBalance - withdrawalAmount) < minBalance)
            {
                Console.WriteLine("\nInvalid amount entered.  Balance cannot go below ${0}.", minBalance);
                CheckBalance();
                Console.Write("\nPlease enter a valid amount.  ");
                withdrawalAmount = double.Parse(Console.ReadLine().Trim());
            }
            accountBalance -= withdrawalAmount;
            Math.Round(accountBalance, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine("\nWithdrew ${0}.", withdrawalAmount);
            CheckBalance();
             
        }
    }
}
