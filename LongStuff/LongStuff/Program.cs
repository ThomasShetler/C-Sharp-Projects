using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int number = Convert.ToInt32(Console.ReadLine());
            long result = number * 50;
            Console.WriteLine(result);
            Console.WriteLine("Write a number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double result2 = number2 / 12.5;
            Console.WriteLine(result2);
            Console.WriteLine("Write a number");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int result3 = number3 + 25;
            Console.WriteLine(result3);
            Console.WriteLine("Write a number");
            int number4 = Convert.ToInt32(Console.ReadLine());
            bool result4;
            if (50 < number)
            {
                result4 = false;
            }    
            else
            {
                result4 = true;
            }

            Console.WriteLine(result4);
            Console.WriteLine("Write a number");
            int number5 = Convert.ToInt32(Console.ReadLine());
            int result5 = number5 % 7;
            Console.WriteLine(result5);

        }
    }
}
