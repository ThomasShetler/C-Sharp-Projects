using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillWhatEver
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Firstname = "Sample";
            employee.Lastname = "Student";
            employee.SayName();
            Console.ReadLine();
        }
    }
}
