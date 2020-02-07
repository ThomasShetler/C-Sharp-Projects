using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportTTA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student daily Report");
            Console.WriteLine("what course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("what page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("Do you need help with anything type yes or no");
            string awnser = Console.ReadLine();
            bool needHelp;
            if (awnser == "yes") {
                 needHelp = true;
                Console.WriteLine("what do you need help with?");
                string help = Console.ReadLine();
            }
            else
            {
                needHelp = false;
            }

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positive = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursstudied = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day") ;
            Console.ReadLine();
        }
    }
}
