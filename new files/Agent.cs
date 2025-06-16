using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NewInvestigationGame;

namespace NewInvestigationGame
{
    public abstract class Agent
    {
        public List<string> weaknesses;
        public int amountDamage;
        public List<string> listOfSensores = new List<string> { "Base", "Thermal","Motion", "video", "audio", "heat" };
        public Random rnd = new Random();

        public Agent(int weaknessCount)
        {
            weaknesses = new List<string>();
            amountDamage = 0;

            for (int i = 0; i < weaknessCount - 1; i++)
            {
                int index = rnd.Next(listOfSensores.Count);
                weaknesses.Add(listOfSensores[index]);
            }
        }

        public bool TrySensor(string sensor)
        {
            bool hit = false;
            for (int i = 0; i < weaknesses.Count; i++)
            {
                if (sensor == weaknesses[i])
                {
                    amountDamage++;
                    weaknesses[i] = "used";
                    hit = true;
                    break;
                }
            }
            return hit;
        }

        

    }
}
