namespace ClassApplication.Classes;

public class DateOfBirthday
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public DateOfBirthday()
    {
        /*// Local time of the computer
        DateTime now = DateTime.Now;
        Day = now.Day;
        Month = now.Month;
        Year = now.Year;*/
        
        //UTC time to Local time
        DateTime utcNow = DateTime.UtcNow;
        DateTime localTime = utcNow.ToLocalTime();
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
        return $"{Day}.{Month}.{Year}";
    }
}