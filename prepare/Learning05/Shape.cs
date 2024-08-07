using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

public abstract class Shape
{
    private string _color;


    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;    
    }

    //create a constructor that accepts the color and sets it.

    public abstract double GetArea();
}



public class Square : Shape
{
    private double _side;

    public Square(double side, string color) : base (color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}



public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width, string color) : base (color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}



public class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color) : base (color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}