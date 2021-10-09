using System;
using System.Threading;

namespace E1_Petla_for
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000); // Sleep app for 1 sec.
            }
            Console.WriteLine("Boom");

            Console.Read();
        }
    }
}