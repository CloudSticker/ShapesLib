namespace ShapesLib;

public class Triangle : Shape
{
    private readonly double _aSide;
    private readonly double _bSide;
    private readonly double _cSide;
    public Triangle(double aSide, double bSide, double cSide)
    {
        _aSide = aSide;
        _bSide = bSide;
        _cSide = cSide;
    }

    public override double CalculateArea()
    {
        var p = (_aSide + _bSide + _cSide) / 2;

        return Math.Sqrt(p * (p - _aSide) * (p - _bSide) * (p - _cSide));
    }

    public bool RectangularCheck()
    {
        var sides = new[] { _aSide, _bSide, _cSide };
        Array.Sort(sides);
        var a = sides[2];
        var b = sides[1];
        var c = sides[0];
        return Math.Abs(a * a - b * b - c * c) == 0;
    }
}