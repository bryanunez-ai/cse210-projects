using System;

public class Square : Shape
{
    private double _side;

    public void SetColorAndSide(string color, double side)
    {
        _side = side;
        SetColor(color);
    }

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}