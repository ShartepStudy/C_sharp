using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace DesktopWallpaper
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Select the first value of the dropdown by default
            ddlStyle.SelectedIndex = 0;
            // The PictureBox image will fit but keep its aspect ratio
            picThumbnail.SizeMode = PictureBoxSizeMode.Zoom;
            // Show the current wallpaper
            picThumbnail.ImageLocation = GetCurrentWallpaper();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (openGraphic.ShowDialog() == DialogResult.OK)
            {
                // Preview the wallpaper in a PictureBox
                picThumbnail.ImageLocation = openGraphic.FileName;
                // Fit the PictureBox
                picThumbnail.SizeMode = PictureBoxSizeMode.Zoom;
                // Pass the file path, and two options to specify the wallpaper style
                SetWallpaper(openGraphic.FileName, 2, 0);
            }
        }

        private void SetWallpaper(string WallpaperLocation, int WallpaperStyle, int TileWallpaper)
        {
            // Sets the actual wallpaper
            SystemParametersInfo(20, 0, WallpaperLocation, 0x01 | 0x02);
            // Set the wallpaper style to streched (can be changed to tile, center, maintain aspect ratio, etc.
            RegistryKey rkWallPaper = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            // Sets the wallpaper style
            rkWallPaper.SetValue("WallpaperStyle", WallpaperStyle);
            // Whether or not this wallpaper will be displayed as a tile
            rkWallPaper.SetValue("TileWallpaper", TileWallpaper);
            rkWallPaper.Close();
        }

        private string GetCurrentWallpaper()
        {
            // The current wallpaper path is stored in the registry at HKEY_CURRENT_USER\\Control Panel\\Desktop\\WallPaper
            RegistryKey rkWallPaper = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", false);
            string WallpaperPath = rkWallPaper.GetValue("WallPaper").ToString();
            rkWallPaper.Close();
            // Return the current wallpaper path
            return WallpaperPath;
        }
    }
}