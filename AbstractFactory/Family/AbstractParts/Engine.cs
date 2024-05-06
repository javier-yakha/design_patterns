using System;

namespace AbstractFactory.Family.AbstractParts
{
    public abstract class Engine
    {
        public double EngineSpeed { get; set; } // RPM

        public abstract void RevCounter();
    }
}
