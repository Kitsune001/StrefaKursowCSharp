using System;

namespace E3_Petle_while_i_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 20)
            {
                Console.WriteLine("Hello nr: " + i);
                i++;
            }
            
            int j = 1;
            do
            {
                Console.WriteLine("Is 1 bigger than 3? I don't think so...");
            } while (j > 3);

            Console.Read();
        }
    }
}