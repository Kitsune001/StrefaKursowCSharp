using System;

namespace C1_Tablice_jednowymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            names[0] = "Rick";
            names[1] = "Morty";
            names[3] = "Summer";
            names[2] = "Jerry";
            names[4] = "Beth";
            
            Console.WriteLine("\"Rick and Morty\" main characters:");
            
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            Console.WriteLine(names[4]);

            Console.Read();
        }
    }
}