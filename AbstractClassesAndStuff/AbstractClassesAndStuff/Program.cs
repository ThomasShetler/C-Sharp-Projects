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

          
            
            

            Employee<string> Joe = new Employee<string>();

            Joe.Things = new List<string>();
            Joe.Things.Add("something");
            Joe.Things.Add("something");
            Joe.Things.Add("something");
            Joe.Things.Add("something");
            Joe.Id = 1;
            Joe.FirstName = "Joe";
            Joe.LastName = "Brandy";
            
            

            Console.WriteLine(Joe.SayName());

            Employee<int> bob = new Employee<int>();
            bob.Things = new List<int>();
            bob.Things.Add(1);
            bob.Things.Add(1);
            bob.Things.Add(1);
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
            

            foreach (string h in Joe.Things)
            {
                Console.WriteLine(h);
            }

            foreach (int i in bob.Things)
            {
                Console.WriteLine(i);
            }
            bob.Quit();


            //not entirely sure this is what i was supposed to do, But I tried my best!
            Joe.Quit();

        }
    }
}
