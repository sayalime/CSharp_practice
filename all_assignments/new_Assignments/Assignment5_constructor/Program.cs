using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_constructor
{
    public class Employee
    {
        private int id;
        private string Name;
        private int salary;
        public int getId
        {
            get { 
            return id;
            }
        }
        public string getName
        {
            get
            {
                return Name;
            }
        }
        public int getsalary
        {
            get
            {
                return salary;
            }
        }

        public Employee( int Id,string Name,int salary)
        { 
            id = Id;
            this.Name = Name;   
            this.salary = salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1,"abc",10000);
            Console.WriteLine(emp.getId);
            Console.WriteLine(emp.getName);
            Console.WriteLine(emp.getsalary);
            Console.ReadKey();

        }
    }
}
