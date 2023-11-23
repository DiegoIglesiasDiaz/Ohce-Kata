using Ohce_Kata.Services;

namespace OhceKataTest
{
    public class DateServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("2023-11-22 14:30:00")]
        [TestCase("2023-09-20 14:30:00")]
        [TestCase("2021-01-01 14:30:00")]
        public void GetDateTimeTest(string stringDate)
        {
            var dt = DateTime.Parse(stringDate);
            var dateService = new DateService(dt);
            Assert.That(dateService.GetDateTime(), Is.EqualTo(dt));
            
        }

        [Test]
        [TestCase("2023-11-22 14:30:00")]
        [TestCase("2023-09-20 14:30:00")]
        [TestCase("2021-01-01 14:30:00")]
        public void SetDateTimeTest(string stringDate)
        {
        
            var dateService = new DateService();
            var dt = DateTime.Parse(stringDate);
            dateService.SetDateTime(dt);
            Assert.That(dateService.GetDateTime(), Is.EqualTo(dt));
        }

        [Test]
        [TestCase("2023-11-22 23:59:59",23)]
        [TestCase("2023-09-20 01:00:00",1)]
        [TestCase("2021-01-01 00:00:00",0)]
        public void GetHourTest(string stringDate, int hour)
        {

            var dt = DateTime.Parse(stringDate);
            var dateService = new DateService(dt);
            Assert.That(dateService.GetHour(), Is.EqualTo(hour));
        }
    }

}
