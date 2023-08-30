using System;

namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8) Write a C# program to check if a given positive number is a multiple of 3 or 7.
            Console.WriteLine("Enter Number");
            int no = Convert.ToInt32(Console.ReadLine());

            if (no > 0)
            {
                if (no % 3 == 0 || no % 7 == 0)
                {
                    Console.WriteLine($"This {no} is a multiple of 3 or 7");
                }
                else
                {
                    Console.WriteLine($"This {no} is not a multiple of 3 or 7");
                }
            }
            Console.ReadLine();
        }
    }
}
