using System;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal setBalance)
    {
        balance = setBalance;
    }

    public void CashIn(decimal cashIn)
    {
        if (cashIn <= 0)
        {
            Console.WriteLine("Сумма для пополнения должна быть больше 0.");
            return;
        }

        balance += cashIn;
        Console.WriteLine($"Внесено: {cashIn:C}. Текущий баланс: {balance:C}.");
    }

    public void CashOut(decimal cashOut)
    {
        if (cashOut <= 0)
        {
            Console.WriteLine("Сумма для снятия должна быть больше 0.");
            return;
        }

        if (cashOut > balance)
        {
            Console.WriteLine("Недостаточно средств на счете.");
            return;
        }

        balance -= cashOut;
        Console.WriteLine($"Снято: {cashOut:C}. Текущий баланс: {balance:C}.");
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
        account.CashOut(739m); 
        account.CashOut(1234m); 

        Console.WriteLine($"Текущий баланс: {account.GetBalance():C}");
        Console.ReadKey();
    }
}
