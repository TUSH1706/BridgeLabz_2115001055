using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_2_2025
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }

        protected string AccountHolder { get; set; }

        private double Balance;

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}. Remaining Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }

        public double GetBalance()
        {
            return Balance;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Account Holder: {AccountHolder}, Balance: {Balance}");
        }

    }

    public class SavingsAccount : BankAccount
    {
        private double InterestRate;

        public SavingsAccount(string accountNumber, string accountHolder, double balance, double interestRate)
            : base(accountNumber, accountHolder, balance)
        {
            InterestRate = interestRate;
        }

        public void CalculateInterest()
        {
            double interest = GetBalance() * (InterestRate / 100);
            Console.WriteLine($"Interest Earned: {interest}");
        }


        public override void DisplayDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Account Holder: {AccountHolder}, Balance: {GetBalance()}, Interest Rate: {InterestRate}%");
        }
    }

}
