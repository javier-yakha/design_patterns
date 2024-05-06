using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<<< HEAD:AbstractFactory/Family/QuadrocopterFactory.cs
namespace AbstractFactory.Family
========
namespace AbstractFactory.Family.AbstractParts
>>>>>>>> 4f51c02 (Changed project structure into separate folders for families):AbstractFactory/Family/AbstractParts/QuadrocopterFactory.cs
{
    public abstract class QuadrocopterFactory
    {
        // Abstract methods to be implemented by concrete factories
        public abstract Engine CreateEngine();
        public abstract Regulator CreateRegulator();
        public abstract Propeller CreatePropeller();
    }
}
