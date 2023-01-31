namespace AreaCalculator.Shapes;

public class Triangle : Abstraction.Shapes
{
    private readonly double _aPart;
    private readonly double _bPart;
    private readonly double _cPart;

    private readonly bool _isSqrtTriangle;

    public Triangle(double aPart, double bPart, double cPart) : base(aPart,bPart,cPart)
    {
        _aPart = aPart;
        _bPart = bPart;
        _cPart = cPart;
        _isSqrtTriangle = false;
    }
    
    public Triangle(double aPart, double bPart) : base(aPart,bPart)
    {
        _aPart = aPart;
        _bPart = bPart;
        _isSqrtTriangle = true;
    }

    
    public override double CalculateArea()
    {
        return SqrtTriangle();
    }

    private double SqrtTriangle()
    {
        if (_isSqrtTriangle)
            return _aPart * _bPart / 2;

        var pPart = (_aPart + _bPart + _cPart) / 2;
        
        return Math.Sqrt(pPart * (pPart - _aPart) * (pPart - _bPart) * (pPart - _cPart));
    }
}