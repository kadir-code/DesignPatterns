using CoRDesignPattern.Abstract;
using CoRDesignPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerHandler mp5Player = new Handlermp5();
            PlayerHandler mp3Player = new Handlermp3();
            PlayerHandler mp4player = new Handlermp4();

            mp3Player.NextHandler = mp4player;
            mp4player.NextHandler = mp5Player;

            mp5Player.Player("video.mp5");
            mp3Player.Player("video.mp5");
            mp3Player.Player("video.mp4");
            mp3Player.Player("video.swf");
            mp3Player.Player("video.mp3");
            Console.Read();
        }
    }
}
