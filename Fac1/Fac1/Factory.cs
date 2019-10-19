using System;
using System.Collections.Generic;
using System.Text;

namespace Fac1
{
    public class Factory
    {
        public Hardware Hardware { get; set; }

        public Factory(HardwareType hardwareType)
        {
            switch (hardwareType)
            {
                case HardwareType.Keyboard:
                    Hardware = new Keyboard();
                    break;
                case HardwareType.Mouse:
                    Hardware = new Mouse();
                    break;
            }
        }
    }
}
