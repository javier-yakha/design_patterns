using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Family
{
    public abstract class Propeller
    {
        public double TorqueSpeed { get; set; }
        public double HeightLimit { get; set; }
        public abstract void IncreaseTorqueSpeed();
        public override string ToString()
        {
            return $" - Torque Speed: {TorqueSpeed} RPM\n" +
                $" - Height Limit: {HeightLimit}";
        }
    }
}
