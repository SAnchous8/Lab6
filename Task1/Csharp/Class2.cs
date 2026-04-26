public class Triangle : ThreeNumbers
{

    public Triangle() : base(1, 1, 1)
    {
    }

    public Triangle(int a, int b, int c) : base(a, b, c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Ошибка: стороны должны быть положительными!");
        }
        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Ошибка: треугольник нельзя построить!");
        }
    }

    public Triangle(Triangle other) : base(other)
    {
    }

    public int GetPerimeter()
    {
        return Number1 + Number2 + Number3;
    }

    public double GetArea()
    {
        double p = GetPerimeter() / 2.0;
        double a = Number1;
        double b = Number2;
        double c = Number3;

        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return area;
    }

    public bool IsRightTriangle()
    {
        int a = Number1;
        int b = Number2;
        int c = Number3;

        if (a * a + b * b == c * c)
        {
            return true;
        }
        if (a * a + c * c == b * b)
        {
            return true;
        }
        if (b * b + c * c == a * a)
        {
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return "Triangle: A = " + Number1 + ", B = " + Number2 + ", C = " + Number3;
    }
}
