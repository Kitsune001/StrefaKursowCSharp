using System;
using static System.Console;

namespace D3_Wyrażenia_warunkowe
{
    class Program
    {
        private static void Main(string[] args)
        {
            var playerHealth = 0;
            
            Console.Write("Player HP: ");
            playerHealth = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(playerHealth > 0 ? "Player is alive." : "Player is dead.");

            Console.Read();
        }
    }
}