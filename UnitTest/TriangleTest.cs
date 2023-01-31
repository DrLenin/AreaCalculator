namespace Test;

public class TriangleTest
{
    [Fact]
    public void CalculateArea_Triangle_ReturnSquare()
    {
        // Arrange
        const double aPart = 5;
        const double bPart = 5;
        
        var triangle = new Triangle(aPart, bPart);
        
        const double expectedValue = aPart * bPart / 2;

        // Act
        var square = triangle.CalculateArea();

        // Assert
        Assert.Equal(square, expectedValue);
    }
    
    [Fact]
    public void CalculateArea_SqrtTriangle_ReturnSquare()
    {
        // Arrange
        const double aPart = 5;
        const double bPart = 5;
        const double cPart = 5;
        
        var triangle = new Triangle(aPart, bPart, cPart);
        
        const double pPart = (aPart + bPart + cPart) / 2;
        
        var expectedValue = Math.Sqrt(pPart * (pPart - aPart) * (pPart - bPart) * (pPart - cPart));

        // Act
        var square = triangle.CalculateArea();

        // Assert
        Assert.Equal(square, expectedValue);
    }
    
    [Fact]
    public void CalculateArea_isNotPositiveDouble_ReturnArgumentException()
    {
        // Arrange
        const int aPart = -5;
        const int bPart = 5;
        const int cPart = 5;

        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => new Triangle(aPart, bPart, cPart));
    }
}