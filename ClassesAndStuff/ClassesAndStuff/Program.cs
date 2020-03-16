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
            Methods meth = new Methods();
            Console.WriteLine("The 2 numbers multiplied is:");
            Console.WriteLine(meth.multiply(firstSel, SecondSel));
            Console.WriteLine("The 2 numbers added is:");
            Console.WriteLine(meth.sum(firstSel, SecondSel));
            Console.WriteLine("subtracting the 2 numbers will leave you with:");
            Console.WriteLine(meth.sub(firstSel, SecondSel));
            Console.ReadLine();

        }
     

    }
}
