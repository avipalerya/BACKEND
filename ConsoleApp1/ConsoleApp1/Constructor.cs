using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Constructor is similar to a method but it has no return type
    //A constructor has the same name as the class name.
    public class Constructor
    {
        public int id;
        public string name;

        //user defined constructor
        //constructor overloading
        public Constructor(string a)
        {
            name = a;
            Console.WriteLine("From base class with string parameter");
        }

        //constructor chaining this(a) instead of commented constructor(int a, string b)
        public Constructor(string b, int a)
        {
            this.name = b;
        }

        //public Constructor(int a, string b)
        //{
        //    id = a; name = b;
        //}

        //creating user defined constructor with no parameters(to achieve default
        public Constructor()
        {

        }


    }

    //creating constructor
    public class Constructor2 : Constructor
    {

        public int x;
        public string y;

        public Constructor2(int c)
        {
            x = c;
        }
        public Constructor2(string a)
        {
            y = a;
        }

        public Constructor2(string a, int b) : this(b)
        {
            y = a;
        }
        //why is the base constructor 
        public Constructor2(string a, int b, string x) : base(x)
        {
            this.y = a;
            this.x = b;
            Console.WriteLine("From derived class");
        }
    }
}