//Калькулятор

using System;

namespace test_app
{
    internal class Program
    {
        static void add(int value1, int value2)
        {
            Console.WriteLine(value1 + value2);
        }

        static void minus(int value1, int value2)
        {
            Console.Write(value1 - value2);
        }

        static void multip(int value1, int value2)
        {
            Console.WriteLine(value1 * value2);
        }

        static void dilenia(int value1, int value2)
        {
            double result = value1 / value2;
            Console.WriteLine(result);
        }

        static int choise_metod()
        {
            int z;
            Console.WriteLine("Виберіть дію:");
            Console.WriteLine("1. Додавання");
            Console.WriteLine("2. Віднімання");
            Console.WriteLine("3. Множення");
            Console.WriteLine("4. Ділення");

            z = Int32.Parse(Console.ReadLine());
            return z;
        }

        static void Main(string[] args)
        {
            int finish=1;
            Console.WriteLine("Вас вітає наш примітивний калькулятор, розрочнімо роботу!");

            while (finish==1)
            {
                int a, b, znak;

                znak = choise_metod();

                Console.WriteLine("Введіть число 1:");
                a = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введіть число 2:");
                b = Int32.Parse(Console.ReadLine());

                switch (znak)
                {
                    case 1:
                        add(a, b);
                        break;

                    case 2:
                        minus(a, b);
                        break;

                    case 3:
                        multip(a, b);
                        break;

                    case 4:
                        dilenia(a, b);
                        break;
                }

                Console.WriteLine("Бажаєте продовжити?");
                Console.WriteLine("1. Так");
                Console.WriteLine("2. Ні");
                finish = Int32.Parse(Console.ReadLine());
            }

        }
    }
}
