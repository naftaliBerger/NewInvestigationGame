using System;

namespace NewInvestigationGame
{
    internal class PulseSensor : Sensor
    {
        public int activationCount = 0;
        

        public PulseSensor(string name) : base(name)
        {
        }

        public override bool Activate(Agent agent)
        {
            if (activationCount >= 3)
            {
                Console.WriteLine("The sensor is broken");
                return false;
            }

            activationCount++;
            //צריך בירור!!
            return agent.TrySensor(Name);
        }
    }
}
