using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Family.Quadro
{
    public class QuadroFactory : QuadrocopterFactory
    {
        public override Engine CreateEngine()
        {
            return new QuadroEngine();
        }
        public override Regulator CreateRegulator()
        {
            return new QuadroRegulator();
        }
        public override Propeller CreatePropeller()
        {
            return new QuadroPropeller();
        }
    }
}
