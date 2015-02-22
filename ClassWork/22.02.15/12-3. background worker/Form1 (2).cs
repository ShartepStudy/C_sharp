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

        byte[] buffer = new byte[1024 * 1024 * 300]; // 300 MB buffer

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
            ofd.InitialDirectory = Environment.SpecialFolder.MyMusic.ToString();
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
            f1.folderBrowserDialog1.ShowDialog();

            sDestDir = f1.folderBrowserDialog1.SelectedPath;
            MessageBox.Show(sDestDir);
        }

        private void btnStartCopy_Click(object sender, EventArgs e)
        {
            // BackgroundWorker class provides an easy way to run time-consuming operations
            // on a background thread. The BackgroundWorker class enables you to check the state of
            // the operation and it lets you cancel the operation.

            // Копирование файла – это обычная задача, и было бы разумным запускать эту потенциально
            // длительную операцию в отдельном потоке. С помощью компонента BackgroundWorker и небольшого
            // фрагмента кода эта задача легко решается.

            // Запускает выполнение фоновой операции
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyFile();
        }

        public void CopyFile()
        {
            if (sPathToFile.Length > 0)
            {
                try
                {
                    using (FileStream source = new FileStream(sPathToFile, FileMode.Open, FileAccess.Read))
                    {
                        double fileLength = source.Length;

                        using (FileStream dest = new FileStream(Path.Combine(sDestDir, sNewFileName), FileMode.CreateNew, FileAccess.Write))
                        {
                            long totalBytes = 0;
                            int currentBlockSize = 0;

                            while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                dest.Write(buffer, 0, currentBlockSize);

                                totalBytes += currentBlockSize;
                                persentage = (int)totalBytes / (int)(fileLength / 100.0);
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

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = persentage;
            lblProgressStatus.Text = "Скопировано " + persentage + " % ";
            progressBar1.PerformStep();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Файл скопирован!");
        }
    }
}
