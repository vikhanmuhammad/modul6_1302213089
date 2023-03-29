using System;
using System.Collections.Generic;
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
            this.title = title;
            Random objRandom = new Random();
            id = objRandom.Next(10000, 99999);
            playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
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
