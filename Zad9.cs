using System;

public class Zad9
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int nine_d = rand.Next(10);
        Console.WriteLine("Zgaduj zgadula liczbe pomiędzy 0 a 9???");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a == nine_d)
        {
            Console.WriteLine("Zgadłeś!");
        }
        else
        {
            Console.WriteLine("Źle! Poprawna odpowiedź to: " + nine_d);
        }


    }
}
