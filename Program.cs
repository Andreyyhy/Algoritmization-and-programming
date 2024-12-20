internal class Program
{
    static int ProverkaInt(string n)
    {
        while (true)
        {
            int number;

            try
            {

                number = Convert.ToInt32(n);
                if (number > 0)
                {
                    return number;
                }
                else
                {
                    Console.Write("Введите натуральное число!: ");
                    n = Console.ReadLine();
                }


            }
            catch
            {
                Console.Write("Введите натуральное число!: ");
                n = Console.ReadLine();
            }
        }
    }

    static int ProverkaInt5(string n)
    {
        while (true)
        {
            int number;

            try
            {
                if (n.Length == 5)
                {
                    number = Convert.ToInt32(n);
                    if (number > 0)
                    {
                        return number;
                    }
                    else
                    {
                        Console.Write("Введите натуральное пятизначное число!: ");
                        n = Console.ReadLine();
                    }
                }
                else
                {
                    Console.Write("Введите натуральное пятизначное число!: ");
                    n = Console.ReadLine();
                }

            }
            catch
            {
                Console.Write("Введите пятизначное число!: ");
                n = Console.ReadLine();
            }
        }
    }

    static int ProverkaInt4(string n)
    {
        while (true)
        {
            int number;

            try
            {
                if (n.Length == 4)
                {
                    number = Convert.ToInt32(n);
                    if (number > 0)
                    {
                        return number;
                    }
                    else
                    {
                        Console.Write("Введите натуральное пятизначное число!: ");
                        n = Console.ReadLine();
                    }
                }
                else
                {
                    Console.Write("Введите натуральное пятизначное число!: ");
                    n = Console.ReadLine();
                }

            }
            catch
            {
                Console.Write("Введите пятизначное число!: ");
                n = Console.ReadLine();
            }
        }
    }

    static int ProverkaIntQuarter(string n)
    {
        while (true)
        {
            int number;

            try
            {

                number = Convert.ToInt32(n);
                if (number == 1 || number == 2 || number == 3 || number == 4)
                {
                    return number;
                }
                else
                {
                    Console.Write("Введите четверть!: ");
                    n = Console.ReadLine();
                }


            }
            catch
            {
                Console.Write("Введите четверть!: ");
                n = Console.ReadLine();
            }
        }
    }

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
                Console.Write("Введите число!: ");
                n = Console.ReadLine();
            }
        }
    }

    private static void Main(string[] args)
    {
        /* 1
        Console.Write("Enter the x: ");
        double x = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y: ");
        double y = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the radious r: ");
        double r = ProverkaDouble(Console.ReadLine());
        if (x > r + 1 && y > r)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
        */

        /* 2
        Console.Write("Enter the x1: ");
        double x1 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y1: ");
        double y1 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the x2: ");
        double x2 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y2: ");
        double y2 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the x: ");
        double x = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y: ");
        double y = ProverkaDouble(Console.ReadLine());
        if (x >= x1 && x <= x2 && y <= y1 && y >= y2)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
        */

        /* 3
        Console.Write("Enter the x1: ");
        double x1 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y1: ");
        double y1 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the x2: ");
        double x2 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y2: ");
        double y2 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the x3: ");
        double x3 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y3: ");
        double y3 = ProverkaDouble(Console.ReadLine());
        if ((x1 == x2 && x1 == x3 && x3 == x2) || (y1 == y2 && y2 == y3 && y1 == y3))
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
       */

        /* 4
        Console.Write("Enter the side of the square: ");
        double a = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the radius: ");
        double r = ProverkaDouble(Console.ReadLine());
        if (2 * r <= a)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
       */

        /* 5
        Console.Write("Enter the centre a: ");
        double a = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the centre b: ");
        double b = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the x: ");
        double x = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y: ");
        double y = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the radius r: ");
        double r = ProverkaDouble(Console.ReadLine());
        if (a + r <= x && b + r <= y)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
       */

        /* 6
        Console.Write("Enter the x: ");
        double x = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y: ");
        double y = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the radius r: ");
        double r = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the distance d: ");
        double d = ProverkaDouble(Console.ReadLine());
        if (x + 2 * r <= d && y + 2 * r <= d)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }  
       */

        /* 7
        Console.Write("Enter the a: ");
        double a = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the b: ");
        double b = ProverkaDouble(Console.ReadLine());
        double sum = a + b;
        if (sum % 1 == 0)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
       */

        /* 8
        Console.Write("Enter the side of triengle a: ");
        double a = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the side of triengle b: ");
        double b = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the side of triengle c: ");
        double c = ProverkaDouble(Console.ReadLine());
        if(a == b || a == c || b == c)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
        */

        /* 9
        Console.Write("Enter the side of triengle a: ");
        double a = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the side of triengle b: ");
        double b = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the side of triengle c: ");
        double c = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the side of triengle a1: ");
        double a1 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the side of triengle b1: ");
        double b1 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the side of triengle c1: ");
        double c1 = ProverkaDouble(Console.ReadLine());
        double k1 = a / a1;
        double k2 = b / b1;
        double k3 = c / c1;
        if (k1 == k2 && k1 == k3 && k2 == k3)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
       */

        /* 10
        Console.Write("Enter the katet of triengle a: ");
        double a = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the katet of triengle b: ");
        double b = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the katet of triengle c: ");
        double c = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the side of triengle d: ");
        double d = ProverkaDouble(Console.ReadLine());
        double k1 = a / b;
        double k2 = c / d;
        if (k1 == k2)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
       */

        /* 11
        Console.Write("Enter the a: ");
        double a = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the b: ");
        double b = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the c: ");
        double c = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the d: ");
        double d = ProverkaDouble(Console.ReadLine());
        double sr = Math.Pow(a * b * c, 1.0 / 3.0);
        if(d == sr)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
       */

        /* 12
        Console.Write("Enter the x: ");
        double x = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y: ");
        double y = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the quarter: ");
        double a = ProverkaIntQuarter(Console.ReadLine());
        double x1, y1;

        switch (a)
        {
            case 1:
                if (x > 0 && y > 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
                break;
            case 2:
                if (x < 0 && y > 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
                break;

            case 3:
                if (x < 0 && y < 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
                break;

            case 4:
                if (x > 0 && y < 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
                break;
        }
       */

        /* 13
        Console.Write("Enter the x1: ");
        double x1 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y1: ");
        double y1 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the x2: ");
        double x2 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y2: ");
        double y2 = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the x: ");
        double x = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y: ");
        double y = ProverkaDouble(Console.ReadLine());
        if (x >= x1 && x <= x2 && y <= y1 && y >= y2)
        {
            Console.Write(false);
        }
        else
        {
            Console.Write(true);
        }
       */

        /* 14
        Console.Write("Enter the side a of the first rectangle: ");
        double a = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the side b of the first rectangle: ");
        double b = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the side c of the second rectangle: ");
        double c = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the side d of the second rectangle: ");
        double d = ProverkaDouble(Console.ReadLine());
        if ((a <= c && b <= d) || (a <= d && b <= c))
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
       */

        /* 15
        Console.Write("Enter the Pythogorean tringle a: ");
        int a = ProverkaInt(Console.ReadLine());
        Console.Write("Enter the Pythogorean tringle b: ");
        int b = ProverkaInt(Console.ReadLine());
        Console.Write("Enter the Pythogorean tringle c: ");
        int c = ProverkaInt(Console.ReadLine());
        if (c * c == a * a + b * b)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
       */

        /* 16
         Console.WriteLine("Введите стороу треугольника А: ");
         double a = ProverkaDouble(Console.ReadLine());

         Console.WriteLine("Введите стороу треугольника Б: ");
         double b = ProverkaDouble(Console.ReadLine());

         Console.WriteLine("Введите стороу треугольника С: ");
         double c = ProverkaDouble(Console.ReadLine());

         if ((a + b > c) && (a + c > b) && (b + c > a))
         {
             Console.WriteLine("Треугольник существует");
         }
         else
         {
             Console.WriteLine("Треугольник не существует");
         }
        */

        /* 17
        Console.Write("Enter the four-digit number N: ");
        int N = ProverkaInt4(Console.ReadLine());
        Console.Write("Enter the digit M: ");
        int M = ProverkaInt(Console.ReadLine());
        int n1 = N / 1000;
        int n2 = N / 100 % 10;
        int n3 = N / 10 % 10;
        int n4 = N % 10;
        if(n1 == M || n2 == M || n3 == M || n4 == M)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
       */

        /* 18
        Console.Write("Enter the a: ");
        int a = ProverkaInt(Console.ReadLine());
        Console.Write("Enter the b: ");
        int b = ProverkaInt(Console.ReadLine());
        Console.Write("Enter the c: ");
        int c = ProverkaInt(Console.ReadLine());
        int mult = a * b;
        if (mult % c == 0)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
        */

        /* 19
        Console.Write("Enter the geometric mean c: ");
        double c = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the number a: ");
        double a = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the number b: ");
        double b = ProverkaDouble(Console.ReadLine());
        double gm = Math.Sqrt(a * b);
        if (c == gm)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
       */

        /* 20
        Console.Write("Enter the radius r: ");
        double r = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the radius R: ");
        double R = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the x: ");
        double x = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y: ");
        double y = ProverkaDouble(Console.ReadLine());
        double distance = Math.Sqrt(x * x + y * y);
        if (distance >= r && distance <= R)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
        */

        /* 21
        Console.Write("Enter the centre a: ");
        double a = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the centre b: ");
        double b = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the x: ");
        double x = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y: ");
        double y = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the radius r: ");
        double r = ProverkaDouble(Console.ReadLine());
        if (a + r <= x && b + r <= y)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
       */

        /* 22
        Console.Write("Enter the x-coordinate: ");
        double x = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y-coordinate: ");
        double y = ProverkaDouble(Console.ReadLine());
        if (x >= -Math.Sqrt(2) && x <= Math.Sqrt(2) && y >= 0 && y <= 2 - x * x)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
       */

        /* 23
        Console.Write("Enter the natural four-didit N: ");
        int N = ProverkaInt4(Console.ReadLine());
        int n1 = N / 1000;
        int n2 = N / 100 % 10;
        int n3 = N / 10 % 10;
        int n4 = N % 10;
        if (n1 < n2 && n2 < n3 && n3 < n4)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }  
       */

        /* 24
        Console.Write("Enter the radius R: ");
        double R = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the x-coordinate: ");
        double x = ProverkaDouble(Console.ReadLine());
        Console.Write("Enter the y-coordinate: ");
        double y = ProverkaDouble(Console.ReadLine());
        if (x * x + y * y <= R * R && y <= x && y >= -x)
        {
            Console.WriteLine("Точка лежить в області.");
        }
        else
        {
            Console.WriteLine("Точка не лежить в області.");
        }
       */

        /* 25
        Console.Write("Enter the natural five-digit number N: ");
        int N = ProverkaInt5(Console.ReadLine());
        int n1 = N / 10000;
        int n2 = N / 1000 % 10;
        int n3 = N / 100 % 10;
        int n4 = N / 10 % 10;
        int n5 = N % 10;
        int sum = n1 + n2 + n3 + n4 + n5;
        double sqrt = Math.Sqrt(sum);
        if (sqrt % 1 == 0)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
       */

        Console.ReadLine();
    }
}