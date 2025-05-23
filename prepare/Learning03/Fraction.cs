class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public Fraction()
    {
        this.numerator = 1;
        this.denominator = 1;
    }

    public Fraction(int numerator)
    {
        this.numerator = numerator;
        this.denominator = 1;
    }
    public int GetNumerator()
    {
        return numerator;
    }
    public void SetNumerator(int numerator)
    {
        this.numerator = numerator;
    }
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }
    public double GetDecimalValue()
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Denominator cannot be zero.");
        }
        return (double)numerator / denominator;
    }
}