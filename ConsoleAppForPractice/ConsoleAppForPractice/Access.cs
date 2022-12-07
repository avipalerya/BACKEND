using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    public class Access
    {
        
        private int id;
        private int age { set; get; }

        private string name;

        public void setage(int age)
        {
            //if(age < 0 || age > 100)
            //{
            //    throw new Exception("age should be greater than 0 and less than 100");
            //}
            //else
            //{
            //    this.age = age;
            //}

            object p = (age < 0 || age > 100) ? throw new Exception("age should be greater than 0 and less than 100") : this.age = age;

        }

        public string getage()
        {

            if (age < 18)
            {
                return "underage";
            }
            else
            {
                return "age is accepted";
            }

            string p = (age < 18) ? "underAge" : "age accepted";
        }


        public int getid()
        {
            return id = 6;
        }

        public void method1()
        {
            Console.WriteLine(id);
            Console.WriteLine(age);
            Console.WriteLine(name);

        }
    }
}
