using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        //Fields
        //user name
        private string userName;
        //number of accounts (checking, savings, or both)
        private int numberOfAccounts;
        //client full name
        private string fullName;
        //client's bank routing number
        private string routingNumber;

        //Properties
        public string UserName
        {
            get{ return this.userName; }
            set{ this.userName = value; }
        }
        public int NumberOfAccounts
        {
            get { return this.numberOfAccounts; }
            set { this.numberOfAccounts = value; }
        }
        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }
        //Constructors
        public Client()
        {
            //default constructor
        }

        public Client(string userName, string fullName, int numberOfAccounts, string routingNumber)
        {
            this.userName = userName;
            this.fullName = fullName;
            this.numberOfAccounts = numberOfAccounts;
            this.routingNumber = routingNumber;
        }

        //Methods
        public void ClientInfo()
        {
            Console.WriteLine("CLIENT ACCOUNT INFORMATION");
            Console.WriteLine("Username: {0}", userName);
            Console.WriteLine("Full Name: {0}", fullName);
            Console.WriteLine("Total number of accounts: {0}", numberOfAccounts);
            Console.WriteLine("Bank routing number: {0}", routingNumber);
        }
    }
}
