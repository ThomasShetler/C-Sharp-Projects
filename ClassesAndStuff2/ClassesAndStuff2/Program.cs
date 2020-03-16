using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndStuff2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number to divide");
            try { 
            string num1 = Console.ReadLine();
            Console.WriteLine(BasicMaths.div(num1));
            }
            catch (Exception)
            {
                Console.WriteLine("that is invail input!");
            }
            finally { 

            Console.WriteLine("Enter a number to add");
            double num3 = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine(BasicMaths.sum(num3));
            Console.WriteLine("enter a number to multiply");
            int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(BasicMaths.mult(num2));
            }
            Console.ReadLine();
        }
    }
}
