//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace NewInvestigationGame
//{
//    internal class IranianAgent
//    {
//        public List<string> weaknesses;
//        private int AmountDamage;

//        public IranianAgent()
//        {
//            weaknesses = new List<string> { "Base", "thermal" };
//            AmountDamage = 0;
//        }

//        public bool TrySensor(string sensor)
//        {
//            bool hit = false;

//            for (int i = 0; i < weaknesses.Count; i++)
//            {
//                if (sensor == weaknesses[i])
//                {
//                    AmountDamage += 1;

//                    weaknesses[i] = "used";
//                    hit = true;
//                    break;
//                }
//            }

//            return hit;
//        }

//        public bool IsExposed()
//        {
//            return AmountDamage == 2;
//        }

//        public int GetHits()
//        {
//            return AmountDamage;
//        }
//    }
//}
