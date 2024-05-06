using System;

namespace BeispielFactoryMethod
{
    public class SeaStreetFlightLogistics : Logistics
    {
        protected override Transport TransportFactory(string transportType)
        {
            Transport transport = null;
            transport = transportType switch
            {
                "street" => new StreetTransport(),
                "air" => new FlightTransport(),
                "sea" => new SeaTransport(),
                "camel" => new CamelTransport(),
                _ => throw new NotSupportedException($"Transport by {transportType} is not supported")
            };
            
            // Console.WriteLine("Invalid transport type");

            return transport;
        }
    }
}
