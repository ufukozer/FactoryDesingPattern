using System;
using System.Collections.Generic;
using System.Text;

namespace Fac1
{
    //public abstract class Hardware
    public interface Hardware
    {
        //public abstract void Equipment();
        void Equipment();
    }
    public class Keyboard : Hardware
    {
        public void Equipment()
        {
            Console.WriteLine("Keyboard");
        }
    }
    public class Mouse : Hardware
    {
        public void Equipment()
        {
            Console.WriteLine("Mouse");
        }
    }
    public enum HardwareType
    {
        Keyboard,
        Mouse
    }
}
