using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BankandAccountHoldersAssociation
{

    public class Bank
    {
        public string name;
        private List<Customer> customers;
        public Bank(string name)
        {
            this.name = name;
            customers = new List<Customer>();
        }

        public void openAccount(string customerName,double initialDeposit)
        {
            Customer customer = new Customer(customerName, this, initialDeposit);
            customers.Add(customer);
            Console.WriteLine($"Account opened for {customerName} with an initial deposit of {initialDeposit} Rs. in {name}.");
        }
    }
    public class Customer
    {
        public string name;
        private Bank bank;
        public double balance;

        public Customer(string name, Bank bank, double balance)
        {
            this.name = name;
            this.bank = bank;
            this.balance = balance;
        }

        public void viewBalance()
        {
            Console.WriteLine($"Balance for {name} in {bank.name}: {balance} Rs.");
        }

    }

    
}
