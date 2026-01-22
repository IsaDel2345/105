using System;

class Program {
    static void Main() {
        // получилось 654
        int n = 654;
        int c = n / 100;      // последняя цифра x
        int ba = n % 100;     // переставленные a и b
        int b = ba / 10;
        int a = ba % 10;
        int x = a * 100 + b * 10 + c;
        Console.WriteLine(x);
    }
}
