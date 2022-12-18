using AreaCalc;

class Program
{
    static void Main()
    {
        Triangle triangle = new Triangle(4, 5, 3);
        Console.WriteLine(triangle.GetArea());
        Console.WriteLine(triangle.Rectangular);
    }
}