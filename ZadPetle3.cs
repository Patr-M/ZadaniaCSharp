using System;

namespace Csharp
{
    internal class PetleZad3
    {
        static void MainZ3(string[] args)
        {
            float suma = 0;
            int x = 0;
            do
            {
                if (x % 2 == 0)
                    suma += x;
                x++; 
            }
            while (x <= 100);
            Console.WriteLine(suma);
        }
    }
}