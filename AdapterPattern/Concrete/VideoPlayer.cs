using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Concrete
{
    public class VideoPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {            //...

        }

        public void PlayVideo(string fileName)
        {
            Console.WriteLine("Playing video file : " + fileName);

        }
    }
}
