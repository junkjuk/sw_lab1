using sw_lab1;

double a = 0;
double b = 0;
double c = 0;

if (args.Length == 0)
{
    a = ReadNumber("a = ");
    b = ReadNumber("b = ");
    c = ReadNumber("c = ");
}
else
{
    try
    {
        var numbers = GetNumbersFromFile(args[0]);
        a = numbers[0];
        b = numbers[1];
        c = numbers[2];
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return;
    }
}

var quadraticEquation = new QuadraticEquation(a, b, c);
Console.WriteLine(quadraticEquation.ToString());

var result = quadraticEquation.SolveEquation();
Console.WriteLine($"There are {result.Count()} roots");

var index = 1;
foreach (var x in result)
{
    Console.WriteLine($"x{index++} = {x}");
}
//
List<double> GetNumbersFromFile(string path)
{
    path = Path.Combine(Directory.GetCurrentDirectory(), path);
    if (!File.Exists(path))
    {
        Console.WriteLine();
        throw new Exception("File not exist");
    }
    var res = new List<double>();
    var line = File.ReadLines(path).First();
    var numbs = line.Split(" ");
    res.Add(double.Parse(numbs[0]));
    res.Add(double.Parse(numbs[1]));
    res.Add(double.Parse(numbs[2]));
    return res;
}

double ReadNumber(string question)
{
    var isInvalid = false;
    double numb = 0;
    
    Console.Write(question);
    while (!isInvalid)
    {
        isInvalid = double.TryParse(Console.ReadLine(), out numb);
        if (isInvalid)
            return numb;
        Console.WriteLine($"Error. Expected a valid real number, got invalid instead");
        Console.Write(question);
    }
    
    return numb;
}

