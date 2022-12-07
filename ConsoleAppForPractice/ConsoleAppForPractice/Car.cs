using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experimental
{
    internal class Car
    {
        private string brand { get; set; }
        public string color { get; set; }
        public int price { get; set; }

        public void ride()
        {
            Console.WriteLine("willing to ride today");
        }

        public void ride(string a)
        {
            Console.WriteLine($"hello i want to ride to {a}");
        }


        public void ride(int b)
        {
            Console.WriteLine($"hello{b}");
        }
        //how will a distractor clears the class memory after execution.
        //distructor
        ~Car()
        {

        }


    }
}
