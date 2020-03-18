using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
         static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("enter a number");
            int hours = Convert.ToInt32(Console.ReadLine());

            DateTime hoursLater = now.AddHours(hours);
            Console.WriteLine("It will be " + hoursLater + " in " + hours + " hours");
            Console.ReadLine();
        }
    }
}
