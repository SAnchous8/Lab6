public class ThreeNumbers
{
    private int number1;
    private int number2;
    private int number3;

    public ThreeNumbers()
    {
        number1 = 0;
        number2 = 0;
        number3 = 0;
    }

    public ThreeNumbers(int a, int b, int c)
    {
        number1 = a;
        number2 = b;
        number3 = c;
    }

    public ThreeNumbers(ThreeNumbers other)
    {
        number1 = other.number1;
        number2 = other.number2;
        number3 = other.number3;
    }

    public int Number1
    {
        get { return number1; }
        set { number1 = value; }
    }

    public int Number2
    {
        get { return number2; }
        set { number2 = value; }
    }

    public int Number3
    {
        get { return number3; }
        set { number3 = value; }
    }

    public int GetMaxLastDigit()
    {
        int digit1 = Math.Abs(number1 % 10);
        int digit2 = Math.Abs(number2 % 10);
        int digit3 = Math.Abs(number3 % 10);

        int max = digit1;
        if (digit2 > max) max = digit2;
        if (digit3 > max) max = digit3;

        return max;
    }

    public override string ToString()
    {
        return "Numbers: " + number1 + ", " + number2 + ", " + number3;
    }
}
