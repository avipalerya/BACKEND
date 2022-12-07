using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack my_stack = new Stack();

            // Adding elements in the Stack
            // Using Push method
            my_stack.Push("Geeks");
            my_stack.Push("geeksforgeeks");
            my_stack.Push("geeks23");
            my_stack.Push("GeeksforGeeks");

            Console.WriteLine("Total elements present in" +
                        " my_stack: {0}", my_stack.Count);

            my_stack.Pop();

            // After Pop method
            Console.WriteLine("Total elements present in " +
                          "my_stack: {0}", my_stack.Count);


            // Remove all the elements
            // from the stack
            my_stack.Clear();

            // After Pop method
            Console.WriteLine("Total elements present in " +
                          "my_stack: {0}", my_stack.Count);
        }
    }
}
