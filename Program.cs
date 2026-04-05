// See https://aka.ms/new-console-template for more information

using System;
using TP_MODUL6_103022400040;

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack lagu1 = new SayaMusicTrack("Lagu A");
        SayaMusicTrack lagu2 = new SayaMusicTrack("Lagu B");

        lagu1.IncreasePlayCount(10);
        lagu2.IncreasePlayCount(5);

        lagu1.PrintTrackDetails();
        lagu2.PrintTrackDetails();
    }
}