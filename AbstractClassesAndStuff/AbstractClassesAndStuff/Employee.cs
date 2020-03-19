using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndStuff
{
    class Employee: person
    {
        public string SayName(string first, string last)
        {
            FirstName = first;
            LastName = last;
            return (first + " " + last);
        }
    }
}
