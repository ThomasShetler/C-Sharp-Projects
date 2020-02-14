using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numArray1 = new int[] { 5, 2, 10, 200 };
            string[] strings = { "hi", "sup", "whats poppin", "yolo", "supppp" };

            int length = numArray1.Length;
            int lengthString = strings.Length;

            Console.WriteLine("Select an index up  from 0 - " + length + " in the number array");
            String selection = Console.ReadLine();
            int numselect = Convert.ToInt32(selection);
            if (numselect > length)
            {
                Console.WriteLine("the number " + numselect + " is either to high or to low /n and is not a vaild entry");
            }
            else
            {
                Console.WriteLine(numArray1[numselect]);
            }
            

            Console.WriteLine("Select an index up  from 0 - " + lengthString + " in the String array");
            selection = Console.ReadLine();
            if (numselect > length)
            {
                Console.WriteLine("the number " + numselect + " is either to high or to low /n and is not a vaild entry");
            }
            else
            {
                Console.WriteLine(strings[numselect]);
            }
            Console.ReadLine();
        }
    }
}
