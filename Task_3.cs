using System;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal setBalance)
    {
        balance = setBalance;
    }

    public void Deposit(decimal CashIn)
    {
        if (CashIn <= 0)
        {
            Console.WriteLine("Сумма для пополнения должна быть больше 0.");
            return;
        }

        balance += CashIn;
        Console.WriteLine($"Внесено: {CashIn:C}. Текущий баланс: {balance:C}.");
    }

    public void Withdraw(decimal CashOut)
    {
        if (CashOut <= 0)
        {
            Console.WriteLine("Сумма для снятия должна быть больше 0.");
            return;
        }

        if (CashOut > balance)
        {
            Console.WriteLine("Недостаточно средств на счете.");
            return;
        }

        balance -= CashOut;
        Console.WriteLine($"Снято: {CashOut:C}. Текущий баланс: {balance:C}.");
    }

    public decimal GetBalance()
    {
        return balance;
    }

}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(0m);

        account.Deposit(999m); 
        account.Withdraw(739m); 
        account.Withdraw(1234m); 

        Console.WriteLine($"Текущий баланс: {account.GetBalance():C}");
        Console.ReadKey();
    }
}
