
using System;

namespace Assignment1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ac1 = new BankAccount("Abc", 10000);

            Console.WriteLine("Account Information:");
            ac1.Display();

            ac1.Deposit(100);
            ac1.Withdraw(200);
            Console.WriteLine("Updated Account Information:");
            ac1.Display();
            Console.ReadKey();
        }
    }
}