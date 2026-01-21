using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("a) a/(b/c)");
        Console.WriteLine("б) (a*b)/c");
        Console.WriteLine("в) a/(b*c)");
        Console.WriteLine("г) a+(b/c)");
        Console.WriteLine("д) a+(b/c)");
        Console.WriteLine("е) a+b/(b+c)");
        Console.WriteLine("ж) a+b/(b+c)");
        Console.WriteLine("з) a/Math.Sin(b)");
        Console.WriteLine("и) (1.0/2)*a*b*Math.Sin(x)");
        Console.WriteLine("к) 2*b*c*Math.Cos(a/2.0)/(b+c)");
        Console.WriteLine("л) 4*R*Math.Sin(a/2.0)*Math.Sin(b/2.0)*Math.Sin(c/2.0)");
        Console.WriteLine("м) (a*x+b)/(c*x+d)");
        Console.WriteLine("н) 2*Math.Sin((a+b)/2.0)*Math.Cos((a-b)/2.0)");
        Console.WriteLine("о) Math.Abs(2*Math.Sin(-3*Math.Abs(x/2.0)))");
    }
}
