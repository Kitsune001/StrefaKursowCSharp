using System;

namespace E4_Polecenia_break_i_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            // break is breaking whole look
            Console.WriteLine("===== BREAK =====");
            for(var i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    break;
                }
                
                Console.WriteLine("i = " + i);
            }
            
            // continue is breaking just current iteration of loop
            Console.WriteLine("===== CONTINUE =====");
            for(var j = 0; j < 5; j++)
            {
                if (j == 3)
                {
                    continue;
                }
                
                Console.WriteLine("j = " + j);
            }

            Console.Read();
        }
    }
}