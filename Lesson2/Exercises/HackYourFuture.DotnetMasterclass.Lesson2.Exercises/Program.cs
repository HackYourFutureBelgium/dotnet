﻿var time = new JupiterTime();
time.Hours = 8;
time.Minutes = 40;

PrintTime(time);

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"{time.Hours}:{time.Minutes:D2}");
}

class JupiterTime
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
}