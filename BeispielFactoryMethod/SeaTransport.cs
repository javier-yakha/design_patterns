﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielFactoryMethod
{
    public class SeaTransport : Transport
    {
        public override void TransportProducts()
        {
            Console.WriteLine($"Goods have been\n" +
                $" - Collected from: {Customer}\n" +
                $" - Transported to: {Destination}\n" +
                $" - by the Sea route");
        }
    }
}
