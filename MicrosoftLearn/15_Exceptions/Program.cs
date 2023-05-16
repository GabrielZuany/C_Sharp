using System;

class Program
{
    static void CheckAge(int age)
    {
        if(age<18)
        {
            throw new ArithmeticException("Access denied - You must be at least 18 years old.");
        }
        else
        {
            Console.WriteLine("Access granted - You are old enough!");
        }
    }

    static void Main()
    {
        Console.WriteLine("\nTry catch exception:");
        try
        {
        int[] myNumbers = {1, 2, 3};
        Console.WriteLine(myNumbers[10]);
        }
        catch (Exception e)
        {
        Console.WriteLine(e.Message);
        }

        Console.WriteLine("\n----------------\n");

        Console.WriteLine("Throw new exception:");
        CheckAge(14);
        
    }

}