namespace LeapYearKata
{
    public class LeapYear
    {
        public bool IsLeap(uint year)
        {
            if (year % 4 == 0) 
            {
                return true;
            }

            return false;
        }
    }
}