using System;

namespace Assignment1
{
    internal class BankAccount
    {
        private static int AccountNoc = 1;
        private readonly int accountNo;

        public string OwnerName { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string ownerName, decimal balance)
        {
            accountNo = AccountNoc++;
            OwnerName = ownerName;
            Balance = balance;
        }

        public void Deposit(decimal amt)
        {
            Balance = Balance + amt;
            Console.WriteLine($"Deposited amount: {amt}. New balance: {Balance}");
        }

        public void Withdraw(decimal amt)
        {
            if (amt <= Balance)
            {
                Balance = Balance - amt;
                Console.WriteLine($"Withdrawn amount: {amt}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance for withdrawal.");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Account Number: {accountNo}");
            Console.WriteLine($"Owner Name: {OwnerName}\nBalance: {Balance}");
        }
    }
}
