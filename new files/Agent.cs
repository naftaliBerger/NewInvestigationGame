using System;
using System.Collections.Generic;

namespace NewInvestigationGame
{
    public abstract class Agent
    {
        public List<string> weaknesses; 
        public int amountDamage;
        public Random rnd = new Random();

        public Agent(int weaknessCount)
        {
            weaknesses = new List<string>();
            amountDamage = 0;
            List<string> listOfSensors = new List<string> { "Base", "Thermal", "Motion", "Video", "Audio", "Heat", "Pulse" };


            for (int i = 0; i < weaknessCount; i++)
            {
                int index = rnd.Next(listOfSensors.Count);
                weaknesses.Add(listOfSensors[index]);
            }
        }

        public bool TrySensor(string sensor)
        {
            for (int i = 0; i < weaknesses.Count; i++)
            {
                if (weaknesses[i] == sensor)
                {
                    weaknesses.RemoveAt(i);
                    amountDamage++;
                    return true; 
                }
            }
            return false; 
        }

        public string GetStatus()
        {
            return $"{amountDamage}/{amountDamage + weaknesses.Count}";
        }

        public bool IsExposed()
        {
            return weaknesses.Count == 0;
        }

       
    }
}