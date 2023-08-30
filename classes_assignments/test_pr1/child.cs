using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_pr1
{
    internal class child :parent
    {
        public void EvenOdd(int no)
        {
            if (no % 2 == 0)
            {

                Console.WriteLine("Even"+no);
            }
            else
            {
                Console.WriteLine("odd"+no);
            }
        }
    }
}
