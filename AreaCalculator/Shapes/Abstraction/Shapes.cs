namespace AreaCalculator.Shapes.Abstraction;

public abstract class Shapes
{
    public abstract double CalculateArea();

    protected Shapes(params double[] items)
    {
        if (items.Any(item => item <= 0.0))
        {
            throw new ArgumentException( "Provided Parameters is not a positive double" );
        }
    }
}