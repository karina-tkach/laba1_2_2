namespace _4
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Вводьте рядки послідовно один за одним.");
            Console.WriteLine("Поки вони матимуть вигляд 0 x чи 1 x чи 2 x");
            Console.WriteLine("(тобто, цифра від 0 до 2, а після неї запис конкретного дійсного числа),");
            Console.WriteLine("програма обчислюватиме одну з трьох функцій:");
            Console.WriteLine("\t0 -- sqrt(abs(x))");
            Console.WriteLine("\t1 -- x^3 (інакше кажучи, x*x*x)");
            Console.WriteLine("\t2 -- x + 3,5");
            Console.WriteLine("(згідно цифри на початку) і виводитиме результат.");
            Console.WriteLine();
            Console.WriteLine("Якщо вхідний рядок не задовольнятиме цей формат, програма завершить роботу.");

            Func<double, double>[] functions = {
            x => Math.Sqrt(Math.Abs(x)),
            x => Math.Pow(x, 3),
            x => x + 3.5 };

            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] parts = input.Split(' ');

                    int choice = int.Parse(parts[0]);
                    double x = double.Parse(parts[1]);

                    double result = functions[choice](x);
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Виникла помилка: {ex.Message}. Програма завершує роботу.");
                    break;
                }
            }

            Console.WriteLine("Дякую за використання програми. Всього найкращого!");
        }
    }

}