using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndStuff
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee Joe = new Employee();
            Joe.Id = 1;
            Joe.FirstName = "Joe";
            Joe.LastName = "Brandy";
            
            Console.WriteLine(Joe.SayName());

            Employee bob = new Employee();
            bob.Id = 2;
            bob.FirstName = "bob";
            bob.LastName = "Smith";
            Console.WriteLine(bob.SayName());

            if (bob.Id == Joe.Id)
            {
                Console.WriteLine(Joe.FirstName + " and "+ bob.FirstName +" are equal ids");
            }
            else
            {
                Console.WriteLine(Joe.FirstName + " and " + bob.FirstName + " are not equal ids");
            }

            
            bob.Quit();


            //not entirely sure this is what i was supposed to do, But I tried my best!
            Joe.Quit();

        }
    }
}
