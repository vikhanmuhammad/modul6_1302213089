using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213089
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            this.username = username;
            Random objRandom = new Random();
            id = objRandom.Next(10000, 99999);
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int jumlah = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                jumlah += uploadedVideos[i].getPlayCount();
            }
            return jumlah;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            this.uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User : " + username);
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video : " + (i + 1) + " judul : " + uploadedVideos[i].getTitle());
            }
        }
    }
}
