using System;

class Program {
    static void Main() {
        int x = int.Parse(Console.ReadLine()!);
        int a = x / 100, b = (x / 10) % 10, c = x % 10;

        int[] d = { a, b, c };
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (j != i)
                    for (int k = 0; k < 3; k++)
                        if (k != i && k != j)
                            Console.WriteLine(d[i] * 100 + d[j] * 10 + d[k]);
    }
}
