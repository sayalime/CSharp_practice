using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_program
{
    internal class Program
    {
        private string Name;
       
        public  int Age { get; set; }
        public string Place { get; set; }
        public static void Main(string[] args)
        {
            Program P = new Program();
            P.Name = "Abc";
            P.Age = 23;
            P.Place = "Pune";
            Console.WriteLine($"Name : {P.Name} \n Age : {P.Age} \n Place : {P.Place} ");
            Console.ReadKey();
        }
    }
}
