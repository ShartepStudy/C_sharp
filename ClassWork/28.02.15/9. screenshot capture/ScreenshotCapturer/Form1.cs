using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ScreenshotCapturer
{
    public partial class Form1 : Form
    {
        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            // If the user has chosen a path where to save the screenshot
            if (saveScreenshot.ShowDialog() == DialogResult.OK)
            {
                // Hide the form so that it does not appear in the screenshot
                this.Hide();
                Thread.Sleep(200);
                // Set the bitmap object to the size of the screen
                bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                // Create a graphics object from the bitmap
                gfxScreenshot = Graphics.FromImage(bmpScreenshot);
                // Take the screenshot from the upper left corner to the right bottom corner
                gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                // Save the screenshot to the specified path that the user has chosen
                bmpScreenshot.Save(saveScreenshot.FileName, ImageFormat.Png);
                // Show the form again
                this.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap bmpScreenshot;
            Graphics gfxScreenshot;
            // Set the bitmap object to the size of the screen
            bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            // Create a graphics object from the bitmap
            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            // Take the screenshot from the upper left corner to the right bottom corner
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            // Save the screenshot to the specified path that the user has chosen
            bmpScreenshot.Save(DateTime.Now.ToString("yyyyMMddHHmmssff") + ".png", ImageFormat.Png);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}