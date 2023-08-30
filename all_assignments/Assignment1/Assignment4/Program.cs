using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    //4. Describe the difference between iterating through a List using a for loop and using a foreach loop.Provide
    //examples for both approaches.
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() {"abc","pqr","lmn","stu"};
            Console.WriteLine("Using for each loop");
            foreach (string s in list)
            {
                Console.WriteLine( s);
            }
            Console.WriteLine("Using for loop");
            for (int i=list.Count-1; i>0; i--)
            {
                Console.WriteLine(list[i]);
            }
            
            Console.ReadLine();
        }
    }
}
