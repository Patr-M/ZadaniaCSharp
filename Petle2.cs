using System;
namespace Csharp
{
    internal class Petle2
    {
        static void Mainp2(string[] args)
        {

            int x = 0;
            do
            {
                float y = 3 * x;
                Console.WriteLine("x:" + x + " y:" + y);
                x++;
            }
            while (x <= 10);

        }
    }
}