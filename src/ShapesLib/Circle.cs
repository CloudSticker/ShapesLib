﻿namespace ShapesLib;

public class Circle : Shape
{
    private readonly double _radius;
    public Circle(double radius) 
        => _radius = radius;
    public override double CalculateArea() => _radius * Math.PI;
}