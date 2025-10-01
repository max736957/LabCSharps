namespace Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть сторону a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть сторону b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть сторону c: ");
            double c = double.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Сторони трикутника повинні бути додатніми числами!");
                return;
            }

            if (IsValidTriangle(a, b, c))
            {
                Console.WriteLine("Периметр трикутника: " + GetPerimeter(a, b, c));
                Console.WriteLine("Площа трикутника: " + GetArea(a, b, c));
                Console.WriteLine("Тип трикутника - " + GetTriangleType(a, b, c));
            }
            else
            {
                Console.WriteLine("Трикутник з такими сторонами не існує.");
                return;
            }
        }

        public static bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        public static double GetArea(double a, double b, double c)
        {
            double s = GetPerimeter(a, b, c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "рівносторонній";
            }
            else if (a == b || a == c || b == c)
            {
                return "рівнобедрений";
            }
            else
            {
                double max = Math.Max(a, Math.Max(b, c));
                double sumSquares = a * a + b * b + c * c - max * max;

                if (Math.Abs(sumSquares - max * max) < 1e-10)
                {
                    return "прямокутний";
                }
            }
            return "довільний";
        }
    }
}
