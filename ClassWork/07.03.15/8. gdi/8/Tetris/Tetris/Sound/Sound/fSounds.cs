using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using Sound.Properties;

namespace sounds
{
    public class fSounds
    {
        //звук
        public void playSound(String name)
        {
            SoundPlayer player = new SoundPlayer();
            switch (name)
            { 
                case "clear-line":
                    player.Stream = Resources.clearLine;
                    break;                    
                case "figure-fall":
                    player.Stream = Resources.figureFall;
                    break;
            }

            player.Play();
        }
    }
}
