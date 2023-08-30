using System;

namespace Assignment11
{
    internal class Program
    {
        // Create a function named "IsPrime" which receives an integer number and returns true if it is prime or false if it is not; 
        static bool IsPrime(int no)
        {
            if (no <= 1)
            {
                return false;
            }

            for (int i = 2; i <= no / 2; i++)
            {
                if (no % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            bool isSevenPrime = IsPrime(8);
            Console.WriteLine(isSevenPrime);
            Console.ReadKey();
        }
    }
}
