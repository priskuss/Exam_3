public static class PoppingFunctions
{
    public static Func<int, int> Square()
    {
        return number => number * number;
    }

    public static Func<double, double> InchesToMm()
    {
        return inches => inches * 25.4;
    }

    public static Func<double, double> Root()
    {
        return Math.Sqrt;
    }

    public static Func<int, int> Cube()
    {
        return number => number * number * number;
    }

    public static Func<double, double> CircleArea()
    {
        return radius => Math.PI * radius * radius;
    }

    public static Func<string, string> Greeting()
    {
        return name => $"Hello, {name}";
    }

    public static int ApplyFunction(Func<int, int> function, int number)
    {
        return function(number);
    }

    public static double ApplyFunction(Func<double, double> function, double number)
    {
        return function(number);
    }

    public static string ApplyFunction(Func<string, string> function, string input)
    {
        return function(input);
    }
}