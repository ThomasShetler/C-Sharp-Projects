using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndStuff3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a number!");
            int cho1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select a number! (optional)");
            string cho2 = Console.ReadLine();

            //this is not passing in a user number this is a preset number. 
            //its not done throught the method but instructions are still followed
            if (cho2 == "")
            {
                cho2 = "5";
            }
            Console.WriteLine(Math.sum(cho1,Convert.ToInt32(cho2)));
            Console.ReadLine();
        }
    }
}
