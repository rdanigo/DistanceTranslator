using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistancesTranslator
{
    public class DistanceConverter
    {
        private int Multiplier;
        private int Counter;
        private double Destiny;


        public double Convert(int Distance, int Distance2, double Origin, string OriginDistance, string DestinyDistance)
        {
            Multiplier = Distance - Distance2;
            Counter = Multiplier;
            if (Multiplier < 0)
            {
                Destiny = Origin / 10;
                Counter += 1;
                while (Counter < 0)
                {
                    Destiny /= 10;
                    Counter += 1;
                }
            }
            else if (Multiplier > 0)
            {
                Destiny = Origin * 10;
                Counter -= 1;
                while (Counter > 0)
                {
                    Destiny *= 10;
                    Counter -= 1;
                }
            }
            else
            {
                Destiny = Origin;
            }
            return Destiny;
        }
    }
}
