using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediMindTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates Dictionary
            Dictionary<string, int> people = new Dictionary<string, int>();

            //Adds new persons
            people.Add("Peter Pan", 12);
            people["Captain hook"] = 45;

            //A foreach that writes out keyvaluepair in Dictionary people
            foreach (KeyValuePair<string, int> p in people)
            {
                Console.WriteLine(p);
            }

            //Creates Dictionary and adds "Luke, Han and Chewbacca"
            Dictionary<string, bool> characthers = new Dictionary<string, bool>()
            {
                { "Luke", true},
                { "Han", false},
                {"ChewBacca", false}
            };

            //Removes "Han"
            characthers.Remove("Han");

            //A foreach that writes out KeyValuePair in Dictionary Characthers
            foreach (KeyValuePair<string, bool> c in characthers)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
