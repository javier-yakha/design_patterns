using System;
namespace Facade
{
	public class Hotel
	{
        public void TransportLuggageToRoom()
        {
            Console.WriteLine("The luggage was taken to the hotel room.");
        }
        public void CheckIn() 
        {
            Console.WriteLine("The passenger checked in at the hotel.");
        }
        public void AccomodateGuest() 
        {
            Console.WriteLine("The passenger was taken to his room.");
        }
    }
}

