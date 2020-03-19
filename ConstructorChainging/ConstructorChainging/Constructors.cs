using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainging
{
    class Constructors
    {
        string _studentType = "<Senior>";
        string _id = "8";
        string _fName = "Bob";
        string _lName = "Smith";

        public Constructors(string id)
            : this(id, "Bob", "Smith")
        {

        }

        public Constructors(string id, string fName)
            : this(id, fName, "Smith")
        {

        }

        public Constructors(string id, string fName, string lName)
        {
            //Validate logic.....
            _studentType = "<Senior>";

            _id = id;
            _fName = fName;
            _lName = lName;
        }
    }       
     
 
    


