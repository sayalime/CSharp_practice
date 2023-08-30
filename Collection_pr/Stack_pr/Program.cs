using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_pr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create and initialize a stack
            Stack stk = new Stack();
            stk.Push("Welcome");
            stk.Push("Tutlane");
            stk.Push(20.5f);
            stk.Push(10);
            stk.Push(null);
            stk.Push(100);
            Console.WriteLine("Number of Elements in Stack: {0}", stk.Count);
            int index = stk.Count - 1;
            Console.WriteLine("Deleted Elements : ");
            while (stk.Count > 1)
            {
                
                Console.WriteLine("Index {0}: {1}", index, stk.Pop());
                index--;
            }
            Console.WriteLine("Remaining elements : ");
            foreach (var element in stk)
            {
                Console.WriteLine("Index {0}: {1}", index, element);
                index++;
            }
            Console.WriteLine("Number of Elements in Stack: {0}", stk.Count);


            Console.ReadLine();
        }
    }
}
