using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213089
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null, "Judul tidak boleh kosong!");
            Debug.Assert(title.Length <= 200, "Judul lebih dari 200 karakter!");

            this.title = title;
            Random objRandom = new Random();
            id = objRandom.Next(10000, 99999);
            playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 25000000, "Tambahan playCount lebih dari 25.000.000!");
            Debug.Assert(playCount > 0, "Tambahan playCount tidak boleh negatif!");

            this.playCount += playCount;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("id : " + id + " \ntitle : " + title + " \nplayCount : " + playCount);
        }

        public string getTitle()
        {
            return title;
        }

        public int getPlayCount()
        {
            return playCount;
        }
        public int getId()
        {
            return id;
        }
    }
}
