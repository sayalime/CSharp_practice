using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_abstract_class_inheritance
{
    public abstract class Vehicle
    {
        abstract public void StartEngine();
        abstract public void StopEngine();
        public virtual void Drive()
        {
            Console.WriteLine("concrete method");
        }

    }
    public class Car : Vehicle 

    {

        public override void StartEngine()
        {
            Console.WriteLine("Car class Engine started");
        }
        public override void StopEngine()
        {
            Console.WriteLine("Car Class Engine Stopped");
        }
        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("car class Drive method");
        }
    }
    public class MotorCycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("MotorCycle class Engine started");
        }
        public override void StopEngine()
        {
            Console.WriteLine("MotorCycle Class Engine Stopped");
        }
        public override void Drive()
        {
            Console.WriteLine("MotorCycle class Drive method");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Car car = new Car();
            car.StartEngine();
            car.StopEngine();
            car.Drive();
            MotorCycle motorCycle = new MotorCycle();
            motorCycle.StartEngine();
            motorCycle.StopEngine();
            motorCycle.Drive();
            Console.ReadKey();
        }
    }
}
