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
        //private bool overdraft = false;

        //Properties
        public override string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //Constructors
        //default constructor
        public Checking()
        {
            this.accountType = "Checking";
        }

        //constructor to populate class fields
        public Checking(string accountNumber, double accountBalance)
        {
        this.accountNumber = accountNumber;
        this.accountBalance = accountBalance;
        this.accountType = "Checking";
        }


        //Methods
        public override void ProjectRequirement()
        {
            //just putting this here because we're required to...
        }

    }
}
