using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me 2 numbers please");
            int firstSel = Convert.ToInt32(Console.ReadLine());
            int SecondSel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The 2 numbers multiplied is:");
            Console.WriteLine(multiply(firstSel, SecondSel));
            Console.WriteLine("The 2 numbers added is:");
            Console.WriteLine(sum(firstSel, SecondSel));
            Console.WriteLine("subtracting the 2 numbers will leave you with:");
            Console.WriteLine(sub(firstSel, SecondSel));
            Console.ReadLine();

        }
        public static int multiply(int i, int j){
            int total = i * j;
            return (total);
        }
        public static int sum(int i, int j)
        {
            int total = i + j;
            return (total);
        }
        public static int sub(int i, int j)
        {
           int total = i - j;
            return (total);
        }

    }
}
