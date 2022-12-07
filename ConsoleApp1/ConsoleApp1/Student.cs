using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private int id;
        private string name;
        private int age;

        public void getId()
        {
            id = 10;
        }
        //write only
        public int setAge(int age)
        {
            if (age < 0 || age > 100)
            {
                throw new ArgumentException("age must not be less than 0 and greater than 100");

            }
            else
            {
                this.age = age;
                Console.WriteLine("Age is {0}", age);
                return age;
               
            }
        }
    }
}
