using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SumnAvg
    {
        public static void sumnavg()
        {
            int sum, i, n;
            sum = 0;
            double avg;

            Console.Write("Input the 10 numbers : ");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 10.0;
            Console.Write("The sum of 10 numbers is : {0}\nThe Average is : {1}\n", sum, avg);
            
        }
    }
}
