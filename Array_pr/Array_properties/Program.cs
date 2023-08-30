using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_properties
{
    internal class Program
    {
        static void Print(string s, int[] arr)
        {
            Console.Write(s);
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
        }
        public static void Main(string[] args)
        {
            /*int size = Convert.ToInt32(Console.ReadLine());
            int[] arr1 =new int[size];

            Console.WriteLine(arr1.IsFixedSize);
            Console.WriteLine(arr1.IsReadOnly);
            Console.WriteLine(arr1.Length);
            Console.WriteLine(arr1.Rank);
            Console.ReadLine();*/

        int[] arr = { 5, 99, 7, 11, 10, };
        int[] cpyarr = new int[5];

        Array.Sort(arr);
        Print("Sorted Array: ", arr);

        Array.Copy(arr, cpyarr, arr.Length);
        Print("\nCopied Array: ", cpyarr);

        Array.Reverse(arr);
        Print("\nReverse Array: ", arr);

        Array.Clear(arr, 0, 3);
        Print("\nClear Array: ", arr);
            Console.WriteLine();

            Console.WriteLine("Index of an element 99 is {0}", Array.IndexOf(arr, 99));
            //IndexOf method returns the index of an element starting from 0

            Console.WriteLine("Length of the Array is {0}", arr.GetLength(0));
            //GetLength method return the lenght of an array by providing dimension (like zero-dimension)

            Console.WriteLine("The value at 4 index is {0}", arr.GetValue(4));
            //GetValue method returns an element at specified position starting from 0

            Console.WriteLine("The Upper bound of the array is {0}", arr.GetUpperBound(0));
            //UpperBound method returns index of the last element of the specified dimension in the array

            Console.WriteLine("The Lower bound of the array is {0}", arr.GetLowerBound(0));
            Console.ReadLine();

    }

    }
}
