using System;

namespace Adapter
{
    public class EconomicEngine : IEngine
    {
        public EconomicEngine()
        {
            Console.WriteLine("Economic engine");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Economic engine speeding up");
        }

        public void TurnOff()
        {
            Console.WriteLine("Economic engine turned off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Economic engine turned on");
        }
    }
}
