using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("what day is it?:");
            string value = Console.ReadLine();
            try { 
            daysOfTheWeek day = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), value);
                Console.WriteLine("Its " + value);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day");
                Console.ReadLine();
            }
            
            Console.ReadLine();

        }
    }
    public enum daysOfTheWeek {
        Sunday =1,
        Monday=2,
        Tuesday=3,
        Wednesday=4,
        Thurseday=5,
        Friday=6,
        Saturday=7
    }


}
