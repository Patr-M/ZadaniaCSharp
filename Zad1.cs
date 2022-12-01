using System;
namespace Csharp
{
    internal class Zad1
    {
        static void Main1(string[] args)
        {
            
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());

                if ((a * a) + (b * b) == (c * c))
                {
                     Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            
        }
    }
}