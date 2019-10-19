using System;

namespace Fac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(HardwareType.Keyboard);
            factory.Hardware.Equipment();

            Factory keyboardFactory = new Factory(HardwareType.Keyboard);
            keyboardFactory.Hardware.Equipment();

            Console.ReadLine();
        }
    }
}
