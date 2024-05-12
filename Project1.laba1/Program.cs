
using System;
using System.ComponentModel.DataAnnotations;
using Project1;
class Progtam
{
    static void Main()
    {
        RationalNumber r1 = new RationalNumber(1, 5);
        RationalNumber r2 = new RationalNumber(6, 15);
        Console.WriteLine(r1);
        Console.WriteLine(r2);
        RationalNumber r = r1 + r2;
        Console.WriteLine(r.ToString());
        Console.WriteLine($"r1 == r2 {r1 == r2}");
        Console.WriteLine($"r1 != r2 {r1 != r2}");
        Console.WriteLine($"r1 > r2 {r1 > r2}");
        Console.WriteLine($"r1 < r2 {r1 < r2}");
        Console.WriteLine($"-r1 {-r1}");
        Console.WriteLine($"-r2 {-r2}");

    }
}