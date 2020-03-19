using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainging
{
    class Constructors
    {
        public string Name = "bob";
        public int ID = 7;

        public Constructors(string name): this(name, 100)
        {

        }

        public Constructors(string name, int id)
        {
            name = Name;
            id = ID;
        }
    }
}
 
    


