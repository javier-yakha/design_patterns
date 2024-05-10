using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class RealStateInvestment : IInvestmentStrategy
    {
        public void Invest(double investMoney)
        {
            Console.WriteLine($"You have invested {investMoney} euros in real state.");
        }
    }
}
