using System;

namespace Adapter
{
    public class ElectricEngineAdapter : IEngine
    {
        private ElectricEngine electricEngine;

        public ElectricEngineAdapter()
        {
            Console.WriteLine("Electric engine adapter");
            electricEngine = new ElectricEngine();
        }

        public void SpeedUp()
        {
            Console.WriteLine("Electric engine adapter speeding up");
            electricEngine.MoveFaster();
        }

        public void TurnOff()
        {
            Console.WriteLine("Electric engine adapter turned off");
            electricEngine.Stop();
            electricEngine.Disconnect();
        }

        public void TurnOn()
        {
            Console.WriteLine("Electric engine adapter turned on");
            electricEngine.Connect();
            electricEngine.Activate();
        }
    }
}
