using System;
using System.Collections.Generic;
using System.Text;

namespace Fac2
{
    public class AirConditionerFactory
    {
        public AirConditioner AirConditioner { get; set; }
        public AirConditionerFactory(double degree)
        {
            if (degree < 22)
            {
                AirConditioner = new Cooling();
            }
            else
            {
                AirConditioner = new Heating();
            }
        }
    }
}
