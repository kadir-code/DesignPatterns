using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Interface
{
    public interface IMediaPlayer
    {
        void Play(string audioType, string fileName);
    }
}
