using System;

namespace Csharp
{
    internal class PetleZad1
    {
        static void MainZ1(string[] args)
        {
            float suma = 0;
            int x = 0;
            while (x <= 100)
            {
                x++;
                suma += x;
            }
            Console.WriteLine(suma);
        }
    }
}