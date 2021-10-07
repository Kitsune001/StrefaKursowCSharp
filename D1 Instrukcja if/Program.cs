using System;

namespace D1_Instrukcja_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            if (x == 1)
            {
                Console.WriteLine("X = 1");
            }
            else if (x == 2)
            {
                Console.WriteLine("X = 2");
            }
            else if (x == 3)
            {
                Console.WriteLine("X = 3");
            }
            else
            {
                Console.WriteLine("X is not equal 1, 2 or 3");
            }

            Console.Read();
        }
    }
}