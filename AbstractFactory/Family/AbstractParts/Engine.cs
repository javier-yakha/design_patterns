using System;

<<<<<<<< HEAD:AbstractFactory/Family/Engine.cs
namespace AbstractFactory.Family
========
namespace AbstractFactory.Family.AbstractParts
>>>>>>>> 4f51c02 (Changed project structure into separate folders for families):AbstractFactory/Family/AbstractParts/Engine.cs
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
