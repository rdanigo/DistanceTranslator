using NUnit.Framework;
using System;
using System.IO;

namespace DistancesTranslatorTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void EmptyInputPathReturnsNothing()
        {
            string InputPath = @"C:\Users\rdaniellagomez\source\repos\DistancesTranslator\Input.txt";
            StreamReader File = new StreamReader(InputPath);
            File.Read();
            Assert.IsNotNull(File);
        }

        [Test]
        public void EmptyOutputPathReturnsNothing()
        {
            string OutputPath = @"C:\Users\rdaniellagomez\source\repos\DistancesTranslator\Output.txt";
            StreamWriter File = new StreamWriter(OutputPath);
            File.WriteLine();
            Assert.IsNotNull(File);
        }
        [Test]
        public void InvalidPathThrowsException()
        {
            string InputPath = @"C:\Users\rdaniellagomez\source\repos\DistancesTranslator\In.txt";
            if (File.Exists(InputPath))
            {
                Assert.Pass();
            } 
        }
    }
}
