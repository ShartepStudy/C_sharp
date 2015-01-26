using WMPLib;
using System;
using System.Threading;
using System.Text;

namespace online_radio
{
    class Program
    {
		static WindowsMediaPlayer WMPs = new WMPLib.WindowsMediaPlayer(); //создаётся плеер 

        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;

			string[] radioStations = {
				@"http://audio.rambler.ru/action/play.m3u?id=321&uid=PYb8BYJ/OFFGpwAAAdx4KgB",
				@"http://naxidigital128.kbcnet.rs:8020/",
				@"http://uk2.internet-radio.com:31491/",
				@"http://rmnrelax1.powerstream.de:8023/",
				@"http://5.2.65.200:8000/",
				@"http://sc-tcl.1.fm:8010/",
				@"http://87.98.180.164:8500/",
				@"http://uk1.internet-radio.com:15254/",
				@"http://205.164.35.3:80/",
				@"http://205.164.62.13:10152/",
				@"http://www.prosto.fm/files/PRock128.m3u"
			};
			int currentStation = 0;
			WMPs.URL = radioStations[currentStation];
			WMPs.settings.volume = 100;

			Time();

			bool isPause = false;
			ConsoleKey k = 0;
			while (k != ConsoleKey.Escape) {
				if (Console.KeyAvailable) {
					k = Console.ReadKey().Key;
					switch (k) { 
					case ConsoleKey.Spacebar: 
						if (isPause == true) {
							WMPs.controls.play();
							isPause = false;
						} else { 
							WMPs.controls.pause(); 
							isPause = true;
						}
						break;
					case ConsoleKey.OemMinus:
						WMPs.settings.volume--;
						Console.WriteLine(WMPs.settings.volume);
						break;
					case ConsoleKey.OemPlus:
						WMPs.settings.volume++;
						Console.WriteLine(WMPs.settings.volume);
						break;
					case ConsoleKey.RightArrow:
						if (currentStation < radioStations.Length - 1)
							WMPs.URL = radioStations[++currentStation];						
						else
							WMPs.URL = radioStations[currentStation = 0];
						break;
					case ConsoleKey.LeftArrow:
						if (currentStation > 0)
							WMPs.URL = radioStations[--currentStation];
						else
							WMPs.URL = radioStations[currentStation = radioStations.Length - 1];
						break;
					}
				}
			}
        }
		static void Time() {
			Timer timer = new Timer(ConsolWriting, null, 0, 100);
		}

		static void ConsolWriting(object data) {
			Console.Clear();
			try {
				Console.WriteLine(WMPs.status);
			} catch (Exception e) { }
		}
    }
}