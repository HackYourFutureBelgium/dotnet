var time = new JupiterTime(1, 21);
var timeIn20Minutes = time.AddMinutes(20);

PrintTime(timeIn20Minutes);

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"{time.Hours}:{time.Minutes:D2}");
}

class JupiterTime
{
    private const int HoursPerDay = 10;
    private const int MinutesPerHour = 60;

    public JupiterTime(int hours, int minutes)
    {
        var totalMinutes = hours * MinutesPerHour + minutes;

        if (totalMinutes < 0)
        {
            // Add one, because we want to round up
            // Integer division in C# rounds down
            var minutesBelowZero = 0 - totalMinutes;
            var totalDaysBelowZero = 1 + minutesBelowZero / (HoursPerDay * MinutesPerHour);

            // Add that many days, so we have a positive number
            totalMinutes += totalDaysBelowZero * HoursPerDay * MinutesPerHour;
        }

        Minutes = totalMinutes % MinutesPerHour;

        var totalHours = (totalMinutes - Minutes) / MinutesPerHour;
        
        Hours = totalHours % HoursPerDay;
    }

    public JupiterTime AddHours(int hours)
    {
        return new JupiterTime(Hours + hours, Minutes);
    }

    public JupiterTime AddMinutes(int minutes)
    {
        return new JupiterTime(Hours, Minutes + minutes);
    }

    public int Hours { get; }

    public int Minutes { get; }
}