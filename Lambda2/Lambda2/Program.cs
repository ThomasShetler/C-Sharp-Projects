using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda2
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
            employee2.id = 2;
            employee2.First = "Mike";
            employee2.Last = "Jordans";

            Employee employee3 = new Employee();
            employee3.id = 3;
            employee3.First = "Jesse";
            employee3.Last = "Wranker";

            Employee employee4 = new Employee();
            employee4.id = 4;
            employee4.First = "Joe";
            employee4.Last = "Reeter";

            Employee employee5 = new Employee();
            employee5.id = 5;
            employee5.First = "Liver";
            employee5.Last = "Baby";

            Employee employee6 = new Employee();
            employee6.id = 6;
            employee6.First = "Joe";
            employee6.Last = "Budden";

            Employee employee7 = new Employee();
            employee7.id = 7;
            employee7.First = "Kelly";
            employee7.Last = "Nickle";

            Employee employee8 = new Employee();
            employee8.id = 8;
            employee8.First = "Jane";
            employee8.Last = "Johnson";

            Employee employee9 = new Employee();
            employee9.id = 9;
            employee9.First = "Toby";
            employee9.Last = "Quezzy";

            Employee employee10 = new Employee();
            employee10.id = 10;
            employee10.First = "Jody";
            employee10.Last = "Jordans";

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

            foreach (var employ in employees)
            {
                Console.WriteLine(employ.First + employ.Last + employ.id);
            }
            foreach (var joe in employees)
            {
                if (joe.First == "Joe")
                {
                    temp.Add(joe);
                }
            }
            foreach (var joe in temp)
            {
                Console.WriteLine(joe);
            }
            Console.ReadLine();

            List<Employee> newList = employees.Where(x => x.First == "joe").ToList();
            List<Employee> newList2 = employees.Where(x => x.id > 5).ToList();
        }
    }
}
