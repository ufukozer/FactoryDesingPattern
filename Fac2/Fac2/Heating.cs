using System;
using System.Collections.Generic;
using System.Text;

namespace Fac2
{
    public class Heating : AirConditioner
    {
        public override void Run()
        {
            Console.WriteLine("Heating!");
        }
    }
}
