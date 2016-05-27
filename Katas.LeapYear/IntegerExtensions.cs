namespace Katas.LeapYear
{
    public static class IntegerExtensions
    {
        public static bool IsLeapYear(this int year)
        {
            return IsTypicalLeapYear(year) && !IsSpecialCommonYear(year);
        }

        private static bool IsTypicalLeapYear(int year)
        {
            return year%4 == 0;
        }

        private static bool IsSpecialCommonYear(int year)
        {
            return (year % 100 == 0) && (year % 400 != 0);
        }
    }
}