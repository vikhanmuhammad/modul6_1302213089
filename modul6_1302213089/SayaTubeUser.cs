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
            Debug.Assert(username.Length <= 100, "Panjang username maksimal 100 karakter!");
            Debug.Assert(username != null, "Username tidak boleh kosong!");

            this.username = username;
            Random objRandom = new Random();
            id = objRandom.Next(10000, 99999);
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int jumlah = 0;
            try
            {
                for (int i = 0; i < uploadedVideos.Count; i++)
                {
                    jumlah = checked(jumlah + uploadedVideos[i].getPlayCount());
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Jumlah playCount melebihi bilangan integer maksimum!");
            }

            return jumlah;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null, "Video tidak boleh kosong!");
            Debug.Assert(video.getPlayCount() <= 2147483647, "Jumlah playCount melebihi bilangan integer maksimum!");

            this.uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User : " + username);
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video : " + (i + 1) + " judul : " + uploadedVideos[i].getTitle());
                Debug.Assert(i <= 8, "Video yang dicetak melebihi 8!");
            }
        }
    }
}
