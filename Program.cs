using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInvestigationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IranianAgent iranianAgent = new IranianAgent();
            Sensor sensor = new Sensor();


            while (!iranianAgent.IsExposed())
            {
                
                string sensori = sensor.GetSensor();

                if (sensori == "Invalid number")
                {
                    Console.WriteLine("Invalid number");
                    continue;
                }

                bool hit = iranianAgent.TrySensor(sensori);

                if (hit)
                {
                    Console.WriteLine($"injury! ({iranianAgent.GetHits()}/2)");
                }
                else
                {
                    Console.WriteLine($"not injury ({iranianAgent.GetHits()}/2)");
                }
            }

            Console.WriteLine("The agent was exposed.");
        }
    }
    
}
