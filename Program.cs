internal class Program
{
    static double ProverkaDouble(string n)
    {
        while (true)
        {
            double number;
            try
            {
                number = Convert.ToDouble(n);
                return number;
            }
            catch
            {
                Console.Write("Enter the x: ");
                n = Console.ReadLine();
            }
        }
    }

    private static void Main(string[] args)
    {
        Console.Write("Enter the x: ");
        double x = ProverkaDouble(Console.ReadLine());
        double y;

        /* 1
        double q = 3 / 4 + Math.Cos(Math.Sqrt(x + Math.Abs(x * x - Math.Exp(x))));
        double w = Math.Pow(Math.Log10(Math.Pow(x,3) - Math.Cos(x)), 2);
        y = Math.Pow(Math.Atan(q/w), 2);
        Console.Write(y);
        */

        /*2
        double q = Math.Exp(Math.Pow((x*x - 1.8), 3.0 / 4.0));
        double w = (Math.Pow(x, 4.5) / Math.Pow(Math.Atan(3 * x * x + 2 / 3), 4.0));
        y = q + w - Math.Sqrt(Math.Pow(x, 3.2));
        Console.Write(y);
        */

        /* 3
        double q = (Math.Pow(x, 2.8) / (Math.Pow(Math.Cos(Math.Pow(x * x * x - 3.7, 2)), 2)) + Math.Sqrt(Math.Abs(3*x)));
        double w = Math.Pow(Math.Atan(x / Math.Log10(Math.Abs(x))), 5);
        y = q - w;
        Console.Write(y);
        */

        /* 5
        double q = Math.Pow(3.14, x) - Math.Pow(x, 3.0 / 5.0);
        double w = Math.Sqrt(x * x + Math.Pow(Math.Log10(Math.Pow(Math.Exp(Math.Log(Math.Abs(x * x * x - 3.7))), 3)), 2));
        y = (q / w) + Math.Pow(9, 4.7);
        Console.Write(y);
        */

        /* 6
        double q = Math.Pow(Math.Sin(x) - 6 / 7, 3 * x);
        double e = Math.Abs(Math.Pow(Math.Exp(Math.Log(x - Math.Exp(Math.Log(3.5)))),2));
        double w = Math.Pow(Math.Abs(e), 1.0 / 3.0);
        y = q + w - 2 / 3;
        Console.Write(y);
        */

        /* 7
        double q = Math.Pow(Math.Pow(Math.Sin(Math.Pow(x, 1.0 / 5.0)), 3) + Math.Pow(Math.Cos(x * x), 3), 3.0 / 4.0);
        double e = Math.Abs(x) + Math.Exp(Math.Pow(x + 3.7, 1.0 / 3.0));
        double w = Math.Pow(Math.Log10(e), 2) + Math.Sqrt(3 * x);
        y = q / w;
        Console.Write(y);
        */

        /* 8
        double q = (x * x * x + Math.Sqrt(Math.Abs(3 * x))) / Math.Pow(x*x + Math.Exp(x), 3.0/7.0);
        double w = Math.Pow(Math.Exp(Math.Log(Math.Pow(Math.Log10(q), 3))), 4);
        double e = (Math.Pow(x, 3.0 / 5.0)) / (Math.Pow(Math.Sin(x * x * x + 7.8), 2));
        y = w - e;
        Console.Write(y); 
        */

        /* 9
        double q = Math.Pow(Math.Tan(x * x + Math.Acos(Math.Sqrt(Math.Abs(x - 7.3)))), 5);
        double w = Math.Pow(Math.Sin(Math.Pow(x * x + 1.5, 5.0 / 7.0)), 2);
        double e = q / w;
        y = e + Math.Pow(Math.Pow(5 * x, 3.5), 1.0 / 3.0);
        Console.Write(y);
        */

        /* 10
        double e = Math.Pow(x * x + 8.8, 5);
        double r = Math.Pow(Math.Sin(e), 3);
        double q = Math.Pow(r - Math.Sqrt(5 * x), 4.0 / 7.0);
        double w = Math.Exp(3.0 / 8.0) / (Math.Pow(x, 2.5) + Math.Sqrt(Math.Abs(2 * x)));
        y = q - w;
        Console.Write(y);
        */

        /* 11
        double q = Math.Pow(Math.Sin(Math.Pow(Math.Pow(x, 4) + Math.Pow(Math.Exp(Math.Log(Math.Pow(Math.Log10(Math.Pow(Math.Sqrt(7 * x) - Math.Pow(Math.Abs(x), 1.0 / 3.0), 2)), 3))), 2), 5.0 / 4.0)), 3);
        double w = Math.Pow(2.9, Math.Pow(x, 1.0 / 3.0)) - Math.Sqrt(Math.Abs(5 * x));
        y = q * w;
        Console.Write(y);
        */

        /* 12
        double q = Math.Pow(Math.Abs(x * x + 7.8), 1.0 / 3.0);
        double w = Math.Pow(Math.Cos(Math.Pow(3 * x * x * x - 1.5, 6)), 2);
        double e = Math.Sqrt(x) + q / w;
        double r =Math.Pow(e, 3.0 / 8.0);
        y = Math.Pow(Math.Tan(r), 3) - Math.Pow(x, 2.7);
        Console.Write(y);
        */

        /* 13
        double q = Math.Pow(x, 4.0 / 5.0) * Math.Pow(Math.Pow(Math.Cos(Math.Abs(2 * x) - Math.Pow(Math.Pow(x, 4.0 / 5.0) + 5.3, 1.0 / 3.0) + Math.Atan(x * x)), 2), 5);
        double w = Math.Exp(2) / (1 + Math.Pow(x, 6.6));
        y = q + w;
        Console.Write(y);
        */

        /* 14
        double q = Math.Pow(Math.Abs(x) + Math.Sqrt(Math.Pow(x, 4.0 / 5.0) + 2.7), 1.0 / 3.0);
        double w = Math.Pow(Math.Cos(x * x * x * Math.Pow(1 + x, 4.0 / 5.0)), 2);
        y = q / w - Math.Pow(x, 7.5);
        Console.Write(y);
        */

        /* 15
        double q = Math.Pow(Math.Cos(Math.Pow(Math.Sqrt(Math.Abs(3 * x)) + Math.Pow(Math.Cos(Math.Pow(Math.Pow(x, 2.0 / 7.0) + 5.4, 3)), 3), 7)), 3);
        double w = Math.Atan(Math.Exp(Math.Sqrt(x)) + Math.Pow(7.8, 3.0 / 7.0));
        y = q - w;
        Console.Write(y);
        */

        /* 16
        double x, y, a1, a2, a3, b1, b2, b3, e1, e2;

        a1 = Math.Pow(x, 3.0 / 7.0);
        a2 = Math.Pow(Math.Sin(x), 2) - Math.Log10(x * x);
        a3 = a1 + Math.Sqrt(a2);

        b1 = 6.5 * x + Math.Log10(x);
        b2 = x + Math.Pow(b1, 1.0 / 3.0);
        b3 = (Math.Log(b2));

        e1 = (2.0 / 5.0) + x * x;
        e2 = Math.Exp(e1);

        y = (a3 / b3) - e2;

        Console.WriteLine($"The result = {y}");
        */

        /* 17
        double q = Math.Pow(Math.Cos(x * x + Math.Sqrt(x + 2)), 2);
        double w = Math.Sin(x * x + Math.Sqrt(x));
        double e = Math.Pow(Math.Exp(Math.Log(x)), 2) / Math.Log10(x) + Math.Exp(Math.Sqrt(x));
        y = q / w + e;
        Console.Write(y);
        */

        /* 19
        double q = Math.Pow(x + Math.Pow(Math.Cos(x), 2) + Math.Sin(x * x) + Math.Exp(Math.Log(x)), 1.0 / 3.0);
        double w = x * x + Math.Pow(Math.Exp(Math.Log(x * x * x)), 2.0 / 3.0) - Math.Exp(Math.Sqrt(2 * x));
        y = q / w;
        Console.Write(y);
        */

        /* 20
        double q = Math.Sqrt(x + Math.Sqrt(x + Math.Pow(Math.Sin(x), 2)));
        double w = Math.Cos(x * x + Math.Pow(Math.Exp(Math.Log(1 + Math.Exp(Math.Sqrt(3 * x)))), 3.0 / 5.0));
        y = q / w;
        Console.Write(y);
        */

        /* 21
        double q = 2 * Math.Pow(x, 3.0 / 5.0) + Math.Sin(2 * x + Math.Log10(Math.Sqrt(3 * x * x * x + 6.3)));
        double w = Math.Exp(Math.Log(Math.Abs(x + Math.Exp(Math.Sqrt(3 * x)))));
        y = q / w;
        Console.Write(y);
        */

        /* 22
        double q = x * Math.Pow(3 * x + Math.Sqrt(Math.Pow(x, 2.0 / 3.0) + 1.5), 1.0 / 3.0);
        double w = Math.Pow(Math.Tan(q), 3.0 / 7.0);
        double e = Math.Pow(Math.Log10(x * x + 4.5 * Math.Exp(3 * x)), 2);
        y = w / e;
        Console.Write(y);
        */

        /* 23
        double q = Math.Sqrt(x * x * x + Math.Sqrt(x + 3.5));
        double w = Math.Pow(Math.Cos(x + Math.Sin(q)), 2);
        y = w + Math.Exp(x);
        Console.Write(y);
        */

        /* 24
        double e = 4 * x * x - Math.Sin(3 * x - Math.Pow(x, 1.0 / 4.0));
        double q = Math.Pow(x, 3.0 / 5.0) / (Math.Pow(Math.Tan(e), 2.0 / 3.0));
        y = q + Math.Cos(Math.Abs(x - 2 * 2 * 2));
        Console.Write(y);
        */

        /* 25
        double q = Math.Sqrt(Math.Log10(Math.Abs(4 * x)) - Math.Pow(x, 2.0 / 3.0));
        double e = Math.Pow(x * x * x - 7.4, 3);
        y = (Math.Sqrt(3 * x * x + q)) / (Math.Pow(Math.Sin(e), 2.0 / 3.0) + Math.Pow(2.77, 5));
        Console.Write(y);
        */

        Console.ReadLine();

    }
}