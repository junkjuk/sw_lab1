namespace sw_lab1;

public class QuadraticEquation
{
    private double _a;
    private double _b;
    private double _c;

    public QuadraticEquation(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public IEnumerable<double> SolveEquation()
    {
        var res = new List<double>();
        var sqrtD = Math.Sqrt(GetD(_a, _b, _c));
        res = sqrtD switch
        {
            0 => new List<double> {GetX(_a, _b, sqrtD)},
            > 0 => new List<double> {GetX(_a, _b, sqrtD), GetX(_a, _b, sqrtD * -1)},
            _ => res
        };
        return res;
    }
    
    private static double GetD(double a, double b, double c)
        => b * b - 4 * a * c;

    private static double GetX(double a, double b, double d)
        => (-1 * b + d) / (2 * a);

    public override string ToString()
        => $"Equation is: ({_a}) x^2 + ({_b}) x + ({_c}) = 0";
}