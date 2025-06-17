using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInvestigationGame
{
    internal class Manager
    {
        private Agent agent;
        private int turnCounter;

        public Manager()
        {
            agent = new JuniorAgent();
            //turnCounter = 0;
        }

        public void StartInvestigation()
        {
            Console.WriteLine("Investigation has begun!");
            while (!agent.IsExposed())
            {
                Console.WriteLine("Select a sensor (Base / Thermal / Motion / Video / Audio / Heat):");
                string input = Console.ReadLine();
                Sensor sensor = new Sensor(input);
                bool hit = sensor.Activate(agent);
                turnCounter++;
                
                Console.WriteLine("Current status: " + agent.GetStatus());
            }
            Console.WriteLine($"The agent was successfully exposed after {turnCounter} Teachings!");
        }
    }
}
