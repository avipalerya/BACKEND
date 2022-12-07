using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    //class 1
    public class DelegateExample1
    {
        //A delegate is a reference type that holds the reference of a class method.
        //Any method which has the same signature as delegate can be assigned to delegate.

        //Single cast Delegate

        //A single cast delegate holds the reference of only single method.In previous example, created delegate is a single cast delegate.


        //Multi Cast Delegate

        //A delegate which holds the reference of more than one method is called multi-cast delegate.

        public void Add(int x, int y)
        {
            Console.WriteLine($"Add Method called Output - {x + y}");
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine($"Subtract Method called Output - {x - y}");
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine($"Multiply Method called Output - {x * y}");
        }

    }


    //class 2

    public class SingleAndMultiCastDelegate
    {

        public delegate void Action(int x, int y);

        //Single Delegate
        public void CalculationOne()
        {
            DelegateExample1 delegateExample = new DelegateExample1();
            Action action = new Action(delegateExample.Add);

            action(5, 5);
            Console.ReadKey();
        }


        //Multi Delegate
        public void CalculationTwo()
        {
            DelegateExample1 delegateExample = new DelegateExample1(); //class instance
            Action action = new Action(delegateExample.Add); //delegate instance

            action += new Action(delegateExample.Subtract);
            action += new Action(delegateExample.Multiply);

            action(5, 5);
            Console.ReadKey();

        }//CalculationTwo method ends
    }
}
