using System;

namespace Fac2
{
    class Program
    {
        static void Main(string[] args)
        {
            AirConditionerFactory airConditionerFactory = new AirConditionerFactory(20);
            airConditionerFactory.AirConditioner.Run();
            Console.ReadLine();
        }
    }
}
