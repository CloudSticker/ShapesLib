namespace ShapesLib;

public static class AreaCalculator
{
    public static double Calculate<T>(T shape) where T : Shape
        => shape.CalculateArea();
}