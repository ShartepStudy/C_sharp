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
				@"http://www.prosto.fm/files/ProstoRadio64-Odessa.m3u",
				@"http://www.prosto.fm/files/PRock128.m3u"
			};
			int currentStation = 0;
			WMPs.URL = radioStations[currentStation];

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
			Console.WriteLine(WMPs.status);
		}
    }
}