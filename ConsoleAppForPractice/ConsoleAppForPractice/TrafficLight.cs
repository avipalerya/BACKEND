using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experimental
{
    internal class TrafficLight
    {
        public enum light
        {
            red = 1, yellow = 2, green = 3
        }

        public enum gender
        {
            male, female, unknown
        }

        public void rules()
        {
            Console.WriteLine($"stop when it shows {light.red}");

            Console.WriteLine($"says to go {light.green}");

            Console.WriteLine($"says to get ready {light.yellow}");
        }


        public void genderTypes()
        {
            Console.WriteLine($"types of gender are");
        }

    }
}
