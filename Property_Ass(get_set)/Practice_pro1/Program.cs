using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_pro1
{
    //Write a c# program to demonstrate get and set 
    internal class Program
    {
        private string Name;
        private int age;
        private string location;
        public string MyName
        {
            get
            {
                return "${ Name},{ location}";
            }
            set
            {
                Name = value;
                location = value;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Name = "Sayali";
            p.location = "pune";
            Console.WriteLine(p.Name);
            Console.WriteLine(p.location);
            Console.ReadKey();
        }
    }
}
