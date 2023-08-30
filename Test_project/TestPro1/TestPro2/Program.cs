using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPro2
{
    public class Program
    {
        public class Employee
        {
            public string Employee_name;
            public int Employee_id;
            public int salary;
            public virtual void Calculate(int amount)
            {

            }
        }
        public class Manager: Employee
        {
            public Manager(string Employee_name,int Employee_id,int salary)
            { 
                this.Employee_name = Employee_name;
                this.Employee_id = Employee_id;
                this.salary = salary;
            }
            public override void Calculate(int amount)
            {
                salary += amount;
                Console.WriteLine("manager salary" + salary);
            }
        }
        public class Developer : Employee
        {
            public Developer(string Employee_name, int Employee_id, int salary)
            {
                this.Employee_name = Employee_name;
                this.Employee_id = Employee_id;
                this.salary = salary;
            }
            public override void Calculate(int amount)
            {
                salary += amount;
                Console.WriteLine("Developer salary" + salary);
            }

        }
        public class SalesPerson : Employee
        {
            public SalesPerson(string Employee_name, int Employee_id, int salary)
            {
                this.Employee_name = Employee_name;
                this.Employee_id = Employee_id;
                this.salary = salary;
            }
            public override void Calculate(int amount)
            {
                salary += amount;
                Console.WriteLine("SalesPerson salary" + salary);
            }
        }
        static void Main(string[] args)
        {
            Manager manager = new Manager("abs", 1, 20000);
            manager.Calculate(2000);
            SalesPerson sales = new SalesPerson("ccc", 1, 4000);
            sales.Calculate(300);
            Developer developer = new Developer("ddd", 1, 40000);
            developer.Calculate(3000);
       
            Console.ReadKey();
        }
    }
}
