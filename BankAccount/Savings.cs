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
        //Properties
        //Constructors
        public Savings()
        {

        }

        //Methods
        protected override void Withdrawal(int transactionAmount)
        {
            accountBalance -= transactionAmount;
            CurrentBalance();
        }
    }
}
