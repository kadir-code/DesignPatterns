using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Concrete
{
    public class Mp4Player: IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing Mp4 file : " + fileName);


        }

        public void PlayVideo(string fileName)
        {
            //...

        }
    }
}
