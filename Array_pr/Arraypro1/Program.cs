using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraypro1
{

    
    internal class Program
    {
        public static int maxnumber(int len,int[] arr)
        {
            Console.WriteLine("Without max Function");
            int maxEle = arr[0];
            for (int i = 1; i < len; i++)
            {
                if (arr[i] > maxEle)
                {
                    maxEle = arr[i];
                }
                Console.WriteLine("max element : " + maxEle);
            }

            return 0;

        }
        
        static void Main(string[] args)
        {
            //Find the maximum element in an array.
            Console.WriteLine("enter length of an array");
            int len=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            for(int i = 0; i < len; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var element in arr)
            {
                Console.Write(element);
                
            }
            int maxelement = arr.Max();
            Console.WriteLine($"Max element is : {maxelement}");
            maxnumber(len, arr);
            
            Console.ReadLine();

        }
    }
}
