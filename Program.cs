// See https://aka.ms/new-console-template for more information

using System;
using TP_MODUL6_103022400040;

class Program
{
    static void Main()
    {
        try
        {
            SayaMusicTrack lagu = new SayaMusicTrack("Lagu Favorit");

            // Test normal
            lagu.IncreasePlayCount(5000000);

            // Test melebihi batas (precondition)
            lagu.IncreasePlayCount(20000000);

            // Test overflow (loop biar cepat)
            for (int i = 0; i < 100; i++)
            {
                lagu.IncreasePlayCount(int.MaxValue);
            }

            lagu.PrintTrackDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi error: " + ex.Message);
        }
    }
}