var signaler = new Signaler();
signaler.AddTime(new JupiterTime(1, 20));
signaler.AddTime(new JupiterTime(2, 20));
signaler.AddTime(new JupiterTime(3, 20));

signaler.Inform();

class JupiterTime
{
    private const int HoursPerDay = 10;
    private const int MinutesPerHour = 60;

    public JupiterTime(int hours, int minutes)
    {
        var totalMinutes = hours * MinutesPerHour + minutes;

        totalMinutes = MakeSureTimeIsPositive(totalMinutes);

        Minutes = totalMinutes % MinutesPerHour;

        var totalHours = (totalMinutes - Minutes) / MinutesPerHour;
        
        Hours = totalHours % HoursPerDay;
    }

    private static int MakeSureTimeIsPositive(int totalMinutes)
    {
        if (totalMinutes < 0)
        {
            // Add one, because we want to round up
            // Integer division in C# rounds down
            var minutesBelowZero = 0 - totalMinutes;
            var totalDaysBelowZero = 1 + minutesBelowZero / (HoursPerDay * MinutesPerHour);

            // Add that many days, so we have a positive number
            totalMinutes += totalDaysBelowZero * HoursPerDay * MinutesPerHour;
        }

        return totalMinutes;
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

    public override string ToString()
    {
        return $"{Hours}:{Minutes:D2}";
    }
}

class Signaler
{
    private readonly List<JupiterTime> _signalTimes = new();

    public void AddTime(JupiterTime time)
    {
        _signalTimes.Add(time);
    }

    public void Inform()
    {
        if (_signalTimes.Count == 0)
        {
            Console.WriteLine("No timers added yet.");
            return;
        }

        foreach (var jupiterTime in _signalTimes)
        {
            Console.WriteLine(jupiterTime);
        }
    }
}