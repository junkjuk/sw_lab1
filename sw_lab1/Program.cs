using sw_lab1;

var a = ReadNumber("a = ");
var b = ReadNumber("b = ");
var c = ReadNumber("c = ");

var quadraticEquation = new QuadraticEquation(a, b, c);
Console.WriteLine(quadraticEquation.ToString());

var result = quadraticEquation.SolveEquation();
Console.WriteLine($"There are {result.Count()} roots");

var index = 1;
foreach (var x in result)
{
    Console.WriteLine($"x{index++} = {x}");
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

