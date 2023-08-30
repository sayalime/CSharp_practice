using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Teacher : Person
    {
        private string subject;

        public Teacher(string subject)
        {
            this.subject = subject;
        }

        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }
    }
}
