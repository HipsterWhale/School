class Square : Shape
{
    private double _side;

    public override double GetArea()
    {
        return _side * _side;
    }

    public Square(double side)
    {
        _side = side;
    }
}