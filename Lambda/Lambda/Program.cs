using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.id = 1;
            employee1.First = "Joe";
            employee1.Last = "smith";

            Employee employee2 = new Employee();
            employee1.id = 2;
            employee1.First = "Mike";
            employee1.Last = "Jordans";

            Employee employee3 = new Employee();
            employee1.id = 3;
            employee1.First = "Jesse";
            employee1.Last = "Wanker";

            Employee employee4 = new Employee();
            employee1.id = 4;
            employee1.First = "Joe";
            employee1.Last = "Reeter";

            Employee employee5 = new Employee();
            employee1.id = 5;
            employee1.First = "Liver";
            employee1.Last = "Baby";

            Employee employee6 = new Employee();
            employee1.id = 6;
            employee1.First = "Joe";
            employee1.Last = "Budden";

            Employee employee7 = new Employee();
            employee1.id = 7;
            employee1.First = "Kelly";
            employee1.Last = "Nickle";

            Employee employee8 = new Employee();
            employee1.id = 8;
            employee1.First = "Jane";
            employee1.Last = "Johnson";

            Employee employee9 = new Employee();
            employee1.id = 9;
            employee1.First = "Toby";
            employee1.Last = "Quezzy";

            Employee employee10 = new Employee();
            employee1.id = 10;
            employee1.First = "Jody";
            employee1.Last = "Jordans";

            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);
            employees.Add(employee10);

            List<Employee> temp = new List<Employee>();

            foreach (var joe in employees)
            {
                if (joe.First == "Joe")
                {
                    temp.Add(joe);
                }
            }

            List<Employee> newList = employees.Where(x => x.First == "joe").ToList();
            List<Employee> newList2 = employees.Where(x => x.id > 5).ToList();
        }
    }
}
