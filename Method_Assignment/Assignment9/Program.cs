using System;

namespace Assignment9
{
    internal class Program
    {
        // Create a function that calculates the result of raising an integer to another integer
        static int CalculatePower(int no, int rno)
        {
            int res = 1;
            for (int i = 0; i < rno; i++)
            {
                res = res* no;
            }
            return res;
        }
        static void Main(string[] args)
        {
            int result = CalculatePower(2, 3);
            Console.WriteLine( result);
            Console.ReadKey();
        }
    }
}
