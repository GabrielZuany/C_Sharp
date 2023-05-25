using System;

namespace _005
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = Console.ReadLine();
            string secondSentence = Console.ReadLine();

            string[] vec = secondSentence.Split(' ');
            // or: string[] vec = Console.Readline().Split(' ');

            Console.WriteLine(firstSentence);
            Console.WriteLine(secondSentence);
            Console.WriteLine("vec[0]" + vec[0]);
            Console.WriteLine("vec[1]" + vec[1]);
            Console.WriteLine("vec[2]" + vec[2]);


            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(n1.GetType());
        }
    }
}