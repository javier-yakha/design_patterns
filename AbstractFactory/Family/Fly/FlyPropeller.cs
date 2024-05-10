using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Family.Fly
{
    public class FlyPropeller : Propeller
    {
        public FlyPropeller()
        {
            TorqueSpeed = 0;
            HeightLimit = 50;
            Console.WriteLine("The FlyPropeller has been created.");
        }
        public override void IncreaseTorqueSpeed()
        {
            TorqueSpeed += 100;
            Console.WriteLine("The Torque Speed has been increased by 100 RPM.");
        }
    }
}
