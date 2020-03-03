using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLdatabaseStuff
{
    public class theAge
    {
        public void Age()
        {
            Console.WriteLine("whats your age?");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i <= 0)
            {
                throw new AgeException();
            }
        }
    }
}
