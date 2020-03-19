using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("say a number");
            int choice = Convert.ToInt32(Console.ReadLine());
            Stuff stuff = new Stuff();

           stuff.Yehaw(choice);
           stuff.yee("bob");
        }
    }
}
