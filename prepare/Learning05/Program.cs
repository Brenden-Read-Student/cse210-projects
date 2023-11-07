using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Red", 3);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle(3,5,"Orange");
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Blue",7);
        shapes.Add(circle1);

        foreach (Shape name in shapes)
        {
            //this is only possible because of Polymorphism
             string shapeColor = name.GetColor();   
             double shapeArea = name.GetArea();
             Console.WriteLine($"The {shapeColor} shape has an area of {shapeArea} inches");
        }
        //also the instructions of the assigmnet were not very clear and I had to reffer to the 
        //sample solution to fugure out that I was not suposed to ask the user for any inputs and
        // that I needed to output both the color and area for each Shape.
    }
}