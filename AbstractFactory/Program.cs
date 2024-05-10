using AbstractFactory.Family;
using AbstractFactory.Family.Quadro;
using AbstractFactory.Family.Fly;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadrocopterFactory flyFactory = new FlyFactory();
            ControllerBoard flyController = new ControllerBoard(flyFactory);

            Console.WriteLine();

            Console.WriteLine(flyController);

            Console.WriteLine("\n\t------\n");

            QuadrocopterFactory quadroFactory = new QuadroFactory();
            ControllerBoard quadroController = new ControllerBoard(quadroFactory);

            Console.WriteLine();

            Console.WriteLine(quadroController);

            Console.ReadKey();
        }
    }
}

