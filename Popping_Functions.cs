public static class Popping_Functions
{
    public static int Square(int number)
    {
        return number * number;
    }
    public static double InchesToMm(double inches)
    {
        return inches * 25.4;
    }
    public static double Root(double number)
    {
        return Math.Sqrt(number);
    }
    public static int Cube(int number)
    {
        return number * number * number;
    }
    public static double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
    public static string Greeting(string name)
    {
        return $"Hello, {name}";
    }
}