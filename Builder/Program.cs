namespace Builder;

class Program
{
    static void Main(string[] args)
    {
        StoneHouseBuilder shb = new StoneHouseBuilder(); // Creates a wood house builder
        CivilEngineer engineer = new CivilEngineer(shb); // Initializes a civil engineer with the wood house builder

        engineer.ConstructHouse(); // Engineer constructs the house
        House myHouse = engineer.GetHouse(); // Gets the constructed house

        Console.WriteLine(myHouse); // Displays the house details
        Console.ReadKey(); // Waits for a key press to close the console window
    }
}

//Hous-HousBuilder->wood->stone->Engineer