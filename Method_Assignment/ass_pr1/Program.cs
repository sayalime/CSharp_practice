using System;

namespace ass_pr1
{
    internal class Program
    {
        static int[] arrSumAndMulti(int[] arr)
        {
            int sum = 0;
            int mul = 1;
            foreach (var item in arr)
            {
                sum += item;
                mul *= item;
            }
            int[] result = new int[] { sum, mul };
            return result;
        }

        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arrn = new int[size];
            for (int i = 0; i < size; i++)
            {
                arrn[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] res = arrSumAndMulti(arrn);
            Console.WriteLine("Sum of array elements: " + res[0]);
            Console.WriteLine("Multiplication of array elements: " + res[1]);
            Console.ReadKey();
        }
    }
}
