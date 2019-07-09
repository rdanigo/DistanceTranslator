using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistancesTranslator
{
    public class Program
    {
        public string OriginDistance;
        public string DestinyDistance;
        public string[] parts;
        public string InputPath = @"C:\Users\rdaniellagomez\source\repos\DistancesTranslator\Input.txt";
        public string OutputPath = @"C:\Users\rdaniellagomez\source\repos\DistancesTranslator\Output.txt";
        public double Destiny;
        public Dictionary<string, int> DistanceTypes = new Dictionary<string, int>
        {
            { "MM", 1 },
            { "CM", 2 },
            { "dM", 3 },
            { "M",  4 },
            { "DM", 5 },
            { "HM", 6 },
            { "KM", 7 },
        };

        public void Formater()
        {
            TxtHandler txtHandler = new TxtHandler();
            txtHandler.OutputPath = OutputPath;
            txtHandler.InputPath = InputPath;

            parts = txtHandler.ReadTxt();

            Converter(DistanceTypes[parts[1]], DistanceTypes[parts[2]], Convert.ToDouble(parts[0]), parts[1], parts[2]);

            txtHandler.WriteTxt(Convert.ToDouble(parts[0]), parts[1], parts[2], Destiny);
        }

        public void Converter(int Distance, int Distance2, double origin, string OriginDistance, string DestinyDistance)
        {
            DistanceConverter converter = new DistanceConverter();
            Destiny = converter.Convert(Distance, Distance2, origin, OriginDistance, DestinyDistance);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Formater();
            Console.ReadKey();
        }
    }
}
