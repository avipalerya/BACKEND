using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experimental
{
    internal class Conversion
    {
     
        //implisit conversion
        public void example()
        {
            int a = 100;
            float b = a;

            Console.WriteLine(b);
        }

        //explisit conversion
        public void example2()
        {
            double a = 10.810000;

            int b = (int)a;

            Console.WriteLine(b);
        }

        //even the char holds less mempory why is
        //it not possible to convert char to string?
        public void example3()
        {
            char a = 'a';
            string b = a.ToString();
           Console.WriteLine(b);

            //converting int it string

            int c = 100;
            string d = a.ToString();
            Console.WriteLine(d.GetType());


            //string to an int
            //what happens while converting string to int
            //when we have ctring data with number
            //is there any ways to convert the alfa numerical value into int
            //what is the diff b/w parse() and TryParse()
            string e = "100Hello";
            string plain = "100";

            //int f = int.Parse(e);
            int g;

            

            int.TryParse(e, out g);

            Console.WriteLine($"{ g.GetType()},{ g}");

        }

      
    }
}
