using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args) {

            //{
            //    //LooseCoupling looseCoupling = new LooseCoupling();
            //    //looseCoupling

            //    //Order order = new Order();
            //    //order.OrderTotal();
            //}

            //{
            //    BMW bmw = new BMW();
            //    bmw.IStart();
            //    //bmw.startBMW();
            //    bmw.IDrive();
            //    bmw.IStop();
            //}

            //{
            //    //upcasting---> conversion of string to double smaller data type to larger data type
            //    //downcasting---> conversion of larger data type to smaller data type
            //    ICar cars = new Ambassdor();
            //    //Car cars = new RR();
            //    //Car cars = new bmw();
            //    cars.IStart();
            //    cars.IDrive();
            //    cars.IStop();
            //}

            {
                String input = null;
                Console.WriteLine("Enter the Brand of Car");
                input = Console.ReadLine();
                ICar Type = Car.GetCar(input);
                //Console.WriteLine("Status of Car is:", Type.Start());
                // Console.WriteLine("Status of Car is:", Type.Drive());
                // Console.WriteLine("Status of Car is:", Type.Stop());
            }

        }
    }
}