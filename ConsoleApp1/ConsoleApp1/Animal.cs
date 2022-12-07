using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal
    {
        public string name;

        public void display()
        {
            Console.WriteLine("I am an animal");
        }

    }

    // derived class of Animal 
    class Dog : Animal
    {

        public void getName()
        {
            Console.WriteLine("My name is " + name);
        }
    }

}
