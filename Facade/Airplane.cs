using System;
namespace Facade
{
	public class Airplane
	{
        public void PutLuggageIn()
        {
            Console.WriteLine("The luggage was loaded onto the airplane.");
        }

        public void PutLuggageOut()
        {
            Console.WriteLine("The luggage was unloaded from the airplane.");
        }
        public void BoardIn() 
        {
            Console.WriteLine("The passenger entered the plane.");
        }
        public void BoardOut() 
        {
            Console.WriteLine("The passenger exited the plane.");
        }
    }
}

