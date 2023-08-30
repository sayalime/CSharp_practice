using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_interface
{
   interface Person
    {
        void get(string  name);
    }
    class Student : Person
    { 
        string name;
        public void get(string name)
        {
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine(this.name);
        }
    }
}
