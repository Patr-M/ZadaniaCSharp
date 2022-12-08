using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Csharp
{
    internal class Petle6
    {
        static void Main6(string[] args)
        {
            int suma = 0;
            for (int i = 0; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);
        }
    }
}