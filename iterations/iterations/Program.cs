using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "you", "sup", "howdy", "yussss", "REEEEEE" };
            Console.WriteLine("enter text:");
            string yourString = Console.ReadLine();
            for (int i =0; i < (name.Length); i++)
            {
                name[i] = (name[i] + yourString);
            }
            for (int i = 0; i < (name.Length); i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("press enter");
            string stop = Console.ReadLine();

            while (stop == "")
            {
                Console.WriteLine("type something to make it stop or press enter to never end");
                stop = Console.ReadLine();
            }

            List<string> names = new List<string> {"bob","dan","rick","phill", "james","jen","julie"};
            Console.WriteLine("type in a name to search");
            string search = Console.ReadLine();
            int indexer = 0;
            bool found = false;
            foreach (string people in names)
            {

                if (search == people)
                {
                    found = true;
                    Console.WriteLine("Your search result is at:" + indexer + " in the list ");
                }
                else if (found == false)
                {
                    found = false;
                }
                indexer++;
                if (indexer == names.Count && found == false)
                {
                    Console.WriteLine("sorry we can't find that name");
                }
               
            }
            List<string> stuff = new List<string> {"apple","house","dog","cat","snoodle"};
            List<string> stuff2 = new List<string> { "orange", "appartment", "dog", "cat", "zombie" };
            foreach (string things in stuff)
            {
                foreach(string things2 in stuff2)
                {
                    if (things == things2)
                    {
                        Console.WriteLine(things + " has appeared in the list");
                    }
                    else
                    {
                        Console.WriteLine(things + " has not appeared in this list");
                    }
                }
            }
            Console.ReadLine();



            //List<int> testScores = new List<int> { 90, 98, 97, 95, 80, 84, 86, 70 };
            //List<int> passingScores = new List<int>();
            //foreach (int score in testScores)
            //{
            //    if (score > 84)
            //    {
            //        passingScores.Add(score);
            //    }
            //}

                //Console.WriteLine(passingScores.Count);
                //Console.ReadLine();
        }
    }
}
