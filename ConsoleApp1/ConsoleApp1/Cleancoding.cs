using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cleancoding
    {
        public void EvenArray() {

            int[] Num = {1,2,3,4,5,6,7,8,9,10 };
            int Even = 0;
            for (int i = 0; i < Num.Length; i++) {
                //if (Num[i] % 2 == 0) {
                //    Console.WriteLine(Num[i] + " " + "is even ");
                //} else {
                //    Console.WriteLine(Num[i] + " " + "is odd");
                //}

                var data = (Num[i] % 2 == 0) ?  Even = Num[i] :0;
                Console.WriteLine(data);
            }
        }
        public void Sort() {
            int[] num = new int[5];
            // accepting 6 input from user
            Console.WriteLine("Please Enter integers");
            for (int i = 0; i < 5; i++) {
                num[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            //Sorted in ascending order
            Array.Sort(num); 
            Console.WriteLine("Sorted List");
            foreach (int n in num) {
                Console.Write(" " + n);
            }
            Console.WriteLine();
            
        }
        }
    }

