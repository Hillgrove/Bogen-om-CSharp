
var triangle = new Triangle(5, 5);
Console.WriteLine(triangle.Area);

public class Triangle
{
    public int Base { get; private set; }
    public int Height { get; private set; }
    public double Area { get { return Base * Height * 0.5; }}


    public Triangle(int triangleBase, int height)
    {
        Base = triangleBase;
        Height = height;
    }
}


