using Geometric_figuresss;

Figure fig1 = new Figure();
fig1.Geometricfigure();
fig1.Name = "Rectangle";
fig1.Presentation("Rectangle", "Red");

Fig2D fig2 = new Fig2D();
fig2.Geometricfigure();
fig2.Name = "Square";
fig2.Presentation("Square", "Blue");
fig2.Length_side = 10;
fig2.Number_sides = 4;
Console.WriteLine("Perimeter: " + fig2.Getperimeter(10, 4));

Circle circle1 = new Circle();
circle1.Geometricfigure();
circle1.Name = "Circle";
circle1.Color = "Pink";
circle1.Presentation("Circle","Pink");
circle1.Radius = 7.5;
Console.WriteLine("Perimeter:"+circle1.GetCirclePerimeter());
Console.WriteLine("Area: " + circle1.GetCircleArea());

Triangle triangle1 = new Triangle();    
triangle1.Geometricfigure();
triangle1.Name = "Equilateral triangle";
triangle1.Color = "Blue";
triangle1.Length_side = 10;
triangle1.Number_sides = 3;
triangle1.Presentation("Equilateral triangle","Blue");
Console.WriteLine("Perimeter: "+ triangle1.Getperimeter(12,3));
