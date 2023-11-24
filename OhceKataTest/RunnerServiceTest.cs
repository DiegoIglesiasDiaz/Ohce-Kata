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
        private RunnerService _runnerService;
        private Mock<IOhceKataService> _mockOhceKata;
        [SetUp]
        public void Setup()
        {
            _mockOhceKata = new Mock<IOhceKataService>();
            _runnerService = new RunnerService(_mockOhceKata.Object);
        }

        [Test]
        [TestCase("Diego")]
        [TestCase("Vlad")]
        public void GetNameFromConsoleTest(string name)
        {
            
            Console.SetIn(new StringReader(name));

            var result = _runnerService.GetNameFromConsole();

            Assert.That(result, Is.EqualTo(name));
        }
        [Test]
        [TestCase("Pac0")]
        [TestCase("Fabio$")]
        public void GetNameFromConsoleTest_ArgumentException(string name)
        {
            Console.SetIn(new StringReader(name));
            Assert.Catch<ArgumentException>(() => _runnerService.GetNameFromConsole());
        }


        [Test]
        [TestCase("Noon")]
        [TestCase("oso")]
        public void When_word_is_palindrom_Then_returns_true(string word)
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
          
            _mockOhceKata.Setup(x=>x.isPalindrome(word)).Returns(true);
            _runnerService.AnalyzeWord(word);
            Assert.True(stringWriter.ToString().Contains(StringHelper.ReverseWord(word)));
            Assert.True(stringWriter.ToString().Contains("¡Bonita Palabra!"));
        }

        [Test]
        [TestCase("stop")]
        [TestCase("Mouse")]
        public void When_word_is_not_a_palindrom_Then_returns_false(string word)
        {
          
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            _mockOhceKata.Setup(x => x.isPalindrome(word)).Returns(false);
            _runnerService.AnalyzeWord(word);
           

            Assert.True(stringWriter.ToString().Contains(StringHelper.ReverseWord(word)));
            Assert.False(stringWriter.ToString().Contains("¡Bonita Palabra!"));
        }


        [Test]
        public void Run()
        {

            var _runnerService = new Mock<IRunnerService>();

        }
    }
}
