using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment6_abstract__class_design
{
    public abstract class Shape
    {
        abstract public void CalculateArea();
        abstract public  void CalculatePerimeter();

    }
    public class Circle : Shape
    {
        float pi = 3.14f;
        int r = 3;
        public override void CalculateArea()
        {
            float Area = pi * r * r;
            int nArea=(int)Area;
            Console.WriteLine(nArea);
        }
        public override void CalculatePerimeter() 
        {
            double circumstances=2*pi*r;
            Console.WriteLine(circumstances);
        }
    }
    public class Rectangle : Shape
    {
        int length=20;
        int breadth = 10;
        public override void CalculateArea()
        {
            int area =length*breadth;
            Console.WriteLine(area);
        }
        public override void CalculatePerimeter()
        {

            int perimeter = 2 * (length + breadth);
            Console.WriteLine(perimeter);
        }

    }
    public class Triangle : Shape
    {
        int langth = 20;
        int height = 10;
        float pi = 3.14f;
        public override void CalculateArea()
        {
           double area=(langth*height)/2.0;
            Console.WriteLine(area);
        }
        public override void CalculatePerimeter()
        {
            double perimeter = langth + langth + langth;
            Console.WriteLine(perimeter);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle= new Circle();
            circle.CalculateArea();
            circle.CalculatePerimeter();
            Rectangle rectangle= new Rectangle();
            rectangle.CalculateArea();
            rectangle.CalculatePerimeter();
            Triangle triangle= new Triangle();
            triangle.CalculateArea();
            triangle.CalculatePerimeter();

            Console.ReadKey();
        }
    }
}
