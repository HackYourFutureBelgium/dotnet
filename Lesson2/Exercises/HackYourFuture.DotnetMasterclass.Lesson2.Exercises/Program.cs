var time = new JupiterTime(14, 88);

PrintTime(time);

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"{time.Hours}:{time.Minutes:D2}");
}

class JupiterTime
{
    public JupiterTime(int hours, int minutes)
    {
        var totalMinutes = hours * 60 + minutes;

        Minutes = totalMinutes % 60;

        var totalHours = (totalMinutes - Minutes) / 60;
        
        Hours = totalHours % 10;
    }
    public int Hours { get; }

    public int Minutes { get; }
}