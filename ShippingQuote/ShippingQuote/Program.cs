using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            int pkweight;
            int pkwidth;
            int pkheight;
            int pklength;
            double total;
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            pkweight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package width:");
            pkwidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package lenght:");
            pklength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            pkheight = Convert.ToInt32(Console.ReadLine());

            total = (pkweight * pkheight * pklength * pkwidth) / 100;
            Console.WriteLine("Your estimated total for shipping this package is:" + total);
            Console.ReadLine();
        }
    }
}
