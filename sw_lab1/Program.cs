
Console.Write("a = ");
if (!double.TryParse(Console.ReadLine(),out var a) || a == 0)
{
    Console.WriteLine("Incorrect a");
    return;
}

Console.Write("b = ");
if (!double.TryParse(Console.ReadLine(),out var b))
{
    Console.WriteLine("Incorrect b");
    return;
}

Console.Write("c = ");
if (!double.TryParse(Console.ReadLine(),out var c))
{
    Console.WriteLine("Incorrect c");
    return;
}

Console.WriteLine($"Equation is: ({a}) x^2 + ({b}) x + ({c}) = 0");

var sqrtD = Math.Sqrt(GetD(a, b, c));

switch (sqrtD)
{
    case 0:
        Console.WriteLine("There are 1 roots");
        Console.WriteLine($"x1 = {GetX(a, b, sqrtD)}");
        break;
    case >0 :
        Console.WriteLine("There are 2 roots");
        Console.WriteLine($"x1 = {GetX(a, b, sqrtD)}");
        Console.WriteLine($"x2 = {GetX(a, b, sqrtD*-1)}");
        break;
    default:
        Console.WriteLine("There are 0 roots");
        break;
}

double GetD(double a, double b, double c)
    => b * b - 4 * a * c;


double GetX(double a, double b, double d)
    => (-1 * b + d) / (2 * a);
