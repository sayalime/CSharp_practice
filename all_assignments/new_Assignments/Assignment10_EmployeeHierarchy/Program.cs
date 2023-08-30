using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10_EmployeeHierarchy
{
    public class Employee
    {
        protected string Name;
        protected int Employee_Id;
        public virtual void  Calculate_salary(int Salary,int incentives)
        {
           
        }
    }
    public class Manager : Employee
    { 
        public Manager(int Employee_Id,string Name)
        {
            this .Employee_Id = Employee_Id;
            this .Name = Name;
        }
        public override void Calculate_salary(int Salary, int incentives)
        {
            Console.WriteLine($"Employee Id : {this.Employee_Id} \n Employee Name : {this.Name}");
            decimal totalSalary = Salary + incentives;
            Console.WriteLine("Total Salary : " + totalSalary);
        }
    }
    public class Developer : Employee
    {
        public Developer(int Employee_Id, string Name)
        {
            this.Employee_Id = Employee_Id;
            this.Name = Name;
        }
        public override void Calculate_salary(int Salary, int incentives)
        {
            Console.WriteLine($"Employee Id : {this.Employee_Id} \n Employee Name : {this.Name}");
            decimal totalSalary = Salary + incentives;
            Console.WriteLine("Total Salary : "+ totalSalary);
        }
    }
    public class SalesPerson : Employee
    {
        public SalesPerson(int Employee_Id, string Name)
        {
            this.Employee_Id = Employee_Id;
            this.Name = Name;
        }
        public override void Calculate_salary(int Salary, int incentives)
        {
            Console.WriteLine($"Employee Id : {this.Employee_Id} \n Employee Name : {this.Name}");
            decimal totalSalary = Salary + incentives;
            Console.WriteLine("Total Salary : " + totalSalary);
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(1, "JAY");
            manager.Calculate_salary(50000, 10000);
            Developer developer = new Developer(1, "ram");
            developer.Calculate_salary(40000, 5000);
            SalesPerson salesPerson = new SalesPerson(1, "Divya");
            salesPerson.Calculate_salary(30000, 15000);


        }
    }
}
