using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountTypes
{
    class BankAccount
    {
        public string accountNumber;
        public double balance;

        public BankAccount(string accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public virtual void DisplayAccountType()
        {
            Console.WriteLine("General Bank Account");
        }
    }

    class SavingsAccount : BankAccount
    {
        public double interestRate;

        public SavingsAccount(string accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            this.interestRate = interestRate;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Savings Account");
        }
    }

    class CheckingAccount : BankAccount
    {
        public double withdrawalLimit;

        public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
            : base(accountNumber, balance)
        {
            this.withdrawalLimit = withdrawalLimit;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Checking Account");
        }
    }

    class FixedDepositAccount : BankAccount
    {
        public int depositTerm;

        public FixedDepositAccount(string accountNumber, double balance, int depositTerm)
            : base(accountNumber, balance)
        {
            this.depositTerm = depositTerm;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Fixed Deposit Account");
        }
    }



}
