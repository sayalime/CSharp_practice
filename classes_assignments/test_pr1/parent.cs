using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_pr1
{
    internal class parent
    {
        protected int i;
        public void getinput(int no)
        {
            for ( i = 1; i <no; i++)
            {
                child c = new child();
                c.EvenOdd(i);

            }
        }
    }
}
