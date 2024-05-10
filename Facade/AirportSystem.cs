﻿using System;
namespace Facade
{
    public class AirportSystem
    {
        public void CheckLuggage()
        {
            Console.WriteLine("The luggage was checked at the airport.");
        }

        public void TransportLuggageToAirplane()
        {
            Console.WriteLine("The luggage was transported to the airplane.");
        }
        public void BoardingCheckIn() 
        {
            Console.WriteLine("The passenger checked in the airport counter.");
        }
        public void CustomsCheck() 
        {
            Console.WriteLine("The passenger went through customs check.");
        }
    }
}

