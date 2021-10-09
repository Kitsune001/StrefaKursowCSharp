using System;

namespace D5_Operatory_logiczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var isPlayerAlive = true;
            var playerHP = 23;
            var playerShield = 17;
            
            // Negacja / ! / zaprzeczenie / NOT
            if ( !(isPlayerAlive) )
            {
                Console.WriteLine("Player is dead.");
            }
            else
            {
                Console.WriteLine("Player is alive.");
                
                // Koniunkcja / && / i / AND
                if ((playerHP < 50) && (playerShield < 50))
                {
                    Console.WriteLine("Player is low HP and low shield.");
                }

                // Alternatywa / || / lub / OR
                if ((playerHP > 50) || (playerShield > 50))
                {
                    Console.WriteLine("Player is in good condition.");
                }
            }
            
            Console.Read();
        }
    }
}