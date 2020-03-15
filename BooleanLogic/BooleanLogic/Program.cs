using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dui;
            bool over15;
            bool moreThen3;
            bool qualified;
            int age;
            int speedingTickets;
            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("how many speeding tickets do you have?");
            speedingTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dui);
            

            if(age < 16)
            {
                over15 = false;
                
            }
            else
            {
                over15 = true;
            }
           
            if ( 3 < speedingTickets)
            {
            
                moreThen3 = true;
            }
            else
            {
                moreThen3 = false;
            }
           
            if ((over15 == true) && (moreThen3 == false) && (dui == false))
            {
                qualified = true;
                Console.WriteLine("qualified");
            }
            else
            {
                qualified = false;
                Console.WriteLine("not qualified");
            }
            Console.ReadLine();

        }
    }
}
