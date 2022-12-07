using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class User
    {
        
       public void text()
        {
            Console.WriteLine("TEXT IS HERE ");
        }
        public void VideoCall()
        {
            Console.WriteLine("VIDEOCALL IS HERE ");
        }
    }
    public class Admin : User
    {
      public void restrict()
        {
            Console.WriteLine("I CAN RESTRICT USER");
        }

        public void addUser()
        {
            Console.WriteLine("I CAN ADD USERS ");
           
        }
    }
}
