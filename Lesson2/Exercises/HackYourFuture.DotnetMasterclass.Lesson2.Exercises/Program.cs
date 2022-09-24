var signaler = new Signaler();
signaler.AddTime(new JupiterTime(2, 00));
signaler.AddTime(new JupiterTime(4, 00));
signaler.AddTime(new JupiterTime(6, 00));

// We woke up at 4:21
signaler.Check(new JupiterTime(4, 21));

public class JupiterTime : AlienTime
{
    public JupiterTime(int hours, int minutes)
        : base(hours, minutes, 10)
    { }
}

public class TitanTime : AlienTime
{
    public TitanTime(int hours, int minutes)
        : base(hours, minutes, 900)
    { }
}

public class GanymedeTime : AlienTime
{
    public GanymedeTime(int hours, int minutes)
        : base(hours, minutes, 171)
    { }
}
public abstract class AlienTime
{
    private readonly int _hoursPerDay;
    private const int MinutesPerHour = 60;

    protected AlienTime(int hours, int minutes, int hoursPerDay)
    {
        _hoursPerDay = hoursPerDay;

        var totalMinutes = hours * MinutesPerHour + minutes;

        totalMinutes = MakeSureTimeIsPositive(totalMinutes);

        Minutes = totalMinutes % MinutesPerHour;

        var totalHours = (totalMinutes - Minutes) / MinutesPerHour;

        Hours = totalHours % _hoursPerDay;
    }

    private int MakeSureTimeIsPositive(int totalMinutes)
    {
        if (totalMinutes < 0)
        {
            // Add one, because we want to round up
            // Integer division in C# rounds down
            var minutesBelowZero = 0 - totalMinutes;
            var totalDaysBelowZero = 1 + minutesBelowZero / (_hoursPerDay * MinutesPerHour);

            // Add that many days, so we have a positive number
            totalMinutes += totalDaysBelowZero * _hoursPerDay * MinutesPerHour;
        }

        return totalMinutes;
    }

    public bool IsBefore(AlienTime other)
    {
        return TotalMinutes < other.TotalMinutes;
    }

    public int Hours { get; }

    public int Minutes { get; }

    public int TotalMinutes => Hours * MinutesPerHour + Minutes;

    public override string ToString()
    {
        return $"{Hours:D3}:{Minutes:D2}";
    }
}

class Signaler
{
    private readonly List<AlienTime> _signalTimes = new();

    public void AddTime(AlienTime time)
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

    public void Check(AlienTime time)
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