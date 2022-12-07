using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    internal class LoopingExampe
    {
        public void insert()
        {
            var a = Console.ReadLine();

            if (a == "sunday")
            {
                Console.WriteLine("value is sunday");
            }
            if (a == "monday")
            {
                Console.WriteLine("value is Monday");
            }
            if (a == "tuesday")
            {
                Console.WriteLine("value is tuesday");
            }
        }
        public void smartInsert()
        {
            var a = Console.ReadLine();

            if (a == "sunday")
            {
                Console.WriteLine("value is sunday");
            }
            else if (a == "monday")
            {
                Console.WriteLine("value is Monday");
            }
            else if (a == "tuesday")
            {
                Console.WriteLine("value is tuesday");
            }

            //difference between || and |
           //difference between && and &
        }

        public void difference()
        {
            int age = 40;
            if (age < 45 && age > 45)
            {
                Console.Write("i executed");
            }
        }

        //what is the out put for the following code

        public void question()
        {
            int i = 0;

            for(; ; )
            {
                if (i < 5)
                {
                    Console.Write(i);
                }
                else
                {
                    break;
                    i++;
                }
            }
        }

        //question 2
        public void question2()
        {
            int i = 15;
            for(; ; )
            {
                Console.WriteLine("{0}",i);

                if(i>= -5)
                {
                    i -= -5;
                }
                else
                {
                    break ;
                }
            }
        }
    }
}


