using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public interface ICar
    {

        public void IStart() {
        }

        public void IDrive() {
        }
        public void IStop() {

        }
    }
    public class BMW : ICar
    {
        // Car owner= new Car(); cannot create an obj of interface 
        //public void startBMW() {
        //    owner.Start();
        //}
        public void IStart() {
            Console.WriteLine("started the BMW car");

        }
        public void IDrive() {
            Console.WriteLine("driving the BMW car");
        }
        public void IStop() {

            Console.WriteLine("stopped the BMW car");
        }

    }
    public class RR : ICar
    {
        //Car owner= new Car();
        public void IStart() {
            Console.WriteLine("started the RR car");

        }
        public void IDrive() {
            Console.WriteLine("driving the RR car");
        }
        public void IStop() {

            Console.WriteLine("stopped the RR car");
        }
    }

    public class Ambassdor : ICar
    {
        //Car owner= new Car();
        public void IStart() {
            Console.WriteLine("started the Ambassdor car");

        }
        public void IDrive() {
            Console.WriteLine("driving the Ambassdor car");
        }
        public void IStop() {

            Console.WriteLine("stopped the Ambassdor car");
        }

    }

    public class CarFactory
    {
        public static ICar getCar(String Type) {
            ICar ObjectType = null;
            if (Type.ToLower().Equals("bmw")) {
                ObjectType = new BMW();
            } else if (Type.ToLower().Equals("rr")) {
                ObjectType = new RR();
            } else if (Type.ToLower().Equals("Ambassdor")) {
                ObjectType = new Ambassdor();
            }
            return ObjectType;

        }
    }

}