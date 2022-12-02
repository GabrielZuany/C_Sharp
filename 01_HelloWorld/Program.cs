//modules or packages
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {
             
            Console.Write("Hello World!\n");
            Console.WriteLine("Jump a line without '\\n'");

            //var
            int age = 20;
            string name = "Gabriel";
            const char genre = 'M';
            bool value = true;
            double height = 1.69;
            string x = Console.ReadLine();
            Console.WriteLine(x);
            Console.WriteLine(age);
            Console.WriteLine(name);
            Console.WriteLine(value);
            Console.WriteLine(height);
            Console.WriteLine(genre);


        }

    }

}