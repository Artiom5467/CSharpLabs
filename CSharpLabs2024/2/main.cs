Point A = new Point(1, 2, "A");
Point B = new Point(4, 6, "B");
Point C = new Point(8, 3, "C");
Point D = new Point(5, 1, "D");

Figure triangle = new Figure(A, B, C);
Console.WriteLine(triangle);
triangle.PerimeterCalculator();

Figure quadrilateral = new Figure(A, B, C, D);
Console.WriteLine(quadrilateral);
quadrilateral.PerimeterCalculator();