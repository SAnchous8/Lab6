internal class Program
{
    private static int ReadInt(string message)
    {
        int result = 0;
        string input = "";

        while (true)
        {
            Console.Write(message);
            input = Console.ReadLine();

            if (input == null || input.Length == 0)
            {
                Console.WriteLine("Ошибка: ввод не может быть пустым!");
                continue;
            }

            if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Ошибка: введите целое число!");
            }
        }
    }

    private static void Main()
    {
        Console.WriteLine("=== ТЕСТ ТРЁХ ЧИСЕЛ ===");

        int n1 = ReadInt("Введите первое число: ");
        int n2 = ReadInt("Введите второе число: ");
        int n3 = ReadInt("Введите третье число: ");

        ThreeNumbers obj = new ThreeNumbers(n1, n2, n3);

        Console.WriteLine("\nСоздан объект: " + obj);
        Console.WriteLine("Максимальная последняя цифра: " + obj.GetMaxLastDigit());

        ThreeNumbers copy = new ThreeNumbers(obj);
        Console.WriteLine("Копия: " + copy);

        int newVal = ReadInt("\nВведите новое значение для первого числа: ");
        obj.Number1 = newVal;
        Console.WriteLine("После изменения: " + obj);
        Console.WriteLine("Новая максимальная цифра: " + obj.GetMaxLastDigit());

        Console.WriteLine("\n=== ТЕСТ ТРЕУГОЛЬНИКА ===");

        int a = ReadInt("Введите сторону A: ");
        int b = ReadInt("Введите сторону B: ");
        int c = ReadInt("Введите сторону C: ");

        Triangle tri = new Triangle(a, b, c);

        Console.WriteLine("\n" + tri);
        Console.WriteLine("Периметр: " + tri.GetPerimeter());
        Console.WriteLine("Площадь: " + tri.GetArea());

        if (tri.IsRightTriangle())
        {
            Console.WriteLine("Это прямоугольный треугольник!");
        }
        else
        {
            Console.WriteLine("Это НЕ прямоугольный треугольник");
        }

        Console.WriteLine("Максимальная последняя цифра сторон: " + tri.GetMaxLastDigit());

        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}
