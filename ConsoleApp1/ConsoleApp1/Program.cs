using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {  //exampleclass
           // ExampleClasses.method1();

            //Sum of first 10 natural numbers
            //SumofNN.sum();

            //sum and average of readline numbers
            // SumnAvg.sumnavg();

            //cube of a number
            //Cube.cube();

            //triangle pattern
            //TrianglePat.TrianglePattern();

            //Armstrong num
            //Armstrong.armstrong();

            //method-overloading
            //MethodOver p1 = new MethodOver();
            // p1.display(100);
            //p1.display(100, 200);
            // Console.ReadLine();


            //parent and base class
            //Admin admin = new Admin();
            //admin.text();
            //admin.VideoCall();

            //inheritance example
            // object of derived class
            //Dog labrador = new Dog();

            // access field and method of base class
            //labrador.name = "Rohu";
            //labrador.display();

            // access method from own class
            //labrador.getName();

            //Console.ReadLine();

            //Heirarchical inhert
            //ChildFirst first = new ChildFirst();

            // Displaying Child Name and Father Name for
            // ChildFirst
            //Console.WriteLine("My name is " + first.ChildDName() +". My father name is " +first.FatherName() + ".");
            //ChildSecond second = new ChildSecond();

            // Displaying Child Name and Father Name for
            // ChildSecond
            //Console.WriteLine("My name is " + second.ChildDName() +". My father name is " +second.FatherName() + ".");

            //instance creation
            //initializing the value

            //Constructor2 ref5 = new Constructor2("AVI", 2, "CHARLIE");
            //Console.WriteLine(ref5.y);
            //Console.WriteLine(ref5.x);
            //Console.WriteLine(ref5.name);

            //Exception handeling

            //Exceptions exceptions = new Exceptions();

            // exceptions.ThrowException();

            // system.io exception


            //exceptions.ioException();


            //custom exception
            //Student student = new Student();
            //student.setAge(-5);


            //genric types
            // Generic_Types<string> genericTypeString = new Generic_Types<string>();
            // Console.WriteLine(genericTypeString.names = "Akshata");

            //Generic_Types<int> genericTypeint = new Generic_Types<int>();
            // Console.WriteLine(genericTypeint.age = 22);

            // generic method
            //genericTypeint.test2<string>("Avi", 20);

            //delegate example
            // Delegates obj = new Delegates();
            // addnum del_obj1 = new addnum(obj.sum);
            // subnum del_obj2 = new subnum(obj.subtract);

            // pass the values to the methods by delegate object
            // del_obj1(100, 40);
            //del_obj2(100, 60);


            //MultiCast example
            SingleAndMultiCastDelegate muldel = new SingleAndMultiCastDelegate();
            muldel.CalculationOne();
            muldel.CalculationTwo();

            //lamda experssion
            //  LamdaExample lam = new LamdaExample();
            // lam.lamda();

            //Delegate Example
            // List<Employee> empList = new List<Employee>();
            // empList.Add(new Employee() { ID = 101, Name = "avi", Salary = 5000, Experience = 5 });
            // empList.Add(new Employee() { ID = 102, Name = "shrey", Salary = 4000, Experience = 6 });
            //empList.Add(new Employee() { ID = 101, Name = "hima", Salary = 9000, Experience = 2 });
            // Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);

            //Clean Coding
            //Cleancoding evenarr = new Cleancoding();
            //evenarr.EvenArray();
            // evenarr.Sort();


            //Date AND time
            //DateAndTime datentime = new DateAndTime();
            //datentime.Inspect();

            //DST
            //TimeZoneInfoDemo timezone = new TimeZoneInfoDemo();
            //timezone.TimeZone();

            //greet datentime
           // DateNTime greet = new DateNTime();
           // greet.Datentime();



        }

    }
    }


