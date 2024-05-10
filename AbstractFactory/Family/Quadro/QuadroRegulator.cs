using System;

namespace AbstractFactory.Family.Quadro
{
    public class QuadroRegulator : Regulator
    {
        public QuadroRegulator()
        {
            CurrentVoltage = 10;
            CurrentCurrent = 0;
            Console.WriteLine("The QuadroRegulator has been created.");
        }

        public override void IncreaseVoltage()
        {
            CurrentVoltage += 30;
            Console.WriteLine("The voltage has been increased by 30V.");
        }
    }
}
