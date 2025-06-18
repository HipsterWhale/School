class Shape
{
    string _color;
    public virtual string GetColor()
    {
        return _color;
    }
    public virtual void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0.0;
    }
}
