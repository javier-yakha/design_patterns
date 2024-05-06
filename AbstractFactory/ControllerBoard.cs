using System;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Family;

namespace AbstractFactory
{
    public class ControllerBoard
    {
        // Properties
        public Regulator MyRegulator { get; set; }
        public Engine MyEngine { get; set; }
        public Propeller MyPropeller { get; set; }
        public QuadrocopterFactory UsedFactory { get; set; }

        // Constructor
        public ControllerBoard(QuadrocopterFactory usedFactory)
        {
            UsedFactory = usedFactory;
            CreateParts();
        }

        // Method to create parts
        public void CreateParts()
        {
            MyRegulator = UsedFactory.CreateRegulator();
            MyEngine = UsedFactory.CreateEngine();
            MyPropeller = UsedFactory.CreatePropeller();
        }
        public override string ToString()
        {
            return $"Controller Status:\n" +
                $"{MyRegulator}\n" +
                $"{MyEngine}\n" +
                $"{MyPropeller}";
        }
    }
}
