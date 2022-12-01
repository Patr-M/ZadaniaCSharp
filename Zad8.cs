using System;

public class Zad8
{
    static void Main8(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Podałeś 0 ciołku!");
            return;
        }

        Console.WriteLine((c - b) / a);
    }
}
