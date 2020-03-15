using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            int usernum = 0; 
            List<int> lstInt = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("whats a number you want to divide the list by?");
            try
            {
                usernum = Convert.ToInt32(Console.ReadLine());
                if (usernum == 0)
                {
                    throw new InvalidOperationException();
                }
                foreach (int i in lstInt)
                {
                    Console.WriteLine(usernum * i);
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Hey, Trying to be smart huh? well anything divided by zero is zero");
            }
            catch (Exception)
            {
                Console.WriteLine("your input is invaild");
            }
            Console.WriteLine("exited try catch");
            Console.ReadLine();
   
            
        }
    }
}
