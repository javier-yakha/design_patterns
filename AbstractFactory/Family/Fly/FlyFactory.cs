using System.Text;
using AbstractFactory.Family.AbstractParts;
using AbstractFactory.Fly;

namespace AbstractFactory.Family.Fly
{
    public class FlyFactory : QuadrocopterFactory
    {
        public override Engine CreateEngine()
        {
            return new FlyEngine();
        }

        public override Regulator CreateRegulator()
        {
            return new FlyRegulator();
        }
    }
}
