using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loosentightcoupling
{
   public class  Owner
    {
        public void start() {
            Console.WriteLine("Started the car");
        }
        public void drive() {
            Console.WriteLine("Driving the car");
        }
        public void end() {
            Console.WriteLine("Ended the car");
        }
    }
    public class BMW 
    {
        Owner owner = new Owner();
        public void StartBMW() {
            owner.start();
        }
    }
    public class RR
    {
        Owner owner = new Owner();
    }
    public class Ambassador
    {
        Owner owner = new Owner();
    }
}
