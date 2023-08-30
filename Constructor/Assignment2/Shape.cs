using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Shape
    {
        public const double Pi = 3.14;
        protected string Name;

        public Shape(string Name)
        {
            this.Name = Name;
        }

        public virtual void CalculateArea()
        {

        }

        public virtual void DisplayShapeInfo()
        {

        }
    }

    public class Rectangle : Shape
    {
        public double Width = 5;
        public double Height = 15;
        public double Area;

        public Rectangle(string Name) : base(Name)
        {
        }

        public override void CalculateArea()
        {
            Area = Height * Width;
        }

        public override void DisplayShapeInfo()
        {
            Console.WriteLine($"Name: {Name}\nWidth: {Width}\nHeight: {Height}\nArea: {Area}");
        }
    }

    public class Circle : Shape
    {
        public double Radius = 5;
        public double Area;

        public Circle(string Name) : base(Name)
        {
        }

        public override void CalculateArea()
        {
            Area = Pi * Radius * Radius;
        }

        public override void DisplayShapeInfo()
        {
            Console.WriteLine($"Name: {Name}\nRadius: {Radius}\nArea: {Area}");
        }
    }

    public class Triangle : Shape
    {
        double SideA = 10;
        double SideB = 10;
        double SideC = 10;
        double Area;

        public Triangle(string Name) : base(Name)
        {
        }

        public override void CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            Area = Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override void DisplayShapeInfo()
        {
            Console.WriteLine($"Name: {Name}\nSideA: {SideA}\nSideB: {SideB}\nSideC: {SideC}\nArea: {Area}");
        }
    }

   
}
