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
            for (int i = 0; i < (name.Length); i++)
            {
                name[i] = (name[i] + yourString);
            }
            for (int i = 0; i < (name.Length); i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("press enter");
            string stop = Console.ReadLine();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("This assignment is pointless");
            }
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
            List<string> names2 = new List<string> { "bob", "dan", "rick", "phill", "james","bob", "bob", "jen", "julie" };
            Console.WriteLine("type in a name to search");
            string search2 = Console.ReadLine();
            int indexer2 = 0;
            bool found2 = false;
            foreach (string people in names2)
            {

                if (search2 == people)
                {
                    found = true;
                    Console.WriteLine("Your search result is at:" + indexer2 + " in the list ");
                }
                else if (found2 == false)
                {
                    found2 = false;
                }
                indexer2++;
                if (indexer2 == names2.Count && found == false)
                {
                    Console.WriteLine("sorry we can't find that name");
                }
            }
            
            Console.ReadLine();
            List<string> stuff = new List<string> {"apple","dog","house","dog","cat","cat","snoodle"};
            int ii = 0;
            int jj = 0;
            foreach (string things in stuff)
            {
                foreach(string things2 in stuff)
                {
                    if (things == things2 && ii != jj)
                    {
                        Console.WriteLine("index:" + ii + " (" + things + ") " + " was compared at index:" + jj + " (" + things2 + ") " + "which has appeared before!");
                    }
                    else if (ii != jj && things != things2)
                    {
                        Console.WriteLine("index:"+ ii + " ("+things+") " + " was compared at index:" + jj + " (" + things2 + ") " + "which is not a match..."); 
                    }
                    else
                    {
                        Console.WriteLine("index:" + ii + " (" + things + ") " + " was compared at index:" + jj + " (" + things2 + ") " + "which is the starting index and not another instance");
                    }
                    jj++;
                    if (jj == stuff.Count)
                    {
                        jj = 0;
                    }
                }
                ii++;
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
