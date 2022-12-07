using System;
using experimental;

namespace ConsoleAppForPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LoopingExampe example = new LoopingExampe();

            //example.smartInsert(); //if else loop

            // example.insert(); //if loop

            // example.difference();   

            //example.question();

            //ParseTryParse test = new ParseTryParse();

            //test.testing();



            //SwitchExample example1 = new SwitchExample();
            //example1.testing();
            //example1.test1();

            //Car obj = new Car();
            //obj.color = "red";
            //obj.ride();


            //ExampleClasses.name = "hello";
            //ExampleClasses.method1();

            //ParrtialClass parrtialClass = new ParrtialClass();

            //parrtialClass.Addition(2,3);

            //parrtialClass.Substraction(6,3);

            Access access = new Access();
            //access.id = -3;
            access.setage(20);
            //access.name = "avi";

            //access.method1();

            Console.WriteLine(access.getid());
            Console.WriteLine(access.getage());

            

        }
    }
}
