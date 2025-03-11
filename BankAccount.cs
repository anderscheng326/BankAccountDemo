/*
UML
Class: BankAccount
 Fields:
    -accountID: str
    -balance: float
    -transactions: List<string>

 Properties:
    +AccountID: str
    +Balance: float
    +Transactions: List<string>

 Methods:
    +Withdraw(amount: float): void
    +Deposit(amount: float): void

 Constructor:
    +BankAccount(name: str, initalBalance: float)
*/

using System.Diagnostics.Contracts;
using System.Transactions;

namespace BankAccount{
    public class BankAccount
    {
        string accountID ="";
        double balance;
        List<string> transactions = new List<string>();

        public BankAccount(string name, double initialBalance)
        {
            if (initialBalance < 0 || name == "" ) {
            Console.WriteLine("Invalid initial balance.");
            }
            else{
            this.accountID = name;
            this.balance = initialBalance;
            this.transactions = new List<string>();
            transactions.Add($"New Account:{accountID} - Initial Balance: ${balance}");
            }
        }

        public string AccountID
        {
            get {return accountID;}
        }

        public double Balance
        {
            get {return balance;}
        } 

        public List<string> Transactions
        {
            get {return transactions;}
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                transactions.Add($"-Deposit: $ {amount} - Updated Balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && balance > amount)
            {
                balance -= amount;
                transactions.Add($"-Withdraw: $ {amount} - Updated Balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal.");
            }
        }
    }
}