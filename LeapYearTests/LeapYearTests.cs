using LeapYearKata;

namespace LeapYearTests
{
    public class LeapYearTests
    {
        LeapYear _leapYear; 

        [SetUp]
        public void Setup()
        {
            _leapYear = new LeapYear();
        }

        [Test]
        public void IsLeapYear()
        {
            Assert.Pass();
        }

        [Test]
        public void IsNotLeapYear()
        {
            Assert.Pass();
        }
    }
}