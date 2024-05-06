using System;
namespace Facade
{
    public class FacadeTravelManagement
    {
        private AirportSystem airport;
        private Airplane plane;
        private LocalTransportCompany company;
        private Hotel hotel;

        public FacadeTravelManagement()
        {
            airport = new AirportSystem();
            plane = new Airplane();
            company = new LocalTransportCompany();
            hotel = new Hotel();
        }

        public void SendLuggage()
        {
            airport.CheckLuggage();
            airport.TransportLuggageToAirplane();
            plane.PutLuggageIn();
            plane.PutLuggageOut();
            company.PutLuggageIntoTruck();
            company.TransportLuggageToHotel();
            hotel.TransportLuggageToRoom();
        }
        public void PassengerTravel()
        {
            airport.BoardingCheckIn();
            airport.CustomsCheck();
            plane.BoardIn();
            plane.BoardOut();
            company.PickUpAtAirport();
            company.DropOffAtHotel();
            hotel.CheckIn();
            hotel.AccomodateGuest();
        }
    }
}
