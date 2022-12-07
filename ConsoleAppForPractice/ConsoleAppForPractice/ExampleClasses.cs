using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    // when we can create a static methods inside instance class
    // why cant we create instance methods in static class?
    static class ExampleClasses
    {
       public static string name { get; set; }

        public static void method1()
        {
            Console.WriteLine("hello i am from static class");
        }
    }

    public class InstanceClass
    {
        public static string name;
    }
}
