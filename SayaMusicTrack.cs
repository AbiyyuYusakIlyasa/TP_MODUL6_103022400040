using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL6_103022400040
{

    using System;

    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        // Constructor
        public SayaMusicTrack(string title)
        {
            this.title = title;
            this.playCount = 0;

            // generate id random 5 digit
            Random rand = new Random();
            this.id = rand.Next(10000, 100000);
        }

        // Method untuk menambah play count
        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        // Method untuk print detail
        public void PrintTrackDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
            Console.WriteLine("----------------------");
        }
    }
}
