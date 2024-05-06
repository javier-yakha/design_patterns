using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Family.Quadro
{
    public class QuadroPropeller : Propeller
    {
        public QuadroPropeller()
        {
            TorqueSpeed = 0;
            HeightLimit = 200;
            Console.WriteLine("The QuadroPropeller has been created.");
        }
        public override void IncreaseTorqueSpeed()
        {
            TorqueSpeed += 20;
            Console.WriteLine("The Torque Speed has been increased by 20 RPM.");
        }
    }
}
