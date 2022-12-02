/*
Previously, we set out to write code that would store Order IDs belonging to potentially fraudulent orders. 
Our hope is to find fraudulent orders as early as possible and flag them for deeper analysis.

Our team found a pattern. Orders that start with the letter "B" encounter fraud 25 times the normal rate.
We will write new code that will output the Order ID of new orders where the Order ID starts with the letter "B". 
This will be used by our fraud team to investigate further.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace ARRAYS_MSLEARN{

    class Program{
        static void Main(string[] args){
            string[] prod = new string[8] {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

            foreach(string item in prod){
                if(item.StartsWith("B")){
                    Console.WriteLine(item);
                }
            }

        }
    }

}