namespace LeapYearKata
{
    public class LeapYear
    {
        public bool IsLeap(uint year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                return true;
            }

            return false;
        }
    }
}