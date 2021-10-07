using System;

namespace D2_Instrukcja_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;

            switch (x)
            {
                case 1:
                    Console.WriteLine("X = 1");
                    break;
                case 2:
                    Console.WriteLine("X = 2");
                    break;
                case 3:
                    Console.WriteLine("X = 3");
                    break;
                default:
                    Console.WriteLine("X is not equal 1, 2 or 3.");
                    break;
            }

            Console.Read();
        }
    }
}