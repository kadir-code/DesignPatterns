using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Interface
{
    public interface IAdvancedMediaPlayer
    {
        void PlayVideo(string fileName);
        void PlayMp4(string fileName);
    }
}
