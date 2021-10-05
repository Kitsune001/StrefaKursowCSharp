using System;

namespace B2_Typy_zmiennych
{
    class Program
    {
        private static void Main(string[] args)
        {
            char playerGender = 'M';
            byte playerId = 217;
            string playerName = "MojoJojo";
            int playerHealth = 9000;
            float playerOxygen = 67.8f;
            double playerMoney = 6867941.47;
            bool playerHasGun = true;
            
            Console.WriteLine("PLAYER STATS:");
            Console.WriteLine("Name: " + playerName);
            Console.WriteLine("Gender: " + playerGender);
            Console.WriteLine("ID: " + playerId);
            Console.WriteLine("Health: " + playerHealth);
            Console.WriteLine("Oxygen: " + playerOxygen);
            Console.WriteLine("Money: " + playerMoney);
            Console.WriteLine("Holds gun: " + playerHasGun);
            
            Console.ReadLine();
        }
    }
}