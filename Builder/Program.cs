namespace Builder;

class Program
{
    static void Main(string[] args)
    {
        // Creates a wood house builder
        HouseBuilder woodBuilder = new WoodHouseBuilder();
        // Initializes a civil engineer with the wood house builder
        CivilEngineer whiteHat = new CivilEngineer(woodBuilder);

        // Engineer constructs the house
        whiteHat.ConstructHouse();
        // Gets the constructed house
        House woodenHouse = whiteHat.GetHouse();

        // Displays the house details
        Console.WriteLine(woodenHouse);
        // Waits for a key press to close the console window
        
        Console.ReadKey();
    }
}

//Hous-HousBuilder->wood->stone->Engineer