namespace Singelton;

class Program
{
    static void Main(string[] args)
    {
        // Accessing the Singleton instance
        BasicSingleton obj1 = BasicSingleton.GetInstance();
        Console.ReadKey();
    }
}

