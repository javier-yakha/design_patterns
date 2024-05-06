using System;

namespace AbstractFactory.Family
{
    public abstract class Engine
    {
        public double EngineSpeed { get; set; } // RPM

        public abstract void RevCounter();
        public override string ToString()
        {
            return $" - Engine Speed: {EngineSpeed}";
        }
    }
}
