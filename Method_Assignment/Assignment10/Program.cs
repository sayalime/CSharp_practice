using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    //create a function named "ChangeChar" to modify a letter in a certain position (0 based ) of a string ,replacing it with a different letter
    internal class Program
    {
        static string ChangeChar(String str,int pos,char newStr)
        {
            if (pos == 0 || pos >= str.Length)
            {
                return str;
            }
            char[] arr = str.ToCharArray();
            arr[pos] = newStr;
            return new string(arr);
        }
        static void Main(string[] args)
        {
            string strr=ChangeChar("sayali", 2, 'e');
            Console.WriteLine(strr);
            Console.ReadKey();
        }
    }
}
