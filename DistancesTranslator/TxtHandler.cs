using System.IO;

namespace DistancesTranslator
{
    public class TxtHandler
    {
        public string InputPath { get; set; }
        public string OutputPath { get; set; }

        public string[] ReadTxt()
        {
            StreamReader File = new StreamReader(InputPath);
            char splitter = ' ';
            string content = File.ReadToEnd();
            string[] parts = content.Split(splitter);
            File.Close();
            return parts;
        }

        public void WriteTxt(double InputValue, string InputDistance, string OutputDistance, double OutputValue)
        {
            StreamWriter File = new StreamWriter(OutputPath);
            File.WriteLine(("{0} {1} {2} {3}"), InputValue, InputDistance, OutputDistance, OutputValue);
            File.Close();
        }
    }
}
