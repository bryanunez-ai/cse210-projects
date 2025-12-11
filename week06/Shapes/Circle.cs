using System;

public class Circle : Shape
{
    private double _radius;

    public void SetColorAndRadius(string color, double radius)
    {
        _radius = radius;
        SetColor(color);
    }

    public override double GetArea()
    {
        double area = Math.PI * _radius * _radius;
        return area;
    }
}