using System;

class Program {
    static void Main() {
        // получилось 564
        int n = 564;
        int a = n % 10;   // первая цифра x
        int bc = n / 10;  // оставшиеся две
        int x = a * 100 + bc;
        Console.WriteLine(x);
    }
}
