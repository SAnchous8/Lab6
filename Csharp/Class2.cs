public class TriangleSides : ThreeNumbers
{
    public TriangleSides() : base(1, 1, 1) { }

    public TriangleSides(int a, int b, int c) : base(a, b, c)
    {
        if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("Треугольник с такими сторонами не может существовать.");
    }

    public TriangleSides(TriangleSides other) : base(other) { }

    public int CalculatePerimeter()
    {
        return FirstNumber + SecondNumber + ThirdNumber;
    }

    public double CalculateArea()
    {
        double p = CalculatePerimeter() / 2.0;
        return Math.Sqrt(p * (p - FirstNumber) * (p - SecondNumber) * (p - ThirdNumber));
    }

    public bool IsRightAngled()
    {
        int a2 = FirstNumber * FirstNumber;
        int b2 = SecondNumber * SecondNumber;
        int c2 = ThirdNumber * ThirdNumber;
        return a2 + b2 == c2 || a2 + c2 == b2 || b2 + c2 == a2;
    }

    public override string ToString()
    {
        return $"Triangle sides: A = {FirstNumber}, B = {SecondNumber}, C = {ThirdNumber}";
    }
}