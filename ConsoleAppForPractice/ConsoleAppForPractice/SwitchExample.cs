using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    //uisually documents prefer to avoid Go
    internal class SwitchExample
    {
        int a = int.Parse(Console.ReadLine());

        public void testing()
        {

            switch (a)
            {
             
                case 1: Console.WriteLine("number is 1");
                   break;
                case 2:
                    Console.WriteLine("number is two");
                    break;
                case 3:
                    Console.WriteLine("number is three");
                    break;

                default:
                    Console.WriteLine("not in teh case");
                    break ;
                    
            }

      




        }

        //go to

        public void test1()
        {
        label:
            Console.WriteLine("label is here");

        label2:
            Console.WriteLine("i am label 2");
            if (a == 1)
            {
                goto label;
            }
            else
            {
                goto label2;
            }
        }
    }
}
