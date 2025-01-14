using System;
using KTPO4310.Shakirzanov.Lib.src.LogAn;
using NUnit.Framework;

namespace KTPO4310.Shakirzanov.UnitTest.src.LogAn
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_BadExtennsion_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");
            Assert.True(result);
        }
        [Test]
        public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue()
        {
            // Подготовка ткста
            LogAnalyzer analyzer = new LogAnalyzer();

            // Воздействие на тестерируемый объект
            bool result = analyzer.IsValidLogFileName("filewithbadextension.LOG");

            Assert.IsFalse(result);
        }
        
        [Test]
        public void IsValidLogFileName_GoodExtensionLowercase_ReturnsTrue()
        {
            // Подготовка ткста
            LogAnalyzer analyzer = new LogAnalyzer();

            // Воздействие на тестерируемый объект
            bool result = analyzer.IsValidLogFileName("filewithbadextension.log");

            Assert.IsFalse(result);
        }

        [TestCase("filewithgoodextension.LOG")]
        [TestCase("filewithgoodextension.log")]
        public void IsVaLidLogFileName_ValidExtension_ReturnsTrue(string file)
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("file");
           
            Assert.True(result);
            
        }
        [Test]
        public void IsValidLogFileName_EmptyFileName_Throws()
        {
            // Подготовка текста
            LogAnalyzer analyzer = new LogAnalyzer();

            // Воздействие на тестируемый объект
            var ex = Assert.Catch<Exception>(() => analyzer.IsValidLogFileName(""));



            StringAssert.Contains("имя файла должно быть задано", ex.Message);
        }
        [TestCase("goodfile.log",false)]
        [TestCase("badfile.foo",true)]
        
        public void IsValidFileName_WhenCalled_ChangesWasLastFileNameValid(string file, bool expected)
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            analyzer.IsValidLogFileName(file);
            Assert.AreEqual(expected, analyzer.WasLastFileNameValid);
        }
    }

}

