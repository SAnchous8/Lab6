public class ThreeNumbers
{
    private int firstNumber;
    private int secondNumber;
    private int thirdNumber;

    public ThreeNumbers() : this(0, 0, 0) { }

    public ThreeNumbers(int a, int b, int c)
    {
        firstNumber = a;
        secondNumber = b;
        thirdNumber = c;
    }

    public ThreeNumbers(ThreeNumbers other)
    {
        firstNumber = other.firstNumber;
        secondNumber = other.secondNumber;
        thirdNumber = other.thirdNumber;
    }

    public int FirstNumber
    {
        get { return firstNumber; }
        set { firstNumber = value; }
    }

    public int SecondNumber
    {
        get { return secondNumber; }
        set { secondNumber = value; }
    }

    public int ThirdNumber
    {
        get { return thirdNumber; }
        set { thirdNumber = value; }
    }

    public int GetMaxLastDigit()
    {
        int d1 = Math.Abs(firstNumber % 10);
        int d2 = Math.Abs(secondNumber % 10);
        int d3 = Math.Abs(thirdNumber % 10);
        return Math.Max(d1, Math.Max(d2, d3));
    }

    public override string ToString()
    {
        return $"Numbers: [{firstNumber}, {secondNumber}, {thirdNumber}]";
    }
}