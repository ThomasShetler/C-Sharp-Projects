using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainging
{
    class Program 
    { 
    
       
        static void Main(string[] args)
        {
            const string namo = "THE BATTLE OF REEEEEEE"; 
            //THIS IS THE CAINED CONSTRUCTOR OF POWEEEEERRRR REEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
            Constructors obj = new Constructors("Thomas",7);
            //THIS IS VAR VALUEEEEEE REEEEEEEEEEEEEEEEEEEEEEEE
            var newDickie = new Dictionary<string, string>();

            bool isTriggered = false;

            Console.WriteLine("are you triggered?????? Y/N");
            string awnser = Console.ReadLine();
            if (awnser == "Y")
            {
                isTriggered = true;
            }
            else
            {
                isTriggered = false;
            }
            while (isTriggered == true)
            {
                Console.WriteLine("REEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
            }

        }
    }
}
