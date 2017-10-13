using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account
    {
        //Fields
        private bool overdraft = false;

        //Properties
        public override string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //Constructors
        public Checking()
        {

        }

        //Methods
        public override void CurrentBalance()
        {
            Console.WriteLine("Your current balance is ${0}.", checkingBalance);
        }
        protected override void Withdrawal(double transactionAmount)
        {
            Math.Round(transactionAmount, 2, MidpointRounding.AwayFromZero);
            checkingBalance -= transactionAmount;
            Math.Round(checkingBalance, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine("Deposited ${0}.", transactionAmount);
            CurrentBalance();
        }

        protected override void Deposit(double transactionAmount)
        {
            Math.Round(transactionAmount, 2, MidpointRounding.AwayFromZero);
            checkingBalance += transactionAmount;
            Math.Round(checkingBalance, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine("Deposited ${0}.", transactionAmount);
            CurrentBalance();
        }

        private void Overdraft()
        {
            if (overdraft = true)
            {
                savingsBalance =- Math.Abs(checkingBalance);
            }
            else
            {
                Console.WriteLine("Overdraft protection is not enabled.");

            }
        }
    }
}
