using System;
using System.Security.Cryptography.X509Certificates;

namespace Csharp
{
    internal class Petle8
    {
        static void Main(string[] args)
        {
            int x = 0;
            int suma = 0;
            while (x <= 100)
            {
                suma += x;
                x++;
            }
            Console.WriteLine(suma);

        }
    }
}