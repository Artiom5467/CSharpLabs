public class Figure
{
    private readonly Point[] _points;

    public Figure(params Point[] points)
    {
        if (points.Length < 3)
        {
            throw new ArgumentException("Фігура повинна мати щонайменше 3 точки");
        }

        _points = points;
    }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void PerimeterCalculator()
    {
        double perimeter = 0;

        for (int i = 0; i < _points.Length - 1; i++)
        {
            perimeter += LengthSide(_points[i], _points[i + 1]);
        }

        perimeter += LengthSide(_points[^1], _points[0]);

        Console.WriteLine($"Периметр {_points.Length}-кутника: {perimeter}");
    }

    public override string ToString()
    {
        string figureName = GetType().Name;

        return $"{figureName} {_points.Select(p => p.ToString()).Aggregate((a, b) => $"{a}, {b}")}";
    }
}