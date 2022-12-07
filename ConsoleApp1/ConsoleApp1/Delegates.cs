﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void addnum(int a, int b);
    public delegate void subnum(int a, int b);
    class Delegates
    {
        // "addnum" and "subnum" are two delegate names
        

        // method "sum"
        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }

        // method "subtract"
        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }
    }
}
