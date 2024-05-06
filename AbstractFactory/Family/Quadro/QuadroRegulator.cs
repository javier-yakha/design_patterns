using System;
using AbstractFactory.Family.AbstractParts;

namespace AbstractFactory.Family.Quadro
{
    public class QuadroRegulator : Regulator
    {
        public QuadroRegulator()
        {
            Console.WriteLine("The QuadroRegulator has been created.");
        }

        public override void IncreaseVoltage()
        {
            Console.WriteLine("The voltage has been increased by 30V.");
        }
    }
}
