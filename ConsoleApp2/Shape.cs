using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class TestDriven
    { 
        public float Circumference(int r)
        {
            return 2 * (22 / 7) * r;
        }
        public int AreaOfTriangle(int a ,int b)
        {
            return (a * b) / 2;
        }
        public int AreaOfRectangle(int l,int w)
        {
            return l * w;
        }
    }
}
