using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("whats your age?");
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new InvalidOperationException();

                }
                int age2;
                int now;
                now = DateTime.Now.Year;
                age2 = now - age;
                Console.WriteLine("You were born in:" + age2);

            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("that is invail input! please put in a number greater then zero");
            }
            catch (Exception)
            {
                Console.WriteLine("that is invail input!");
            }
            
        
            Console.ReadLine();
        }
    }
}
