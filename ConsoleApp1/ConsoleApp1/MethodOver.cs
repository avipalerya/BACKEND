using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MethodOver
    {
         public void display(int a)
        {
            Console.WriteLine("Arguments: " + a);
        }

        // method with two parameters
        public void display(int a, int b)
        {
            Console.WriteLine("Arguments: " + a + " and " + b);
        }
    }
}
