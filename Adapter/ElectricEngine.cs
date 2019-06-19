using System;

namespace Adapter
{
    public class ElectricEngine
    {
        public ElectricEngine()
        {
            Console.WriteLine("\tElectric engine");
        }

        public void Connect()
        {
            Console.WriteLine("\tElectric engine connected");
        }

        public void Activate()
        {
            Console.WriteLine("\tElectric engine activated");
        }

        public void MoveFaster()
        {
            Console.WriteLine("\tElectric engine faster!");
        }

        public void Stop()
        {
            Console.WriteLine("\tElectric engine stopped");
        }

        public void Disconnect()
        {
            Console.WriteLine("\tElectric engine disconnected");
        }
    }
}
