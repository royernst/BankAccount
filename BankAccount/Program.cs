using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            Savings savings = new Savings("goatcheese");
            Console.WriteLine(savings.AccountNumber);
        }
    }
}
