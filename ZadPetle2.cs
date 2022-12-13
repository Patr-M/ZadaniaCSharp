using System;

namespace Csharp
{
    internal class PetleZad2
    {
        static void MainZ2(string[] args)
        {
            float suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) 
                    suma += i;
            }
            Console.WriteLine(suma);
        }
    }
}