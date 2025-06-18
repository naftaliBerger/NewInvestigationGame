using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInvestigationGame
{
    internal class Sensor
    {

        public string Name;

        public Sensor(string name)
        {
            Name = name;
        }

        public virtual bool Activate(Agent agent)
        {
            return agent.TrySensor(Name);
        }


    }
}
