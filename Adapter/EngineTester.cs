using System;

namespace Adapter
{
    public class EngineTester
    {
        public EngineTester(IEngine engine)
        {
            engine.TurnOn();
            engine.SpeedUp();
            engine.TurnOff();
        }
    }
}
