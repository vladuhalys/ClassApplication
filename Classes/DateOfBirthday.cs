namespace ClassApplication.Classes
{
    public class DateOfBirthday
    {
        private int _day;
        private int _month;
        private int _year;

        public int Day
        {
            get => _day;
            set
            {
                if (value < 1 || value > 31)
                    throw new ArgumentOutOfRangeException(nameof(Day), "Day must be between 1 and 31.");
                _day = value;
            }
        }

        public int Month
        {
            get => _month;
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentOutOfRangeException(nameof(Month), "Month must be between 1 and 12.");
                _month = value;
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(nameof(Year), "Year must be a positive number.");
                _year = value;
            }
        }

        public DateOfBirthday()
        {
            DateTime localTime = DateTime.UtcNow.ToLocalTime();
            Day = localTime.Day;
            Month = localTime.Month;
            Year = localTime.Year;
        }

        public DateOfBirthday(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:D2}.{Month:D2}.{Year}";
        }

        /// <summary>
        /// Validates if the current date is a valid calendar date.
        /// </summary>
        /// <returns>True if the date is valid, otherwise false.</returns>
        public bool IsValidDate()
        {
            return DateTime.TryParse($"{Year}-{Month:D2}-{Day:D2}", out _);
        }
    }
}