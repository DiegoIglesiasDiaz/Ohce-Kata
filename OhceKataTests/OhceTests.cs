using Moq;
using Ohce_Kata;

namespace OhceKataTests
{
    [TestClass]
    public class OhceTests
    {
        
        //[TestMethod]

        //public void AnalyzeText_Welcome()
        //{
        //    var inputText = "ohce Diego";
        //    var expectedResult = "¡Buenas Tardes Diego!";
        //    var ohce = new Ohce();
        //    var mock = new Mock<Ohce>();
        //    mock.Setup(x => x.actualHour).Returns(17);
        //    ohce.actualHour = mock.Object.actualHour;
        
        //    Assert.AreEqual(ohce.AnalyzeText(inputText), mock.Object.AnalyzeText(inputText));


        //    inputText = "OHCE Diego";
        //    Assert.AreEqual(ohce.AnalyzeText(inputText), expectedResult);
         
        //}
        //[TestMethod]
        //public void AnalyzeText_Palindrome()
        //{
        //    var inputText = "stop";
        //    var expectedResult = "pots";
        //    var ohce = new Ohce();
        //    var mock = new Mock<Ohce>();
        //    mock.Setup(x => x.AnalyzeText(inputText)).Returns(expectedResult);
        //    Assert.AreEqual(ohce.AnalyzeText(inputText), mock.Object.AnalyzeText(inputText));

        //    inputText = "Stop";
        //    expectedResult = "potS";
        //    Assert.AreEqual(ohce.AnalyzeText(inputText), expectedResult);
        //}
        //[TestMethod]
        //public void AnalyzeText_Stop()
        //{
        //    var inputText = "Stop!";
        //    var name = "Diego";
        //    var expectedResult = $"Adios {name}";
        //    var ohce = new Ohce();
        //    var mock = new Mock<Ohce>();
        //    mock.Setup(x => x.name).Returns(name);
        //    mock.Setup(x => x.AnalyzeText(inputText)).Returns(expectedResult);
        //    ohce.name = name;
        //    Assert.AreEqual(ohce.AnalyzeText(inputText), mock.Object.AnalyzeText(inputText));
        //}

        //[TestMethod]
        //public void AnalyzeText_DoNotStop()
        //{
        //    var inputText = "stop!";
        //    var name = "Diego";
        //    var expectedResult = $"Adios {name}";
        //    var ohce = new Ohce();
        //    var mock = new Mock<Ohce>();
        //    mock.Setup(x => x.name).Returns(name);
        //    mock.Setup(x => x.AnalyzeText(inputText)).Returns(expectedResult);
        //    ohce.name = name;
        //    Assert.AreNotEqual(ohce.AnalyzeText(inputText), mock.Object.AnalyzeText(inputText));
        //}

        //[TestMethod]
        //public void WelcomePhraseTest_Morning()
        //{
        //    var inputText = "ohce Diego";
        //    var expectedResult = "¡Buenos Días Diego!";
        //    var ohce = new Ohce();
        //    var mock = new Mock<Ohce>();
        //    mock.Setup(x => x.actualHour).Returns(7);
        //    ohce.actualHour = mock.Object.actualHour;
        //    mock.Setup(x => x.GetWelcomePhrase(inputText)).Returns(expectedResult);
        //    var resultado = ohce.GetWelcomePhrase(inputText);

        //    Assert.AreEqual(expectedResult, resultado);
        //}



        //[TestMethod]

        //public void WelcomePhraseTest_Afternoon()
        //{
        //    var inputText = "ohce Diego";
        //    var expectedResult = "¡Buenas Tardes Diego!";
        //    var ohce = new Ohce();
        //    var mock = new Mock<Ohce>();
        //    mock.Setup(x => x.actualHour).Returns(13);
        //    ohce.actualHour = mock.Object.actualHour;
        //    mock.Setup(x => x.GetWelcomePhrase(inputText)).Returns(expectedResult);
        //    var resultado = ohce.GetWelcomePhrase(inputText);

        //    Assert.AreEqual(expectedResult, resultado);
        //}
        //[TestMethod]
        //public void WelcomePhraseTest_Night()
        //{
        //    var inputText = "ohce Diego";
        //    var expectedResult = "¡Buenas Noches Diego!";
        //    var ohce = new Ohce();
        //    var mock = new Mock<Ohce>();
        //    mock.Setup(x => x.actualHour).Returns(21);
        //    ohce.actualHour = mock.Object.actualHour;
        //    mock.Setup(x => x.GetWelcomePhrase(inputText)).Returns(expectedResult);
        //    var resultado = ohce.GetWelcomePhrase(inputText);

        //    Assert.AreEqual(expectedResult, resultado);
        //}
        //[TestMethod]
        //public void PrintBonitaPalabra()
        //{
        //    var mock = new Mock<Ohce>();
        //    var ohce = new Ohce();
        //    string textToChange = "Oso";
        //    string expectedResult = "¡Bonita palabra!";
        //    mock.Setup(x => x.PalindromeText(textToChange)).Returns(expectedResult);
        //    Assert.AreEqual(ohce.PalindromeText(textToChange), mock.Object.PalindromeText(textToChange));

        //}
        //[TestMethod]
        //public void PalindromeTest_ReverseWord()
        //{
        //    var mock = new Mock<Ohce>();
        //    var ohce = new Ohce();
        //    string textToChange = "Change";
        //    string expectedResult = "egnahC";
        //    mock.Setup(x => x.PalindromeText(textToChange)).Returns(expectedResult);
        //    Assert.AreEqual(ohce.PalindromeText(textToChange), mock.Object.PalindromeText(textToChange));
        //}
        //[TestMethod]
        //public void AnalyzeText_ArgumentNullExcpetion()
        //{

        //    var ohce = new Ohce();
        //    Assert.ThrowsException<ArgumentNullException>(() => ohce.AnalyzeText(""));
        //}

    }
}