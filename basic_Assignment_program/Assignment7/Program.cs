using System;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7) Write a C# program and compute the sum of an integer's digits.
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter digits");
            int[] arr = new int[size];
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You entered digits:");
            for (int i = 0; i < size; i++)
            {
                sum = sum + arr[i];
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Sum of the digits: " + sum);
            Console.ReadLine();
        }
    }
}
