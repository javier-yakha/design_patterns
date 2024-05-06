using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Family.AbstractParts;
using AbstractFactory.Quadro;

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
    }
}
