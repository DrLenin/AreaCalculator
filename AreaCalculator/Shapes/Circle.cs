namespace AreaCalculator.Shapes;

public class Circle : Abstraction.Shapes
{
    private readonly double _radius;

    public Circle(double radius) : base(radius)
    {
        _radius = radius;
    }
    
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}