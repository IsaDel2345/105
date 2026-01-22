using System;

class Program {
    static void Main() {
        // получилось 456
        int n = 456;
        int ac = n / 10;   // двузначное из 1-й и 3-й цифры x
        int b = n % 10;    // вторая цифра x
        int a = ac / 10;
        int c = ac % 10;
        int x = a * 100 + b * 10 + c;
        Console.WriteLine(x);
    }
}
