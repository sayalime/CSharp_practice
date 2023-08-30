using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int len=arr.Length;
            for (int i = 0; i < len; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = arr.Length-1;i >0;i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
