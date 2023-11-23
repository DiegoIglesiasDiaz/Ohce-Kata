using Ohce_Kata.Services;
using Ohce_Kata.Services.Helpers;

namespace OhceKataTest
{
    public class StringHelperTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Diego",false)]
        [TestCase("Diego1",true)]
        [TestCase("Jean-Sacha",false)]
        [TestCase("Vlad$",true)]

        public void isInvalidNameTest(string name, bool value)
        {
            Assert.That(StringHelper.isInvalidName(name), Is.EqualTo(value));    
        }
        [Test]
        [TestCase("Noon", "nooN")]
        [TestCase("Paco", "ocaP")]
        [TestCase("Fabio", "oibaF")]
        [TestCase("Jean-Sacha", "ahcaS-naeJ")]
        public void reverseWord(string word, string expectedResult)
        {
            Assert.That(expectedResult, Is.EqualTo(StringHelper.ReverseWord(word)));
        }

   
    }

}
