using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndStuff
{
    class Employee : person, IQuittable
    {

        public int Id { get; set; }
        public new string SayName()
        {
            
            return (Id + " " + FirstName + " " + LastName);
        }
        public void Quit()
        {

            Console.WriteLine(FirstName + " Has Quit");
            
        }
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
