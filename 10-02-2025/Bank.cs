using System;
abstract class BankAccount
{
    public int AccountNumber { get; private set; }
    public string HolderName { get; private set; }
    protected double Balance;

    public BankAccount(int accountNumber, string holderName, double initialBalance)
    {
        AccountNumber = accountNumber;
        HolderName = holderName;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} into Account {AccountNumber}. New Balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public virtual void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C} from Account {AccountNumber}. Remaining Balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    public abstract void CalculateInterest();
}

class SavingsAccount : BankAccount
{
    private double interestRate;

    public SavingsAccount(int accountNumber, string holderName, double initialBalance, double interestRate)
        : base(accountNumber, holderName, initialBalance)
    {
        this.interestRate = interestRate;
    }

    public override void CalculateInterest()
    {
        double interest = Balance * interestRate / 100;
        Balance += interest;
        Console.WriteLine($"Interest added: {interest:C}. New Balance: {Balance:C}");
    }
}

class CurrentAccount : BankAccount
{
    public CurrentAccount(int accountNumber, string holderName, double initialBalance)
        : base(accountNumber, holderName, initialBalance)
    {
    }

    public override void CalculateInterest()
    {
        Console.WriteLine("Current accounts do not earn interest.");
    }
}

// Loanable interface
interface ILoanable
{
    void ApplyForLoan(double amount);
    bool CalculateLoanEligibility();
}

// LoanAccount implementing ILoanable
class LoanAccount : BankAccount, ILoanable
{
    private double loanLimit;
    private double loanBalance;

    public LoanAccount(int accountNumber, string holderName, double initialBalance, double loanLimit)
        : base(accountNumber, holderName, initialBalance)
    {
        this.loanLimit = loanLimit;
        loanBalance = 0;
    }

    public void ApplyForLoan(double amount)
    {
        if (amount > 0 && amount <= loanLimit)
        {
            loanBalance += amount;
            Console.WriteLine($"Loan of {amount:C} approved. Total Loan Balance: {loanBalance:C}");
        }
        else
        {
            Console.WriteLine("Loan amount exceeds the eligible limit.");
        }
    }

    public bool CalculateLoanEligibility()
    {
        return Balance >= (loanLimit * 0.2);
    }

    public override void CalculateInterest()
    {
        double interest = loanBalance * 0.05; 
        loanBalance += interest;
        Console.WriteLine($"Loan interest applied: {interest:C}. New Loan Balance: {loanBalance:C}");
    }
}
class Program
{
    static void Main()
    {
        SavingsAccount savings = new SavingsAccount(101, "Alice", 1000, 5);
        savings.Deposit(500);
        savings.CalculateInterest();
        savings.Withdraw(300);

        Console.WriteLine();

        CurrentAccount current = new CurrentAccount(102, "Bob", 2000);
        current.Deposit(1000);
        current.CalculateInterest();
        current.Withdraw(1500);

        Console.WriteLine();

        LoanAccount loan = new LoanAccount(103, "Charlie", 5000, 10000);
        loan.ApplyForLoan(2000);
        Console.WriteLine($"Loan Eligibility: {loan.CalculateLoanEligibility()}");
        loan.CalculateInterest();
    }
}