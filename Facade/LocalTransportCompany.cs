using System;
namespace Facade
{
	public class LocalTransportCompany
	{
        public void PutLuggageIntoTruck()
        {
            Console.WriteLine("The luggage was loaded into a truck.");
        }

        public void TransportLuggageToHotel()
        {
            Console.WriteLine("The luggage was transported to the hotel.");
        }
        public void PickUpAtAirport() 
        {
            Console.WriteLine("The passenger was picked up at the airport.");
        }
        public void DropOffAtHotel() 
        {
            Console.WriteLine("The passenger was dropped off at the hotel.");
        }
    }
}

