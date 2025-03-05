using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    public class BankSystem
    {
        public static string BankName = "SBI";
        private static int totalAccounts = 0;
        private static BankSystem[] accounts = new BankSystem[3]; // Fixed-size array
        private static int accountCount = 0;

        public readonly int AccountNumber;
        private string accountHolderName;
        private double balance;

        public BankSystem(string accountHolderName, int accountNumber, double initialDeposit)
        {
            this.accountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.balance = initialDeposit;
            totalAccounts++;
        }

        public static int GetTotalAccounts()
        {
            return totalAccounts;
        }
        public string GetAccountDetails()
        {
            return $"Bank Name: {BankName}\nAccount Holder: {accountHolderName}\nAccount Number: {AccountNumber}\nBalance: {balance}";
        }

        public static void AddAccount()
        {
            if (accountCount >= accounts.Length)
            {
                Console.WriteLine("Cannot add more accounts");
                return;
            }
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Account No: ");
            if (!int.TryParse(Console.ReadLine(), out int accNo))
            {
                Console.WriteLine("Invalid Account Number.");
                return;
            }

            Console.Write("Enter Initial Deposit: ");
            if (!double.TryParse(Console.ReadLine(), out double deposit))
            {
                Console.WriteLine("Invalid Deposit Amount.");
                return;
            }

            accounts[accountCount++] = new BankSystem(name, accNo, deposit);
            Console.WriteLine("Account Created!");

        }

        public static void DisplayAccount()
        {
            Console.Write("Enter Account No: ");
            if (!int.TryParse(Console.ReadLine(), out int accNo))
            {
                Console.WriteLine("Invalid Account Number.");
                return;
            }

            BankSystem account = null;
            foreach (var acc in accounts)
            {
                if (acc is BankSystem tempAcc && tempAcc.AccountNumber == accNo)
                {
                    account = tempAcc;
                    break;
                }
            }

            Console.WriteLine(account == null ? "Account not found." : account.GetAccountDetails());
        }
    }
}
