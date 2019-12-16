using System;
using System.Threading;

namespace ClassObjectInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Objects Initialize");
            BankAccount account = new BankAccount("A101", 1000);
          
            Console.WriteLine($"Initial Balance is {account.Balance}");
            Console.WriteLine($"Your current balance is {account.Withdrawal(500)}");
            Console.WriteLine($"Your current balance is {account.Deposit(5000)}");
            Console.ReadKey();
            //Console.ReadKey(); //Destructor seeing at for ctr+f5 button press without Console.ReadKey() at
            //.NET Project, .Net Core automatically release garbage collector;
        }
    }
    class BankAccount: IBankAccount
    {
        public BankAccount(string accountNo, double initialBalance)
        {
            this.Balance = initialBalance;
            this.AccountNo = accountNo;
        }
        public string AccountNo { get; private set; }
        public double Balance { get; private set; }
        public double Withdrawal(double amount)
        {
            return this.Balance - amount;
        }
        public double Deposit(double amount)
        {
            return this.Balance + amount;
        }

        public static string AccountStatus()
        {
            return "Current/Saving";
        }
        ~BankAccount()
        {
            Console.WriteLine("The Destructor is call");
        }
    }
}
