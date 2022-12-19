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
            uint year = 1996;
            Assert.That(_leapYear.IsLeap(year), Is.True);
        }

        [Test]
        public void IsNotLeapYear()
        {
            uint year = 2001;
            Assert.That(_leapYear.IsLeap(year), Is.False);
        }
    }
}