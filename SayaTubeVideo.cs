using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210095
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random(DateTime.Now.Minute);
            this.Title = title;
            this.id = random.Next(10000, 99999);
            this.PlayCount = 0;
        }

        public string Title { get => title; set => title = value; }
        public int PlayCount { get => playCount; set => playCount = value; }

        public void IncresePlayCount(int count)
        {
            this.PlayCount += count;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine(
                    this.Title + "\n#" + this.id +
                    "\ndiputar: " + this.PlayCount
                );
        }

    }
}
