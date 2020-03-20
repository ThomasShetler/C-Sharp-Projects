using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Joe = new Employee();
            Joe.SayName("sample", "Student");
            //not entirely sure this is what i was supposed to do, But I tried my best!
            Joe.Quit();

        }
    }
}
