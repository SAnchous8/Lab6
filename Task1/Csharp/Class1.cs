public class ThreeNumbers
{
    private int _number1;
    private int _number2;
    private int _number3;

    public ThreeNumbers()
    {
        _number1 = 0;
        _number2 = 0;
        _number3 = 0;
    }

    public ThreeNumbers(int a, int b, int c)
    {
        _number1 = a;
        _number2 = b;
        _number3 = c;
    }

    public ThreeNumbers(ThreeNumbers other)
    {
        _number1 = other._number1;
        _number2 = other._number2;
        _number3 = other._number3;
    }

    public int Number1
    {
        get
        {
            return _number1;
        }
        set
        {
            _number1 = value;
        }
    }

    public int Number2
    {
        get
        {
            return _number2;
        }
        set
        {
            _number2 = value;
        }
    }

    public int Number3
    {
        get 
        {
            return _number3;
        }
        set
        {
            _number3 = value;
        }
    }

    public int GetMaxLastDigit()
    {
        int digit1 = Math.Abs(_number1 % 10);
        int digit2 = Math.Abs(_number2 % 10);
        int digit3 = Math.Abs(_number3 % 10);

        int max = digit1;
        if (digit2 > max)
        {
            max = digit2;
        }
        if (digit3 > max)
        {
            max = digit3;
        }

        return max;
    }

    public override string ToString()
    {
        return "Numbers: " + _number1 + ", " + _number2 + ", " + _number3;
    }
}
