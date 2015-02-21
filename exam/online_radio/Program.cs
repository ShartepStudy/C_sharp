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
		static PlayerSettings ps = new PlayerSettings();

		class RadioStation {
			public string mID { get; set; }
			public string mName { get; set; }
			public string mURL { get; set; }
		}

		class PlayerSettings {
			public bool mIsPlay = true;
			public string mStatus;
			public string mURL;
			public int mVolume = 50;
			public bool mIsNeedUpdate = true;
		}

        static void Main()
        {
			Console.BackgroundColor = ConsoleColor.DarkBlue;

			using (XmlTextReader reader = new XmlTextReader(@"radio_stations.xml")) {
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
			}

			int currentStation = 0;
			ps.mURL = radioStations[currentStation].mURL;
			StartUpdate();

			new Timer(Update, null, 0, 100);

			ConsoleKey k = 0;
			while (k != ConsoleKey.Escape) {
				k = Console.ReadKey().Key;
				if (Console.CursorLeft > 0) { 
					Console.CursorLeft--;
					Console.Write(" ");
					Console.CursorLeft--;
				}

				switch (k) { 
				case ConsoleKey.Spacebar: 
					ps.mIsPlay = !ps.mIsPlay;

					lock (ps)
						ps.mIsNeedUpdate = true;
					break;
				case ConsoleKey.OemMinus:
					if (ps.mVolume > 0)
						ps.mVolume--;
					UpdateVolume();

					lock (ps)
						ps.mIsNeedUpdate = true;
					break;
				case ConsoleKey.OemPlus:
					if (ps.mVolume < 100)
						ps.mVolume++;
					UpdateVolume();

					lock (ps)
						ps.mIsNeedUpdate = true;
					break;
				case ConsoleKey.RightArrow:
					lock (ps) { 
						if (currentStation < radioStations.Count - 1)
							ps.mURL = radioStations[++currentStation].mURL;						
						else
							ps.mURL = radioStations[currentStation = 0].mURL;

						ps.mIsNeedUpdate = true;
					}
					UpdateStations();
					break;
				case ConsoleKey.LeftArrow:
					lock (ps) {
						if (currentStation > 0)
							ps.mURL = radioStations[--currentStation].mURL;
						else
							ps.mURL = radioStations[currentStation = radioStations.Count - 1].mURL;

						ps.mIsNeedUpdate = true;
					}
					UpdateStations();
					break;
				}
			}
        }

		static void Update(object obj) {
			try { 
				if (ps.mIsNeedUpdate == true) {
					lock (ps) {
						if (ps.mIsPlay == true)
							WMPs.controls.play();
						else
							WMPs.controls.pause();

						if (ps.mURL != WMPs.URL)
							WMPs.URL = ps.mURL;

						if (ps.mVolume != WMPs.settings.volume)
							WMPs.settings.volume = ps.mVolume;
				
						ps.mIsNeedUpdate = false;
					}
				}

				if (ps.mStatus != WMPs.status) {
					ps.mStatus = WMPs.status;
					UpdateStatus();
				}
			} catch (Exception) { }
		}


		static void UpdateStations() {
			Console.ForegroundColor = ConsoleColor.Green;
			int x = 16;
			int y = 3;
			foreach (var station in radioStations) {
				Console.SetCursorPosition(x, y);
				if (station.mURL == ps.mURL) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(new String(' ', station.mName.Length + 25));
					Console.SetCursorPosition(x, y);
					Console.WriteLine(station.mID.ToString() + ". " + station.mName);
					Console.ForegroundColor = ConsoleColor.Green;
				} else {
					Console.WriteLine(new String(' ', station.mName.Length + 25));
					Console.SetCursorPosition(x, y);
					Console.WriteLine(station.mID.ToString() + ". " + station.mName);
				}
				y += 2;
			}
			Console.SetCursorPosition(0, 3 + radioStations.Count * 2 + 20);
		}

		static void UpdateStatus() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			int x = 8;
			int y = 3 + radioStations.Count * 2 + 3;
			Console.SetCursorPosition(x, y);
			Console.WriteLine(new String(' ', 150));
			Console.SetCursorPosition(x, y);
			Console.WriteLine(ps.mStatus);

			Console.SetCursorPosition(0, 3 + radioStations.Count * 2 + 20);
		}

		static void UpdateVolume() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			int x = 16;
			int y = 3 + radioStations.Count * 2 + 6;
			Console.SetCursorPosition(x, y);
			Console.WriteLine("    ");
			Console.SetCursorPosition(x, y);
			Console.WriteLine(ps.mVolume.ToString());

			Console.SetCursorPosition(0, 3 + radioStations.Count * 2 + 20);
		}

		static void StartUpdate() {
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\n\n");

			foreach (var station in radioStations) {
				if (station.mURL == ps.mURL) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("\t\t" + station.mID.ToString() + ". " + station.mName + "\n");
					Console.ForegroundColor = ConsoleColor.Green;
				} else
					Console.WriteLine("\t\t" + station.mID.ToString() + ". " + station.mName + "\n");
			}

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\n\n\n");
			Console.WriteLine("\t" + ps.mStatus + "\n");
			Console.WriteLine("\tvolume: " + ps.mVolume.ToString());
			Console.WriteLine("\n\n");

			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("\t<- pregvios station\t\t-> next station\n\n");
			Console.WriteLine("\t- volume down\t\t\t+ volume up\n\n");
			Console.WriteLine("\tspace - pause/play\t\t esc - exit");
			Console.WriteLine("\n\n");
		}
    }
}