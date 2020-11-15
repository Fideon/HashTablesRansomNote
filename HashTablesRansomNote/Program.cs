using System;
using System.Collections.Generic;

namespace HashTablesRansomNote
{
    class Program
    {
        static void checkMagazine(string[] magazine, string[] note)
        {
            HashSet<string> magDict = new HashSet<string>(magazine);

            bool match = false;

            foreach(string s in note)
            {
                match = magDict.Remove(s);
                if (match == false) break;
            }

            Console.WriteLine(match ? "Yes" : "No");
        }

        static void Main(string[] args)
        {
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            checkMagazine(magazine, note);
        }
    }
}
