using System.Reflection.Metadata.Ecma335;

var signaler = new Signaler();
signaler.AddTime(new JupiterTime(2, 00));
signaler.AddTime(new JupiterTime(4, 00));
signaler.AddTime(new JupiterTime(6, 00));

// We woke up at 4:21
signaler.Check(new JupiterTime(4, 21));

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

    public bool IsBefore(JupiterTime other)
    {
        return TotalMinutes < other.TotalMinutes;
    }

    public int Hours { get; }

    public int Minutes { get; }

    public int TotalMinutes => Hours * MinutesPerHour + Minutes;

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

        foreach (var signalTime in _signalTimes)
        {
            Console.WriteLine(signalTime);
        }
    }

    public void Check(JupiterTime time)
    {
        foreach (var signalTime in _signalTimes)
        {
            if (signalTime.IsBefore(time))
            {
                Console.WriteLine(signalTime);
            }
        }
    }
}