using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xunit;

namespace ShapesLib.Tests;

public class UnitTest1
{
    #region MainTests
    
    [Fact]
    public void TriangleTest4()
    {
        var triangle = new Triangle(3, 4, 5);

        Assert.True(triangle.RectangularCheck());
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void ArrayOfShapes_CorrectArea(Shape shape, double result)
    {
        var area = AreaCalculator.Calculate(shape);
        Assert.Equal(result, area);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        return new List<object[]>
        {
            new object[] { new Circle(1), 3.141592653589793 },
            new object[] { new Circle(21), 65.97344572538566 },
            new object[] { new Circle(7), 21.991148575128552 },
            new object[] { new Triangle(3, 4, 5), 6 },
            new object[] { new Triangle(5, 12, 13), 30 },
            new object[] { new Triangle(7, 9, 15), 20.69269194667528 },
        };
    }

    #endregion
}