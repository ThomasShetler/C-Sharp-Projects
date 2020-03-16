using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndStuff2
{
    class BasicMaths
    {
        public static int mult(int a)
        {
            int total = a * 2;
            return (total);
        }
        public static int sum(double a)
        {
            int total = Convert.ToInt32(a + 5);
            return total;
        }
        public static int div(string a) {
            int aa = Convert.ToInt32(a);
            int total =aa / 2;
            return (total);
        }
    }
}
