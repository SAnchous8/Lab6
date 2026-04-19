internal class Program
{
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
        Console.WriteLine("=== Тестирование ThreeNumbers ===\n");

        // Базовый класс
        int n1 = ReadInt("Число 1: ");
        int n2 = ReadInt("Число 2: ");
        int n3 = ReadInt("Число 3: ");

        ThreeNumbers obj = new ThreeNumbers(n1, n2, n3);
        Console.WriteLine($"Объект: {obj}");
        Console.WriteLine($"Копия: {new ThreeNumbers(obj)}");
        Console.WriteLine($"Макс. последняя цифра: {obj.GetMaxLastDigit()}");

        obj.FirstNumber = ReadInt("\nНовое значение для первого числа: ");
        Console.WriteLine($"Обновлён: {obj}");
        Console.WriteLine($"Новая макс. цифра: {obj.GetMaxLastDigit()}");

        // Дочерний класс
        Console.WriteLine("\n=== Тестирование TriangleSides ===\n");

        TriangleSides tri = null;
        while (tri == null)
        {
            int a = ReadInt("Сторона A: ");
            int b = ReadInt("Сторона B: ");
            int c = ReadInt("Сторона C: ");
            try { tri = new TriangleSides(a, b, c); }
            catch (ArgumentException ex) { Console.WriteLine($"Ошибка: {ex.Message}\n"); }
        }

        Console.WriteLine($"\nТреугольник: {tri}");
        Console.WriteLine($"Копия: {new TriangleSides(tri)}");
        Console.WriteLine($"Периметр: {tri.CalculatePerimeter()}");
        Console.WriteLine($"Площадь: {tri.CalculateArea():F2}");
        Console.WriteLine($"Прямоугольный: {(tri.IsRightAngled() ? "да" : "нет")}");
        Console.WriteLine($"Макс. последняя цифра сторон: {tri.GetMaxLastDigit()}");

        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}
