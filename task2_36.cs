using System;

class Program {
    static void Main() {
        int k = int.Parse(Console.ReadLine()!); // 1..180

        int pairIndex = (k + 1) / 2;      // номер пары цифр (1..90)
        int number = 10 + pairIndex - 1;  // двузначное число этой пары

        int tens = number / 10;
        int ones = number % 10;
        int kthDigit = (k % 2 == 1) ? tens : ones; // нечётн -> первая цифра пары

        Console.WriteLine(pairIndex);
        Console.WriteLine(number);
        Console.WriteLine(kthDigit);
    }
}
