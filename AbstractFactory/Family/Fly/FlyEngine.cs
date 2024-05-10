using System;

namespace AbstractFactory.Family.Fly
{
    public class FlyEngine : Engine
    {
        public FlyEngine()
        {
            EngineSpeed = 300;
            Console.WriteLine("The FlyEngine has been created.");
        }

        public override void RevCounter()
        {
            Console.WriteLine("The RPM is 300 revolutions per minute.");
        }
    }
}
