using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //it is a class,it will allow us to define classes and  methods with the placeholder
    class Generic_Types<t>
    {
        public t names;
        public t age;

        public void testing()
        {
            Console.WriteLine("name and age is {0}-{1}", names, age);
        }

        public void test2<type>(type a, t value)
        {
            Console.WriteLine("{0}-{1}", a, value);
        }
    }
}
