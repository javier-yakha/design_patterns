using System;
using AbstractFactory.Family.AbstractParts;

namespace AbstractFactory.Family.Fly
{
    public class FlyRegulator : Regulator
    {
        public FlyRegulator()
        {
            CurrentVoltage = 10;
            CurrentCurrent = 0;
            Console.WriteLine("The FlyRegulator has been created.");
        }

        public override void IncreaseVoltage()
        {
            CurrentVoltage += 10;
            Console.WriteLine("The voltage has been increased by 10V.");
        }
    }
}
