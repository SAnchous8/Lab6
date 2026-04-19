public class LineSegment
{
    private double startX;
    private double endX;

    public LineSegment() : this(0, 1) { }

    public LineSegment(double x1, double x2)
    {
        startX = Math.Min(x1, x2);
        endX = Math.Max(x1, x2);
    }

    public LineSegment(LineSegment other)
    {
        startX = other.startX;
        endX = other.endX;
    }

    public double StartX
    {
        get { return startX; }
        set
        {
            if (value <= endX) startX = value;
            else { startX = endX; endX = value; }
        }
    }

    public double EndX
    {
        get { return endX; }
        set
        {
            if (value >= startX) endX = value;
            else { endX = startX; startX = value; }
        }
    }

    public double Length { get { return endX - startX; } }

    public bool Contains(double value)
    {
        return value >= startX && value <= endX;
    }

    // ===== ОБЯЗАТЕЛЬНЫЕ ОПЕРАЦИИ ПО ЗАДАНИЮ =====

    // Унарная ! — длина отрезка
    public static double operator !(LineSegment s)
    {
        return s.Length;
    }

    // Унарный ++ — увеличить границы на 1
    public static LineSegment operator ++(LineSegment s)
    {
        s.startX += 1;
        s.endX += 1;
        return s;
    }

    // Явное приведение к int — целая часть startX
    public static explicit operator int(LineSegment s)
    {
        return (int)s.startX;
    }

    // Неявное приведение к double — значение endX
    public static implicit operator double(LineSegment s)
    {
        return s.endX;
    }

    // Бинарный + с int (левосторонний)
    public static LineSegment operator +(LineSegment s, int d)
    {
        return new LineSegment(s.startX + d, s.endX + d);
    }

    // Бинарный + с int (правосторонний)
    public static LineSegment operator +(int d, LineSegment s)
    {
        return s + d;
    }

    // Бинарный < (отрезок < целое число) — проверка вхождения
    public static bool operator <(LineSegment s, int value)
    {
        return s.Contains(value);
    }

    // Бинарный > — парный к <
    public static bool operator >(LineSegment s, int value)
    {
        return !(s < value);
    }

    // ===== СТАНДАРТНЫЕ ПЕРЕОПРЕДЕЛЕНИЯ =====

    public override string ToString()
    {
        return $"[{startX:F2}, {endX:F2}] (L={Length:F2})";
    }

    public override bool Equals(object obj)
    {
        if (obj is LineSegment other)
            return Math.Abs(startX - other.startX) < 0.0000001 &&
                   Math.Abs(endX - other.endX) < 0.0000001;
        return false;
    }

    public override int GetHashCode()
    {
        return startX.GetHashCode() ^ endX.GetHashCode();
    }
}