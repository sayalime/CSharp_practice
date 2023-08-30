using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace array1_print
{
    internal class Program
    {
        int sum = 0;
        public void Hello(int[] arr)
        {
            int len=arr.Length;
            for (int i = 0; i < len; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            /*int[] arr = { 1, 2, 3, 4, 5, 6, 7, 89 };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }*/
            int[] arr = { 1, 2, 3, 4, 5, 6, };
            int[] new_arr=new int[10];
            for (int i = 0; i < new_arr.Length; i++)
            {
                Convert.ToInt32(new_arr[i]);    
            }
            for (int i = 0; i < new_arr.length; i++)
            {

            }
            Program p= new Program();
            p.Hello(new_arr);
            Console.ReadLine();



        }
    }
}
