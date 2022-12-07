using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experimental
{
    //looping ststements
    //for, while, do While, for Each

   
    internal class Looping
    {
        public void looping()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void looping2()
        {
            int i = 0;
            while(i<10){
                i++;
                Console.WriteLine(i);
            }
        }

        public void looping3()
        {
            int i=0;
            do
            {
               i++;
               Console.WriteLine($"condition was true {i}");
            }while(i<0);
        }



        //multipal if 
        //know more about the var type in c#
        //know about primitive type and wrapper class
        public void insert()
        {
            var a = Console.ReadLine();

            if(a == "sunday")
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
         
    }
}
