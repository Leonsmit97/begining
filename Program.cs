using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace sound
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                //plays a wave file
                SoundPlayer player = new SoundPlayer(@"C:\Users\Leon\Documents\sound.wav");
                player.Play();
                Console.ReadLine();
            }
          
        }
    }
}
