using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter REctagle Name");
            string rectangle_nm = Console.ReadLine();
            Rectangle r = new Rectangle(rectangle_nm);
            r.CalculateArea();
            r.DisplayShapeInfo();

            Console.WriteLine("Enter Circle Name");
            string circle_nm = Console.ReadLine();
            Circle c = new Circle(circle_nm);
            c.CalculateArea();
            c.DisplayShapeInfo();

            Console.WriteLine("Enter Triangle Name");
            string triangle_nm = Console.ReadLine();
            Triangle t = new Triangle(triangle_nm);
            t.CalculateArea();
            t.DisplayShapeInfo();
            Console.ReadKey();

        }
    }
}
