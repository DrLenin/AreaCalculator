namespace Test;

public class CircleTest
{
    [Fact]
    public void CalculateArea_Default_ReturnSquare()
    {
        // Arrange
        const double radius = 5;
        
        var circle = new Circle(radius);
        
        var expectedValue = Math.PI * Math.Pow(radius, 2);

        // Act
        var square = circle.CalculateArea();

        // Assert
        Assert.Equal(square, expectedValue);
    }
    
    [Fact]
    public void CalculateArea_isNotPositiveDouble_ReturnArgumentException()
    {
        // Arrange
        const double radius = -5;

        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}