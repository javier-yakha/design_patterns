namespace AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        QuadrocopterFactory flyFactory = new QuadroFactory();
        ControllerBoard controller = new ControllerBoard(flyFactory);
        Console.ReadKey();
    }
}

