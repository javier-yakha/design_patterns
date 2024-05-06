using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<<< HEAD:AbstractFactory/Family/Regulator.cs
namespace AbstractFactory.Family
========
namespace AbstractFactory.Family.AbstractParts
>>>>>>>> 4f51c02 (Changed project structure into separate folders for families):AbstractFactory/Family/AbstractParts/Regulator.cs
{
    public abstract class Regulator
    {
        public double CurrentVoltage { get; set; } // Voltage
        public double CurrentCurrent { get; set; } // Current

        public abstract void IncreaseVoltage();
        public override string ToString()
        {
            return $" - Voltage: {CurrentVoltage}V\n" +
                $" - Current: {CurrentCurrent}";
        }
    }
}
