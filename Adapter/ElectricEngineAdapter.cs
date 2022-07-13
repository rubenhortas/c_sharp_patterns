using System;

namespace Adapter
{
    public class ElectricEngineAdapter : IEngine
    {
        private ElectricEngine _electricEngine;

        public ElectricEngineAdapter()
        {
            Console.WriteLine("Electric engine adapter");

            _electricEngine = new ElectricEngine();
        }

        public void SpeedUp()
        {
            Console.WriteLine("Electric engine adapter speeding up");

            _electricEngine.MoveFaster();
        }

        public void TurnOff()
        {
            Console.WriteLine("Electric engine adapter turned off");

            _electricEngine.Stop();
            _electricEngine.Disconnect();
        }

        public void TurnOn()
        {
            Console.WriteLine("Electric engine adapter turned on");

            _electricEngine.Connect();
            _electricEngine.Activate();
        }
    }
}
