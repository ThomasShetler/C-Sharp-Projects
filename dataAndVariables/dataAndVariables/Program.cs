using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myname;
            //Console.WriteLine("what is your name?:");
            //myname = Console.ReadLine();
            //Console.WriteLine("Your Name Is:" + myname);
            //Console.ReadLine();

            Console.WriteLine("what be your favorite number");
            string favoriteNumber = Console.ReadLine();
            Convert.ToInt32(favoriteNumber);
            Console.WriteLine("Your Favorite Number + 5 is" + favoriteNumber + 5);
            Console.ReadLine();

            
        }
    }
}
