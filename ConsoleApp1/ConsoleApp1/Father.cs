using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Father
    {
        public string FatherName()
        {
            return "SHAHRUKH";
        }
    }

    // Derived Class
    public class ChildFirst : Father
    {
        public string ChildDName()
        {
            return "ABHRAM";
        }
    }

    // Derived Class
    public class ChildSecond : Father
    {
        public string ChildDName()
        {
            return "SUHANA";
        }
    }
}
