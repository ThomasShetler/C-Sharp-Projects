using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person 1 hourly rate");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWorked1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2 hourly rate");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());

            int total1 = (hourlyRate1 * hoursWorked1) * 52;
            int total2 = (hourlyRate2 * hoursWorked2) * 52;

            Console.WriteLine("Person 1 est Annual salary");
            Console.WriteLine(total1);
            Console.WriteLine("Person 2 Est Annual Salary");
            Console.WriteLine(total2);
            Console.WriteLine("Does person 1 make more then person 2");
            if (total1 > total2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
