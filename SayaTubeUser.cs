using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210095
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadVideos;
        public String Username;

        public SayaTubeUser(String Username)
        {
            Random random = new Random(DateTime.Now.Minute);
            this.Username = Username;
            this.id = random.Next(10000,99999);
            this.uploadVideos = new List<SayaTubeVideo>();

        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach(SayaTubeVideo video in uploadVideos)
            {
                total += video.PlayCount;
            }
            return total;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            uploadVideos.Add(video);
        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + Username);
            for (int index = 0; index < uploadVideos.Count; index++)
            {
                SayaTubeVideo video = uploadVideos[index];
                Console.Write("Video "+ index + " ");
                video.PrintVideoDetails();
            }
        }
    }
}
