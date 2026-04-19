internal class Program
{
    private static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ошибка: пустой ввод.");
                continue;
            }
            if (double.TryParse(input.Replace('.', ','), out double result))
                return result;
            Console.WriteLine("Ошибка: введите число.");
        }
    }

    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ошибка: пустой ввод.");
                continue;
            }
            if (int.TryParse(input, out int result))
                return result;
            Console.WriteLine("Ошибка: введите целое число.");
        }
    }

    private static void Main()
    {
        Console.WriteLine("=== ТЕСТИРОВАНИЕ LineSegment ===\n");

        // Ввод
        double x1 = ReadDouble("Первая координата: ");
        double x2 = ReadDouble("Вторая координата: ");
        LineSegment s = new LineSegment(x1, x2);
        Console.WriteLine($"Создан отрезок: {s}\n");

        // 1. Унарный !
        Console.WriteLine($"!s (длина) = {!s:F2}");

        // 2. Унарный ++
        Console.WriteLine($"До ++:    {s}");
        s++;
        Console.WriteLine($"После ++:  {s}");

        // 3. Приведение типов
        Console.WriteLine($"\n(int)s     = {(int)s} (целая часть StartX)");
        Console.WriteLine($"(double)s  = {(double)s:F2} (значение EndX)");

        // 4. Бинарный + с int
        int d = ReadInt("\nВведите целое число для сдвига: ");
        Console.WriteLine($"s + {d}     = {s + d}");
        Console.WriteLine($"{d} + s     = {d + s}");

        // 5. Оператор < (проверка вхождения)
        int test = ReadInt("\nВведите число для проверки вхождения: ");
        Console.WriteLine($"s < {test}   = {s < test} (число {(s < test ? "принадлежит" : "НЕ принадлежит")} отрезку)");
        Console.WriteLine($"s > {test}   = {s > test}");

        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}
