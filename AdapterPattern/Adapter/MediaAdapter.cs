using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Concrete
{
    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer _amp;
        public MediaAdapter(string audioType)
        {
            if (audioType.EndsWith("video"))
            {
                _amp = new VideoPlayer();
            }
            else if (audioType.EndsWith("mp4"))
            {
                _amp = new Mp4Player();
            }
        }


        public void Play(string audioType, string fileName)
        {
            if (audioType.EndsWith("video"))
            {
                _amp.PlayVideo(fileName);
            }
            else if (audioType.EndsWith("mp4"))
            {
                _amp.PlayVideo(fileName);
            }
        }
    }
}
