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
        string accountNumber = "value";
        //Properties
        public override string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //Constructors
        public Savings()
        {

        }

        public Savings(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        //Methods
        public override void CurrentBalance()
        {
            Console.WriteLine("Your current balance is ${0}.", savingsBalance);
        }
        protected override void Withdrawal(double transactionAmount)
        {
            Math.Round(transactionAmount, 2, MidpointRounding.AwayFromZero);
            do
            {
                if (transactionAmount <= savingsBalance)
                {
                    savingsBalance -= transactionAmount;
                    Math.Round(savingsBalance, 2, MidpointRounding.AwayFromZero);
                    Console.WriteLine("Deposited ${0}.", transactionAmount);
                }
                else
                {
                    Console.WriteLine("Invalid amount.  Cannot withdraw more than ${0}.", minBalance);
                }
            } while (transactionAmount > savingsBalance);



            CurrentBalance();
        }

        protected override void Deposit(double transactionAmount)
        {
            Math.Round(transactionAmount, 2, MidpointRounding.AwayFromZero);
            savingsBalance += transactionAmount;
            Math.Round(savingsBalance, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine("Deposited ${0}.", transactionAmount);
            CurrentBalance();
        }
    }
}
