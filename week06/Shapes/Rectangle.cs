using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public void SetColorAndDimensions(string color, double length, double width)
    {
        _length = length;
        _width = width;
        SetColor(color);
    }

    public override double GetArea()
    {
     double area = _length * _width;
     return area;
    }
}