namespace BeispielFactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        Logistics logisticsSoftware = new SeaStreetFlightLogistics();

        Console.Write("Which route would you like to use to deliver this goods?");
        Console.WriteLine();

        string transportType = string.Empty;
        var input = Console.ReadLine();
        if (input is not null) transportType = input;

        Console.WriteLine();

        // Add a transport type as an argument
        Transport kundenTransport = logisticsSoftware.ManageTransportForCustomer(transportType);

        Console.WriteLine("(r)estart or (q)uit");
        var keyInput = Console.ReadLine();
        if (keyInput is not null && keyInput.Length == 1) Main(args);

        Console.ReadKey();
    }
}

