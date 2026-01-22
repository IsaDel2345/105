using System;

class Program {
    static void Main() {
        int k = int.Parse(Console.ReadLine()!); // 1..150

        int index = (k + 2) / 3;        // 1..50
        int num = 100 + index;          // 101..150
        int pos = (k - 1) % 3;          // 0 сотни, 1 десятки, 2 единицы

        int digit;
        if (pos == 0) digit = num / 100;
        else if (pos == 1) digit = (num / 10) % 10;
        else digit = num % 10;

        Console.WriteLine(digit);
    }
}
