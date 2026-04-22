internal class Program
{
    private static double ReadDouble(string message)
    {
        double result;
        string input;

        while (true)
        {
            Console.Write(message);
            input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ошибка: ввод не может быть пустым!");
                continue;
            }

            input = input.Replace('.', ',');

            if (double.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Ошибка: введите число!");
            }
        }
    }

    private static int ReadInt(string message)
    {
        int result;
        string input;

        while (true)
        {
            Console.Write(message);
            input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
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
        Console.WriteLine("=== ТЕСТ ОТРЕЗКА С ПЕРЕГРУЗКОЙ ОПЕРАТОРОВ ===\n");

        double x = ReadDouble("Введите координату начала отрезка (x): ");
        double y = ReadDouble("Введите координату конца отрезка (y): ");

        LineSegment seg = new LineSegment(x, y);

        Console.WriteLine("\nСоздан отрезок: " + seg);

        double length = !seg;
        Console.WriteLine("Длина отрезка (оператор !): " + length);

        Console.WriteLine("\nДо ++: " + seg);
        seg++;
        Console.WriteLine("После ++: " + seg);

        int intX = (int)seg;
        double doubleY = seg;

        Console.WriteLine("\nЯвное приведение (int)seg = " + intX + " (целая часть start)");
        Console.WriteLine("Неявное приведение double = " + doubleY + " (значение end)");

        int d = ReadInt("\nВведите целое число для сдвига: ");

        LineSegment shifted1 = seg + d;
        LineSegment shifted2 = d + seg;

        Console.WriteLine("seg + " + d + " = " + shifted1);
        Console.WriteLine(d + " + seg = " + shifted2);

        int testNumber = ReadInt("\nВведите целое число для проверки вхождения в отрезок: ");

        if (seg < testNumber)
        {
            Console.WriteLine("Число " + testNumber + " ПРИНАДЛЕЖИТ отрезку (seg < " + testNumber + " = true)");
        }
        else
        {
            Console.WriteLine("Число " + testNumber + " НЕ принадлежит отрезку (seg < " + testNumber + " = false)");
        }

        if (seg > testNumber)
        {
            Console.WriteLine("Оператор >: число " + testNumber + " НЕ принадлежит отрезку");
        }
        else
        {
            Console.WriteLine("Оператор >: число " + testNumber + " ПРИНАДЛЕЖИТ отрезку");
        }

        LineSegment copy = new LineSegment(seg);
        Console.WriteLine("\nКопия отрезка: " + copy);

        double testDouble = ReadDouble("\nВведите дробное число для проверки через Contains: ");
        if (seg.Contains(testDouble))
        {
            Console.WriteLine("Метод Contains: число " + testDouble + " ПРИНАДЛЕЖИТ отрезку");
        }
        else
        {
            Console.WriteLine("Метод Contains: число " + testDouble + " НЕ принадлежит отрезку");
        }

        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}
