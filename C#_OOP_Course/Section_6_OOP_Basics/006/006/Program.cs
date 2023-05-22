using System;
using System.Collections.Generic;

namespace _006
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> list_2 = new List<string> {"Isadora", "Gabriel", "Jheam" };
            list_2.Add("Rodrigo");
            list_2.Insert(0, "Raplh");

            foreach (string item in list_2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------");

            string first = list_2.Find(x => x[0] == 'R'); // Lambda expression. "I want X such that X[0] is equal to 'G'".
            Console.WriteLine("First 'R': " + first);

            string last = list_2.FindLast(x => x[0] == 'R');
            Console.WriteLine("Last 'R': " + last);

            int firstIndex = list_2.FindIndex(x => x[0] == 'R');
            Console.WriteLine("First index 'R': " + firstIndex);

            int lastIndex = list_2.FindLastIndex(x => x[0] == 'R');
            Console.WriteLine("Last index 'R': " + lastIndex);

            Console.WriteLine("--------------------------");

            List<string> list_3 = list_2.FindAll(x => x.Length > 5);
            Console.WriteLine("Names with more than 5 characters: ");
            foreach (string item in list_3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------");


            list_2.RemoveAll(x => x.Length <= 5);
            Console.WriteLine("List 2 after remove names in witch length is lower than 6");
            foreach (string item in list_2)
            {
                Console.WriteLine(item);
            }
        }
    }
}