using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace TP_MODUL6_103022400040
{
    class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {

            Debug.Assert(title != null, "Judul tidak boleh null");
            Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter");

            this.title = title;
            this.playCount = 0;

            Random rand = new Random();
            this.id = rand.Next(10000, 100000);
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Penambahan play count maksimal 10.000.000");

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Terjadi overflow pada play count!");
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
            Console.WriteLine("------------------------");
        }
    }
}
