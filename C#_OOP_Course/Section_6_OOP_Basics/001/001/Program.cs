using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            // double x = null; //error: cannot convert null to 'double' because it is a non-nullable value type
            Nullable<double> x = null;
            double? y = null;
            y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("x is null");

            }


            // Null coalescence operator.
            double? x2 = null;
            double y2 = x2 ?? 5; // if x2 is null, y2 = 5
        }
    }
}
