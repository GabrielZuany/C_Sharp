using System;
using System.Collections.Generic;
using System.Text;

namespace DOTNET_Class_Library_MSLEARN{

    class Program{
        static void Main(string[] args) {

            Random program = new Random(); 
            /*  
                Random is a class in the .NET Class Library and stores the reference to the new object in a variable named program.
                The new operator does several important things:
                - It first requests an address in the computer's memory large enough to store a new object based on the Random class.
                - It creates the new object and stores it at the memory address.
                - It returns the memory address so that it can be saved in the program variable.
            */

            int rand = program.Next(1, 7); 
            // calls the program object's Next() method passing in two parameters: the minimum and maximum value of the random number.
            int rand2 = program.Next(1, 7);

            int higher = Math.Max(rand, rand2); // class Math.Max() method returns the higher value.

            Console.WriteLine($"n1 = {rand}, n2 = {rand2}. Higher value between these two is {higher}");
        
        }

    }

}