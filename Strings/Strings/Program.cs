using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string hi = "hi";
            string what = "whats";
            string up = "up";

            string yee = hi + what + up;

            Console.WriteLine(yee);

            StringBuilder sb = new StringBuilder("Hello ", 50);

            sb.Append("World!!");
            sb.AppendLine("Hello C#!");
            sb.AppendLine("This is new line.");

            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
