using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MacBookM4Processor : MacBookAddon
    {
        private IMacBook macBook;

        public MacBookM4Processor(IMacBook macBook) : base(macBook)
        {
            this.macBook = macBook;
        }

        public override string GetDescription()
        {
            return macBook.GetDescription() + " Additionally, an M4 processor was installed!!!\n";
        }

        public override double GetPrice()
        {
            return macBook.GetPrice() + 2000.00;
        }

        public override void IncreaseVolume()
        {
            macBook.IncreaseVolume();
        }
    }
}
