using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Процесс_загрузки_файла
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog folderBrowserDialog1;

        string sPathToFile = "";
        string sDestDir = @"d:\dest";
        string sNewFileName = "";
        string sOldFileName = "";

        byte[] buffer = new byte[1024 * 1024]; // 1MB buffer

        int persentage = 0;

        public Form1()
        {
            InitializeComponent();
            this.progressBar1.Value = 0;
            this.progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            ofd.Filter = "mp3 files|*.mp3| Все файлы|*.*";
            ofd.FilterIndex = 1;
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.sPathToFile = ofd.FileName.ToString();
                int iLastSlash = sPathToFile.LastIndexOf('\\', sPathToFile.Length - 1);
                sOldFileName = sPathToFile.Remove(0, iLastSlash + 1);
                sNewFileName = "Копия" + sOldFileName;
                //MessageBox.Show("sNewFileName - " + sNewFileName);
            }
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.folderBrowserDialog1 = new FolderBrowserDialog();
            f1.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;
            
            f1.folderBrowserDialog1.Description = "Укажите папку назначения :";
            // Do not allow the user to create new files via the FolderBrowserDialog. 
            f1.folderBrowserDialog1.ShowNewFolderButton = false;
            f1.folderBrowserDialog1.ShowDialog();
            MessageBox.Show(sDestDir = f1.folderBrowserDialog1.SelectedPath); 
        }

        private void btnStartCopy_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        public void CopyFile()
        {
            //sNewFileName = sDestDir + 
            if (sPathToFile.Length > 0)
            {
                try
                {
                    //File.Copy(sPathToFile, Path.Combine(sDestDir, @"new.mp3"));

                    using (FileStream source = new FileStream(sPathToFile, FileMode.Open, FileAccess.Read))
                    {
                        long fileLength = source.Length;

                        using (FileStream dest = new FileStream(Path.Combine(sDestDir, sNewFileName), FileMode.CreateNew, FileAccess.Write))
                        {
                            long totalBytes = 0;
                            int currentBlockSize = 0;

                            while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                dest.Write(buffer, 0, currentBlockSize);

                                totalBytes += currentBlockSize;
                                persentage = (int)(totalBytes / fileLength / 100);
                                backgroundWorker1.ReportProgress(persentage);

                            }
                        }
                    }
                    
                }
                // Catch exception if the file was already copied. 
                catch (IOException copyError)
                {
                    MessageBox.Show(copyError.Message);
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyFile();
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            persentage = 0;
            progressBar1.Value = persentage;
            lblProgressStatus.Text = "Скопировано " + persentage + " % ";
            MessageBox.Show("Файл скопирован!");
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //MessageBox.Show("(int)persentage = " + persentage);
            progressBar1.Value = persentage;
            lblProgressStatus.Text = "Скопировано " + persentage + " % ";
            //progressBar1.PerformStep();
            //MessageBox.Show("backgroundWorker1_ProgressChanged");
            
        }
    }
}
