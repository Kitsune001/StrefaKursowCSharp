using System;

namespace E2_Petla_for_each
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] players = {"Tomiko15", "Jerry99", "ninJa", "operator1", "Tsuki1989", "NanaCat"};

            Console.WriteLine("Players: ");
            foreach (string i in players)
            {
                Console.WriteLine("- " + i);
            }


            int[] tomHP = { 100, 97, 78, 55, 32, 17, 11, 0 };

            Console.WriteLine("Tom's HP every round:");
            int _round = 0;
            foreach (int i in tomHP)
            {
                _round++;
                Console.Write("Round: " + _round);
                Console.WriteLine(" | Tom's HP: " + i);
            }

            Console.Read();
        }
    }
}