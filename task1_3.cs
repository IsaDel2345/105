using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine()!;
        Console.WriteLine($"Вы ввели число {s.Replace(',', '.')}");
    }
}
