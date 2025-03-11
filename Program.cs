using System.ComponentModel;
using BankAccount;

public class Test
{
    public static void Main(string[] args)
     { 
        BankAccount.BankAccount acc1 = new BankAccount.BankAccount("bob", 1000);
        acc1.Deposit(1524.4f);
        acc1.Deposit(-200); 
        acc1.Withdraw(1000.20f);
        acc1.Withdraw(500000);

        //printing list of transactions
        foreach (string transactions in acc1.Transactions)
        {
            Console.WriteLine(transactions);
        }
    }
}