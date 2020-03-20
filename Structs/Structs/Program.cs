using System;

namespace Structs
{
    class Program
    {
        public struct Number {
            public decimal Amount { get; set; }
        }
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 1.25m;
            Console.WriteLine(number.Amount);
        }
    }
}
