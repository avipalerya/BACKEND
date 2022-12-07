using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loosentightcoupling
{
    class Program
    {
        static void Main(string[] args) {
            //loosecoupling
            //  Order1 loose = new Order1();
            //   loose.OrderTotal1();

            //owner decides to run BMW
            BMW bmw = new BMW();
            bmw.StartBMW();
        }
    }
}
