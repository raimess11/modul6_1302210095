using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            try { Debug.Assert(title.Length <= 200, "maksimal karakter pada judul adalah 200"); }
            catch(Exception e) { Console.WriteLine(e.Message); }
            try { Debug.Assert(title != null, "judul tidak boleh null"); }
            catch(Exception e) { Console.WriteLine(e.Message); }
            
            Random random = new Random(DateTime.Now.Minute);
            this.Title = title;
            this.id = random.Next(10000, 99999);
            this.PlayCount = 0;
        }

        public string Title { get => title; set => title = value; }
        public int PlayCount { get => playCount; set => playCount = value; }

        public void IncresePlayCount(int count)
        {
            try { Debug.Assert(count <= 25000000, "maksimal penambahan count adalah 25.000.000 per penambahan"); }
            catch (Exception e) { Console.WriteLine(e.Message); }
            try { Debug.Assert(count >= 0, "penambahan tidak boleh negatif"); }
            catch (Exception e) { Console.WriteLine(e.Message); }

            try { this.PlayCount = checked(this.PlayCount + count); }
            catch(OverflowException e) { Console.WriteLine(e.Message); }
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
