using System;

namespace Adapter
{
    public class CommonEngine : IEngine
    {
        public CommonEngine()
        {
            Console.WriteLine("Common engine");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Common engine turned on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Common engine turned off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Common engine speeding up");
        }
    }
}
