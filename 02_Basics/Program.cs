using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Basics
{

    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Cmp_AB(a, b);

            int c  = Sum(a, b);
            Console.WriteLine(a + " + " + b + " = " + c);

            ManipulateArray(); 
            SwitchMenu();
        }


        //----Functions----
        static void Cmp_AB(int a, int b)
        {
            if(a>b){
                Console.WriteLine("a > b");
            }else{
                if(a == b){
                    Console.WriteLine("a == b");
                }else{
                    Console.WriteLine("a < b");
                }
            }
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void ManipulateArray(){
            int[] arr = new int[5] {1, 2, 3, 4, 5}; //static size 5.

            foreach(int i in arr){
                Console.WriteLine(i);
            }
        }

        static void SwitchMenu(){
            Console.WriteLine("----Menu----");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Substract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.Write(">>> ");

            int option = Convert.ToInt32(Console.ReadLine()); // read a string from console and convert to integer.

            int n1 = 1;
            int n2 = 2;
            switch (option)
            {
                case 1:
                    Add(n1, n2);
                    break;
                case 2:
                    Sub(n1, n2);
                    break;
                case 3:
                    Multiply(n1, n2);
                    break;
                case 4:
                    Divide(n1, n2);
                    break;
                default: Console.WriteLine("Option not listed");
                    break;
            }
        }

        static void Add(int a, int b){
            Console.WriteLine(a + " + " + b + " = " + (a+b));
        }

        static void Sub(int a, int b){
            Console.WriteLine(a + " - " + b + " = " + (a-b));
        }

        static void Multiply(int a, int b){
            Console.WriteLine(a + " * " + b + " = " + (a*b));
        }

        static void Divide(int a, int b){
            Console.WriteLine(a + " / " + b + " = " + ((double)a/b));
        }

    }
}