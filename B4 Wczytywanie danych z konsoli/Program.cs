using System;

namespace B4_Wczytywanie_danych_z_konsoli
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            
            Console.WriteLine("Stranger: Ouch, I didn't knew someone is here. What's your name?");
            Console.Write("You: My name is: ");
            name = Console.ReadLine();
            
            Console.WriteLine("Stranger: Hello, " + name + ", nice to meet you.");

            Console.Read();
        }
    }
}