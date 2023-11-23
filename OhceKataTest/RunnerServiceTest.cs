using Moq;
using Ohce_Kata.Services;
using Ohce_Kata.Services.Helpers;
using Ohce_Kata.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OhceKataTest
{
    public class RunnerServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Diego")]
        [TestCase("Vlad")]
        public void GetNameFromConsoleTest(string name)
        {
            var _runnerService = new RunnerService();
            Console.SetIn(new StringReader(name));

            var result = _runnerService.GetNameFromConsole();

            Assert.That(result, Is.EqualTo(name));
        }
        [Test]
        [TestCase("Pac0")]
        [TestCase("Fabio$")]
        public void GetNameFromConsoleTest_ArgumentException(string name)
        {
            var _runnerService = new RunnerService();
            Console.SetIn(new StringReader(name));
            Assert.Catch<ArgumentException>(() =>_runnerService.GetNameFromConsole());
        }


        [Test]
        [TestCase("Noon")]
        [TestCase("oso")]
        public void AnalyzeWordPalindrome(string word)
        {
            var _runnerService = new RunnerService();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            _runnerService.AnalyzeWord(word);

            Assert.True(stringWriter.ToString().Contains(StringHelper.ReverseWord(word)));
            Assert.True(stringWriter.ToString().Contains("!Bonita Palabra¡"));
        }

        [Test]
        [TestCase("stop")]
        [TestCase("Mouse")]
        public void AnalyzeWordNotPalindrome(string word)
        {
            var _runnerService = new RunnerService();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            _runnerService.AnalyzeWord(word);

            Assert.True(stringWriter.ToString().Contains(StringHelper.ReverseWord(word)));
            Assert.False(stringWriter.ToString().Contains("!Bonita Palabra¡"));
        }


        [Test]
        public void Run()
        {

            var _runnerService = new Mock<IRunnerService>();
         
        }
    }
}
