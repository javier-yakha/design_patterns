namespace Decorator;

class Program
{
    static void Main(string[] args)
    {
        // Create a new MacBookPro instance
        MacBookPro pc1 = new MacBookPro();

        // Decorate the MacBookPro with a Touchbar
        MacBookTouchbar macBookProWithTouchbar = new MacBookTouchbar(pc1);

        // Further decorate the MacBookPro with Touchbar by adding an i5 Processor
        MacBookI5Processor macBookProWithTouchAndI5 = new MacBookI5Processor(macBookProWithTouchbar);

        // Output the description and price of the MacBook with Touchbar and i5 processor
        Console.WriteLine(macBookProWithTouchAndI5.GetDescription());
        Console.WriteLine("Price: " + macBookProWithTouchAndI5.GetPrice() + "\n");

        // Create a new MacBookAir instance
        MacBookAir pc2 = new MacBookAir();

        // Decorate the MacBookAir with an M4 processor
        MacBookM4Processor macBookAirWithM4 = new MacBookM4Processor(pc2);

        // Output the descrption and price of the MacBookAir with M4 processor
        Console.WriteLine(macBookAirWithM4.GetDescription());
        Console.WriteLine("Price: " + macBookAirWithM4.GetPrice() + "\n");

        // Wait for a key press to close the console window
        Console.ReadKey();


        //MacBookPro pc1 = new MacBookPro();
        //Console.WriteLine(pc1.GetDescription());
        //Console.WriteLine(pc1.GetPrice());
        //Console.ReadKey();
    }
}

//IMacBook
//Air
//Pro
//Addon
//touchbar
//Aufgabe
//processor