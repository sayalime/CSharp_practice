using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program

    {
        static int sum(int a ,int b)
        {
            return a + b;
        }

        static int arr_sum(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
                
            }
            return sum;

        }
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter values");
             int s = Convert.ToInt32(Console.ReadLine());
             int c = Convert.ToInt32(Console.ReadLine());
             int res=sum(s, c);
             Console.WriteLine(res);*/
            int[] parr = { 2, 3, 4, 5 };
            int ares=arr_sum(parr);
            Console.WriteLine("arraySum : " + ares);
            Console.Read();
        }
    }
}
