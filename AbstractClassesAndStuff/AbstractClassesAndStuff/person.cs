using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndStuff
{
    abstract class person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SayName(string first, string last)
        {
            FirstName = first;
            LastName = last;
            return (first + " " + last);
        } 
    }
}
