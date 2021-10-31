using AdapterPattern.Concrete;
using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public class Audio : IMediaPlayer
    {
        IMediaPlayer _mediaPlayer;
        public void Play(string audioType, string fileName)
        {
            if (audioType.EndsWith("mp3"))
            {
                Console.WriteLine("Playing mp3 file :"+fileName);
            }
            else if (audioType.EndsWith("video") || audioType.EndsWith("mp4"))
            {
                _mediaPlayer = new MediaAdapter(audioType);
                _mediaPlayer.Play(audioType,fileName);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
