using System;

class Program {
    static void Main() {
        // получилось 546
        int n = 546;
        int b = n / 100;     // вторая цифра x
        int ac = n % 100;    // двузначное из 1-й и 3-й
        int a = ac / 10;
        int c = ac % 10;
        int x = a * 100 + b * 10 + c;
        Console.WriteLine(x);
    }
}
