using System;

namespace Csharp
{
    internal class PetleZad4
    {
        static void MainZ4(string[] args)
        {
            float suma = 0;
            int x = 0;
            while (x <= 100)
            {
                if (x % 2 == 0)
                suma += x;
             x++;
            }
            Console.WriteLine(suma);
        }
    }
}