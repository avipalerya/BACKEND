using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    internal class ParseTryParse
    {
        public void testing()
        {
            int b;
            string a = "100Ty";
            if(int.TryParse(a, out b))
            {
                Console.WriteLine("possible to parse");
            }
            else
            {
                Console.WriteLine("not possible to parse");
            };
        }


    }
}
