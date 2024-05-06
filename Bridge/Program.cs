namespace Bridge;

class Program
{
    static void Main(string[] args)
    {
        // Creating a rectangle object using a 'GreenRectangle' drawing method.
        Shape greenRectangle = new Rectangle(new GreenRectangle(), 100, 200, 32, 32);

        // Drawing the rectangle.
        greenRectangle.Draw();

        // Creating a circle object using a 'YellowCircle' drawing method.
        Shape yellowCircle = new Circle(new YellowCircle(), 50, 40, 24, 32);

        // Drawing the circle.
        yellowCircle.Draw();

        // Prevents the console window from closing immediately.
        Console.ReadKey();
    }
}
