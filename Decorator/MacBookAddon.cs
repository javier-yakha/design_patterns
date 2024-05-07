using System;
namespace Decorator
{
    public abstract class MacBookAddon : IMacBook
    {
        protected IMacBook macBook;

        public MacBookAddon(IMacBook macBook)
        {
            this.macBook = macBook;
        }

        public abstract string GetDescription();
        public abstract double GetPrice();
        public abstract void IncreaseVolume();
    }
}

