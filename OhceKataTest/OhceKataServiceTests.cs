using Moq;
using Ohce_Kata.Services;
using Ohce_Kata.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OhceKataTest
{
    public  class OhceKataServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(5,"Diego", $"¡Buenas noches Diego!")]
        [TestCase(6, "Diego", $"¡Buenos dias Diego!")]
        [TestCase(7, "Diego", $"¡Buenos dias Diego!")]
        [TestCase(11, "Vlad", $"¡Buenos dias Vlad!")]
        [TestCase(12, "Vlad", $"¡Buenas tardes Vlad!")]
        [TestCase(13, "Vlad", $"¡Buenas tardes Vlad!")]
        [TestCase(19, "Fabio", $"¡Buenas tardes Fabio!")]
        [TestCase(20, "Fabio", $"¡Buenas noches Fabio!")]
        [TestCase(21, "Fabio", $"¡Buenas noches Fabio!")]
        public void GetGreetsTest(int hour, string name, string expectedResult)
        {
            var dateServie = new Mock<IDateService>();
            dateServie.Setup(x=> x.GetHour()).Returns(hour);
            var ohceKata = new OhceKataService(dateServie.Object);

            Assert.That(expectedResult, Is.EqualTo(ohceKata.GetGreets(name)));


        }
        [Test]
        [TestCase("Noon",true)]
        [TestCase("Moon",false)]
        [TestCase("a",true)]
        public void isPalindromeText(string word, bool value)
        {
            var _ohceKataService = new OhceKataService();
            Assert.That(_ohceKataService.isPalindrome(word), Is.EqualTo(value));
        }
    }
}
