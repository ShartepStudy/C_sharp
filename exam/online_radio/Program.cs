using WMPLib;
using System;
using System.Threading;
using System.Text;
using System.Xml;
using System.Collections;
using System.Collections.Generic;

namespace online_radio
{
    class Program
    {
		static WindowsMediaPlayer WMPs = new WMPLib.WindowsMediaPlayer(); //создаётся плеер 
		static List<RadioStation> radioStations = new List<RadioStation>();

		class RadioStation {
			public string mID { get; set; }
			public string mName { get; set; }
			public string mURL { get; set; }
		}

        class PlayerState
        {
            public bool mIsPlay = false;
            public string mStation;
            public int mVolume = 50;
            public bool mIsNeedUpdate = false;
        }

        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;

			XmlTextReader reader = null;

			try {
				reader = new XmlTextReader(@"radio_stations.xml");

				while (reader.Read()) {
					if (reader.NodeType == XmlNodeType.Element && reader.Name == "Station" && reader.AttributeCount > 0) {
						RadioStation station = new RadioStation();
						while (reader.MoveToNextAttribute()) {
							if (reader.NodeType == XmlNodeType.Attribute && reader.Name == "id")
								station.mID = reader.Value;
							if (reader.NodeType == XmlNodeType.Attribute && reader.Name == "name")
								station.mName = reader.Value;
						}
						
						reader.Read();
						if (reader.NodeType == XmlNodeType.Text)
							station.mURL = reader.Value;

						radioStations.Add(station);
					}
				}
			} catch {
				Console.WriteLine("Oops!");
			} finally {
				if (reader != null)
					reader.Close();
			}

			int currentStation = 0;
			WMPs.URL = radioStations[currentStation].mURL;
			WMPs.settings.volume = 100;

			Time();
            PlayerState ps = new PlayerState();
			bool isPause = false;
			ConsoleKey k = 0;
			while (k != ConsoleKey.Escape) {
				k = Console.ReadKey().Key;
				switch (k) { 
				case ConsoleKey.Spacebar:
                    if (isPause == true)
                    {
//						WMPs.controls.play();
						isPause = false;
                        
					} else { 
						WMPs.controls.pause(); 
						isPause = true;
					}
					break;
                case ConsoleKey.OemMinus:
                    WMPs.settings.volume--;
                    break;
                case ConsoleKey.OemPlus:
                    WMPs.settings.volume++;
                    break;
				case ConsoleKey.RightArrow:
                    if (currentStation < radioStations.Count - 1)
						WMPs.URL = radioStations[++currentStation].mURL;						
					else
						WMPs.URL = radioStations[currentStation = 0].mURL;
					break;
				case ConsoleKey.LeftArrow:
					if (currentStation > 0)
						WMPs.URL = radioStations[--currentStation].mURL;
					else
						WMPs.URL = radioStations[currentStation = radioStations.Count - 1].mURL;
					break;
				}
			}
        }
		static void Time() {
			Timer timer = new Timer(ConsolWriting, null, 0, 500);
		}

		static void ConsolWriting(object data) {
			try {
				Console.Clear();
				Console.WriteLine();
				Console.WriteLine();

				foreach (var station in radioStations) {
					if (station.mURL == WMPs.URL)
						Console.ForegroundColor = ConsoleColor.Red;
					else
						Console.ForegroundColor = ConsoleColor.Green;

					Console.WriteLine("\t\t" + station.mID.ToString() + ". " + station.mName + "\n");
				}

				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("\n\n");
				Console.WriteLine("\t" + WMPs.status + "\n");
				Console.WriteLine("\tvolume: " + WMPs.settings.volume.ToString());
				Console.WriteLine("\n\n");

				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("\t<- pregvios station\t\t-> next station\n\n");
				Console.WriteLine("\t- volume down\t\t\t+ volume up\n\n");
				Console.WriteLine("\tspace - pause/play\t\t esc - exit");
			} catch (Exception e) {
				Console.WriteLine(e);
			}
		}
    }
}