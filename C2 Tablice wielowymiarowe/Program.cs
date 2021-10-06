using System;

namespace C2_Tablice_wielowymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] heightmap =
            {
                {0, 3, 5},
                {1, 4, 4},
                {2, 5, 7}
            };
            
            Console.WriteLine( heightmap[0,0] + " | " + heightmap[0,1] +  " | " + heightmap[0,2] );
            Console.WriteLine( heightmap[1,0] + " | " + heightmap[1,1] +  " | " + heightmap[1,2] );
            Console.WriteLine( heightmap[2,0] + " | " + heightmap[2,1] +  " | " + heightmap[2,2] );

            Console.Read();
        }
    }
}