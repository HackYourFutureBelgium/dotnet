// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




//var time = new JupiterTime(1, 21);
//var timeIn1Hour = time.ChangeHours(-888);
//var timeIn20Minutes = time.ChangeMinutes(-739);


//time.PrintTime(); <-- old print method, works


var time = new JupiterTime(23, 40);
Console.WriteLine(time);

var ttime = new TitanTime(1000, 40);
Console.WriteLine(ttime);

var gtime = new GynamedeTime(300, 40);
Console.WriteLine(gtime);

Console.ReadLine();


public class JupiterTime : AlienTime
{
    public JupiterTime(int hours, int minutes)
       : base(hours, minutes, 10) { }
    
}

public class TitanTime : AlienTime
{
    public TitanTime(int hours, int minutes)
       : base(hours, minutes, 900) { }

}

public class GynamedeTime : AlienTime
{
    public GynamedeTime(int hours, int minutes)
        : base(hours, minutes, 171) { }
}


public abstract class AlienTime
{
    public AlienTime(int hours, int minutes, int hoursInDay)
    {
        int totalMinutes = hours * 60 + minutes;
        Minutes = totalMinutes % 60;
        int totalHours = (totalMinutes - Minutes) / 60;
        Hours = totalHours % hoursInDay;
    }
    
    private int _hoursInDay{get; set;}
    public int Hours { get; set; }
    public int Minutes { get; set; }

    public override string ToString()
    {
        if (Minutes < 10)
        {
            if (Hours < 100 && Hours > 9)
            {
                return $"0{Hours}:0{Minutes}";
            }
            else if (Hours < 10)
            {
                return $"00{Hours}:0{Minutes}";
            }
            else
            {
                return $"{Hours}:0{Minutes}";
            }
        }
        else
        {
            if (Hours < 100 && Hours > 9)
            {
                return $"0{Hours}:{Minutes}";
            }
            else if (Hours < 10)
            {
                return $"00{Hours}:{Minutes}";
            }
            else
            {
                return $"{Hours}:{Minutes}";
            }
        }
    }

}

/*
 signaler class works 
 
public class Signaler
{
    public List<JupiterTime> signalTimes = new();


    /*
    public SignalTime(int sigHour, int sigMinute)
    {
        sigHour = Hours;
        sigMinute = Minutes;
    }

    
    public int Hours { get; set; }
    public int Minutes { get; set; }
    

    public void AddTimer(JupiterTime time)
    {
        signalTimes.Add(time);
    }

    public void Infrom()
    {
        if (signalTimes.Count == 0)
        {
            Console.WriteLine("no timers added yet");
            return;
        }
        else
        {
            foreach (var jupiterTime in signalTimes)
            {
                Console.WriteLine(jupiterTime);
            }
        }
    }

    public void Check(JupiterTime timeNow)
    {
        string nowTime = timeNow.ToString();
        string nowDec = nowTime[1] + "0";
        int nowDecimal = int.Parse(nowDec);
        int nowDigit = nowDecimal / 10;

        string nowMinuteDec = nowTime[3] + nowTime[4] + "0";
        int nowMinuteDecimal = int.Parse(nowMinuteDec);
        int nowMinuteDigit = nowMinuteDecimal / 10;

        var allBefore = new List<string>();


        foreach (var jupiterTime in signalTimes)
        {

            string jupiterHour = jupiterTime.ToString();
            string jupiterDec = jupiterHour[1] + "0";
            int jupiterDecimal = int.Parse(jupiterDec);
            int digit = jupiterDecimal / 10;

            string minuteDec = jupiterHour[3] + jupiterHour[4] + "0";
            int minuteDecimal = int.Parse(minuteDec);
            int minuteDigit = minuteDecimal / 10;

            //Console.WriteLine($"hour now is: {nowDigit}. hour to compare to is: {digit}");

            if (digit <= nowDigit && nowMinuteDigit >= minuteDigit)
            {
                allBefore.Add(jupiterHour);
                Console.WriteLine(jupiterTime);
            }
            
        }
        if (allBefore.Count == 0)
        {
            Console.WriteLine("no signals needed to be sent yet");
        }

    }

}
*/

/*
 class jupiter time works 
 
public class JupiterTime
{

    public JupiterTime(int hours, int minutes)
    {
        int totalMinutes = hours * 60 + minutes;
        int totalHours = (totalMinutes - Minutes) / 60;
        Hours = totalHours % 10;
        Minutes = totalMinutes % 60;
    }

    public int Hours { get; set; }
    public int Minutes { get; set; }

    public int ChangeHours(int toChange)
    {
        if (toChange < 0)
        {
            if (Hours + toChange < 0)
            {
                return Hours = (10 + (Hours + (toChange%10))) % 10;
            }
            else return Hours = (Hours + toChange) % 10;
        }else 
        return Hours = (Hours + toChange)%10;
    }
    
    public int ChangeMinutes(int toChange)
    {
        int totalMinutes = Hours * 60 + Minutes;
        int newTotalMinutes = totalMinutes + toChange%60;
        int newMinutes = newTotalMinutes % 60;
        int newHours = (toChange - toChange % 60) / 60;
        if (Minutes+ toChange % 60 >= 60)
        {
            ChangeHours(newHours +1 );

        }
        else if (Minutes + toChange % 60 < 0 && toChange < 0) {
            ChangeHours(newHours - 1);
        }
        else
        {
            ChangeHours(newHours);
        }
        return Minutes = newMinutes;
    }
    public override string ToString()
    {
        if (Minutes < 10)
        { 
            return $"0{Hours}:0{Minutes}";
        }
        else
        {
            return $"0{Hours}:{Minutes}";
        }
         
    }

    /*
    old print method, works

    public void PrintTime()
    {
        if (Minutes < 10) {
            Console.WriteLine($"0{Hours}:0{Minutes}");
        }
        else Console.WriteLine($"0{Hours}:{Minutes}");
    }
}
*/


/* part 1 works!
var time = new JupiterTime();
time.Hours = 8;
time.Minutes = 40;

//Console.WriteLine(time.PrintTime);

PrintTime(time);
//time.PrintTime();

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"{time.Hours}:{time.Minutes}");
}


Console.ReadLine();

public class JupiterTime
{
    public int Hours
    {
        set;
        get;
    }
    public int Minutes
    {
        set;
        get;
    }

    /*
    public void PrintTime()
    {
        Console.WriteLine($"{Hours}:{Minutes}");
    }
}
    */

/* 
  solution 2 works!
 
public class JupiterTime
{
    public JupiterTime(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }

    public int Hours { get;  set; }
    public int Minutes { get; set; }


    /*
    public int Hours {
        get
        {
            return Hours;
        }
        set
        {
            if (value > 10)

                Hours = 2;
            else Hours = value;
            
        }
    }
    public int Minutes
    {
        get
        {
            return Minutes;
        }
        set
        {
            if (value >= 60)

                Minutes = 3;
            //Hours = Hours + 1;
            else Minutes = value;

        }
    }

    
    public void PrintTime()
    {
        Console.WriteLine($"{Hours}:{Minutes}");
    }
}
*/


/*
 solution 6 works 
 
var signaler = new Signaler();
signaler.AddTimer(new JupiterTime(1, 20));
signaler.AddTimer(new JupiterTime(2, 20));
signaler.AddTimer(new JupiterTime(3, 20));


signaler.Infrom();
*/


/*
 solution 7 
 
var signaler = new Signaler();
signaler.AddTimer(new JupiterTime(2, 00));
signaler.AddTimer(new JupiterTime(4, 00));
signaler.AddTimer(new JupiterTime(6, 00));


signaler.Check(new JupiterTime(4, 21));

//signaler.Check(new JupiterTime(6, 21));

//signaler.Check(new JupiterTime(1, 17));
*/


/*
 solution 8 works
 
var titanTime = new TitanTime(11, 7);
//titanTime = new TitanTime(100, 40);
Console.WriteLine(titanTime);


Console.ReadLine();

public class TitanTime
{
    public TitanTime(int hours, int minutes)
    {
        int totalMinutes = hours * 60 + minutes;
        TitanMinutes = totalMinutes % 60;  
        int totalHours = (totalMinutes - TitanMinutes) / 60;
        TitanHours = totalHours % 900;
    }
    public int TitanHours { get; set; }
    public int TitanMinutes { get; set; }

    public override string ToString()
    {
        if(TitanMinutes < 10)
        {
            if(TitanHours < 100 && TitanHours > 9)
            {
                return $"0{TitanHours}:0{TitanMinutes}";
            }else if (TitanHours<10)
            {
                return $"00{TitanHours}:0{TitanMinutes}";
            }else
            {
              return $"{TitanHours}:0{TitanMinutes}";
            }
        }
        else
        {
            if (TitanHours < 100 && TitanHours > 9)
            {
                return $"0{TitanHours}:{TitanMinutes}";
            }
            else if (TitanHours < 10)
            {
                return $"00{TitanHours}:{TitanMinutes}";
            }
            else
            {
                return $"{TitanHours}:{TitanMinutes}";
            }
        }
    }
}
*/