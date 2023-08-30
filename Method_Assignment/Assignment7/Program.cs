using System;

namespace Assignment7
{
    internal class Program
    {
        static void FibonacciSeries(int digits)
        {
            int a = 0;
            int b = 1;
            int c;
            Console.Write("Fibonacci Series: " + a + ", " + b);

            for (int i = 2; i < digits; i++)
            {
                c = a + b;
                Console.Write(", " + c);
                a = b;
                b = c;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of digits in the Fibonacci Series: ");
            int size = Convert.ToInt32(Console.ReadLine());
            FibonacciSeries(size);
            Console.ReadKey();
        }
    }
}
