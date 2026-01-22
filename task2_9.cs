using System;

class Program {
    static void Main() {
        int a = int.Parse(Console.ReadLine()!); // двузначное
        int tens = a / 10;
        int ones = a % 10;
        Console.WriteLine(tens);
        Console.WriteLine(ones);
        Console.WriteLine(tens + ones);
        Console.WriteLine(tens * ones);
    }
}
