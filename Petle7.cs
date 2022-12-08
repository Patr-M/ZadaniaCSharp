using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Csharp
{
    internal class Petle7
    {
        static void Mainp7(string[] args)
        {
            int x = 0;
            int suma = 0;
            do
            {
                suma += x;
                x++;
                
            }
            while (x <= 100);
            Console.WriteLine(suma);
        }
    }
}