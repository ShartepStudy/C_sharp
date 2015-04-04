using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

public class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
        try
        {
            this.Cursor = AdvancedCursors.Create(Path.Combine(Application.StartupPath, "dogani.ani"));
        }
        catch (Exception err)
        {
            MessageBox.Show(err.Message);
        }
    }

    private void InitializeComponent()
    {
        this.SuspendLayout();

        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(292, 266);
        this.Text = "Animated Cursor";
        this.ResumeLayout(false);
    }


    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new Form1());
    }

}

public class AdvancedCursors
{

    [DllImport("User32.dll")]
    private static extern IntPtr LoadCursorFromFile(String str);

    public static Cursor Create(string filename)
    {
        IntPtr hCursor = LoadCursorFromFile(filename);

        if (!IntPtr.Zero.Equals(hCursor))
        {
            return new Cursor(hCursor);
        }
        else
        {
            throw new ApplicationException("Could not create cursor from file " + filename);
        }
    }
}