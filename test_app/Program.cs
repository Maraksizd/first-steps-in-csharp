//Перевірка з трикутниками+вивід доаткової інформації про трикутник

using System;

namespace test_app
{
    internal class Program
    {
        private const double pi = 3.14;

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int a, b, c;
            Console.WriteLine("Привіт, ця програма створена для перевірки трикутника на правильність. Щоб перевірити, чи трикутник правильний, введіть довжину сторін:");

            Console.WriteLine("Введіть сторону a:");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введіть сторону b:");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введіть сторону c:");
            c = Int32.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("\nТакий трикутник існує!\n");

                double S = triangle_area(a, b, c);
                Console.WriteLine("Його площа буде становити: " + S);
                find_angle(a, b, c);
            }
            else
            {
                Console.WriteLine("\nТакого трикутника не існує");
            }
        }

        static void find_angle(int a, int b, int c)
        {
            double s = triangle_area(a, b, c);

            double Ha = 2 * s / a;
            double Hb = 2 * s / b;
            double Hc = 2 * s / c;

            double A, B, C;

            A = Math.Asin(Ha / c);
            B = Math.Asin(Hb / a);
            C = Math.Asin(Hc / b);

            double angle_a = A * 180 / pi;
            double angle_b = B * 180 / pi;
            double angle_c = C * 180 / pi;

            int angA = Convert.ToInt32(angle_a);
            int angB= Convert.ToInt32(angle_b);
            int angC= Convert.ToInt32(angle_c);

            Console.WriteLine("Кут А: " + angA+" градусів");
            Console.WriteLine("Кут В: " + angB + " градусів");
            Console.WriteLine("Кут С: " + angC + " градусів");
        }

        static double triangle_area(int x, int y, int z)
        {
            int P = x + y + z;
            double area = Math.Sqrt(P / 2 * (P / 2 - x) * (P / 2 - y) * (P / 2 - z));
            return area;
        }
    }
}
