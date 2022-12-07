using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class  DateNTime
    {
        public string greeting;
        public string Datentime() {
            //Storing current datetime in the variable timeOfDayGreeting
            
        DateTime timeOfDayGreeting = DateTime.Now;
           
            //condition to greet according to the time
            if (timeOfDayGreeting.Hour >= 5 && timeOfDayGreeting.Hour < 12) {
                greeting = "Good Morning";
            } else if (timeOfDayGreeting.Hour >= 12 && timeOfDayGreeting.Hour < 16) {
                greeting = "Good Afternoon";
            } else {
                greeting = "Good Night";
            }
            Console.WriteLine(greeting);
            return greeting;

         
        }
    }
}
