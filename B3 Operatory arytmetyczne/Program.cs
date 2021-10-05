using System;

namespace B3_Operatory_arytmetyczne
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 7;

            Console.WriteLine( a + " + " + b + " = " + (a + b) );
            Console.WriteLine( a + " - " + b + " = " + (a - b) );
            Console.WriteLine( a + " * " + b + " = " + (a * b) );
            Console.WriteLine( a + " / " + b + " = " + (a / b) );
            
            // Modulo operator. This operator is keeping remainder from divide.
            Console.WriteLine( a + " % " + b + " = " + (a % b) );

            Console.ReadLine();
        }
    }
}