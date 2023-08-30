using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assinment8_abstractclass_andinterface
{
    public abstract class Animal
    {
        public virtual void  MakeSound()
        {
            Console.WriteLine("Animal class MakeSound method called");
        }
    }
    public class Cat:Animal
    { 
        
        public override void MakeSound()
        {
            base.MakeSound();


            Console.WriteLine("Cat class MakeSound method called");
        }
        public void play()
        {
            Console.WriteLine("play method called in Cat class");
        }

    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog class MakeSound method called");
        }
        public void play()
        {
            Console.WriteLine("play method called in dog class");
        }
    }
    public interface Pet
    {
        void Play();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.MakeSound();
            cat.play();
            Dog dog = new Dog();
            dog.MakeSound();
            dog.play();

            Console.ReadKey();
        }
    }
}
