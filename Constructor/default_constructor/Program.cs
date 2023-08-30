using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace default_constructor
{
    internal class Program
    {
        int a, b;
        public Program()
        {
            Console.WriteLine("hello");

        }
        public Program(int a,int b)
        {
            int res1=this.a = a;
            int res2=this.b = b;

            Console.WriteLine("a's value" + res1);
            Console.WriteLine("b's value" + res2);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A's and B's value");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            Program p2 = new Program(a, b);
            Console.ReadKey();
        }
    }
}
