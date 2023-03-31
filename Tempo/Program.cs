using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Declares And Initiates crono1 And crono2;
        Stopwatch crono1 = new Stopwatch();
        Stopwatch crono2 = new Stopwatch();

        // Starts To Count The Time In crono1 And crono2;
        crono1.Start();
        Thread.Sleep(500);

        crono2.Start();
        Thread.Sleep(300);

        crono1.Stop();
        crono2.Stop();

        double elapsedTime1 = crono1.Elapsed.TotalSeconds;
        double elapsedTime2 = crono2.Elapsed.TotalSeconds;

        Console.WriteLine($"Run time for each chronometer {elapsedTime1:F2} , {elapsedTime2:F2}");
    }
}

