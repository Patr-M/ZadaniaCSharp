using System;

namespace Csharp
{
    internal class PetleZad6
    {
        static void MainZ6(string[] args)
        {
            float suma = 0;
            int x = 0;
            do
            {
                if (x % 2 != 0)
                    suma += x;
                x++;
            }
            while (x <= 100);
            Console.WriteLine(suma);
        }
    }
}