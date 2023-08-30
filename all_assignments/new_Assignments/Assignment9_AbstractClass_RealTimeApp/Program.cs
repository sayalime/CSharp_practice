using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9_AbstractClass_RealTimeApp
{
    public abstract class Bank
    {
        public string AccountHolder { get; set; }
        public string AccountNumber { get; set;}
        public decimal Balance { get; set; }

        public abstract void Deposite(decimal amount);
        public abstract void Withdraw(decimal amount);
    }
    public class SavingAccount : Bank
    {
        public override void Deposite(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"CheckingAccount after adding  deopsite Balance :  {Balance}");
        }
        public override void Withdraw(decimal amount)
        {
            if (Balance - amount > 0)
            {
                Balance -= amount;
                Console.WriteLine($"CheckingAccount after Withdraw Remainning Balance :{Balance}");
            }
        }
    }
    public class CheckingAccount : Bank
    {
        public override void Deposite(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"CheckingAccount after adding  deopsite Balance :  {Balance}");
        }
        public override void Withdraw(decimal amount)
        {
            if (Balance - amount > 0)
            {
                Balance -= amount;
                Console.WriteLine($"CheckingAccount after Withdraw Remainning Balance :{Balance}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount = new SavingAccount();
            savingAccount.AccountNumber = "1";
            savingAccount.AccountHolder = "sneha";
            savingAccount.Balance = 100;
            savingAccount.Deposite(300);
            savingAccount.Withdraw(100);

            CheckingAccount checkingAccount = new CheckingAccount();
            checkingAccount.AccountNumber = "2";
            checkingAccount.AccountHolder = "tejas";
            checkingAccount.Balance = 400;
            checkingAccount.Deposite(500);
            savingAccount.Withdraw(20);
            Console.ReadKey();
            
        }
    }
}
