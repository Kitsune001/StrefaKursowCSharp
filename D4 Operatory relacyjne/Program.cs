using System;

namespace D4_Operatory_relacyjne
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            
            Console.Write("X == Y : ");
            Console.WriteLine(x == y);
            
            Console.Write("X != Y : ");
            Console.WriteLine(x != y);

            Console.Write("X > Y : ");
            Console.WriteLine(x > y);
            
            Console.Write("X < Y : ");
            Console.WriteLine(x < y);
            
            Console.Read();
        }
    }
}