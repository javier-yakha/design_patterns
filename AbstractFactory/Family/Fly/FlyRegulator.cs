﻿using System;
using AbstractFactory.Family.AbstractParts;

namespace AbstractFactory.Family.Fly
{
    public class FlyRegulator : Regulator
    {
        public FlyRegulator()
        {
            Console.WriteLine("The FlyRegulator has been created.");
        }

        public override void IncreaseVoltage()
        {
            Console.WriteLine("The voltage has been increased by 10V.");
        }
    }
}
