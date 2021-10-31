using AdapterPattern.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Audio audio = new Audio();

            audio.Play("mp3","song1");
            audio.Play("video","video1");
            audio.Play("mp4","mp4_1");
            audio.Play("xpr","something");

            Console.Read();
        }
    }
}
