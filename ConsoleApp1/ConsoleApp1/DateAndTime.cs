using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DateAndTime
    {
        //creation of date,time object
        DateTime dt = new  DateTime();
        DateTime dt1 = new DateTime(2000, 02, 05);// year,month,date
        DateTime dt2 = new DateTime(2000, 02, 05, 12, 20, 01);//hour,min,sec
        DateTime dt3 = new DateTime(2000, 02, 05, 04, 20, 00, DateTimeKind.Utc);    
        DateTime dt4 = new DateTime(2022,11,08);
        DateTime current = DateTime.Now;
        DateTime current11 = DateTime.UtcNow;
        DateTime dt5 = new DateTime(2022, 10, 30,10,10,10);
        DateTime dt6 = new DateTime(2000, 05, 30, 05, 05, 05);


        public void Inspect() {
            //Console.WriteLine(this.dt);
            //Console.WriteLine(this.dt1);
            //Console.WriteLine(this.dt2);
            //Console.WriteLine(this.dt3);
            //Console.WriteLine(this.dt4);
            //Console.WriteLine(this.current);
            //Console.WriteLine(this.current11);
            //Console.WriteLine(DateTime.MinValue.Ticks);
            //Console.WriteLine(DateTime.MaxValue.Ticks);
            Console.WriteLine(this.dt5 - this.dt6);
            Console.WriteLine(this.current - this.current11);
        }
    }
}
