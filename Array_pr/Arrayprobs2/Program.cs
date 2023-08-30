using System;

namespace Arrayprobs2
{
    internal class Program
    {
        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Write a C# Sharp program to copy the elements of one array into another array.
            int[] arr1 = { 2, 3, 5, 4 };
            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.Write("First array: ");
            PrintArray(arr1);

            Console.Write("Second Array: ");
            PrintArray(arr2);

            Console.ReadKey();
        }
       
       
    }
}
