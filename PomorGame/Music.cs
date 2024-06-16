using PomorGame.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PomorGame
{
    public static class Music
    {
        public static void MusicOn()
        {
            SoundPlayer sp = new SoundPlayer(Resources.SampleForMenu);
            sp.PlayLooping(); ;
        }

        public static void MusicOff() {
            SoundPlayer sp = new SoundPlayer(Resources.SampleForMenu);
            sp.Stop(); 
        }
    }
}
