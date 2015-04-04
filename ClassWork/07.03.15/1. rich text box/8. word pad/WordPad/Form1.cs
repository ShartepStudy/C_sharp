using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        string saveFileName;
        string sPathToPicture = "";
        int iNextSearchPoint = 0;
        int iReplacesCount = 0;
        string sEtalon = ""; // строка для хранения исходного содержимого загруженного файла

        //Переменные для richTextBox1.SelectionFont
        public static int size = 8;
        public static string fontFamily = "Ariel";
        public static FontStyle fontStile = FontStyle.Regular;

        public static bool bold = false;
        public static bool italic = false;
        public static bool underlined = false;

        public Form1()
        {
            InitializeComponent();
            /////////////////////////////////
            this.Text = "New File - NodePad";
            ///////////////////////////////

            //////////////////////////////// событие DragDrop НАЧАЛО   ///////////////////////////////

            richTextBox1.AllowDrop = true;
            richTextBox1.DragEnter += (sender, e) =>
            {
                if (e.Data.GetDataPresent("FileDrop"))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            };

            richTextBox1.DragDrop += (sender, e) =>
            {

                string[] files = e.Data.GetData("FileDrop") as string[];

                //richTextBox1.LoadFile(files[0], RichTextBoxStreamType.RichText);

                if (files != null)
                    foreach (string file in files)
                        //richTextBox1.Text += file + "\r\n";
                        richTextBox1.LoadFile(file, RichTextBoxStreamType.UnicodePlainText);

                sEtalon = richTextBox1.Text;
            };

            ////////////////////////////////////// событие DragDrop КОНЕЦ  ///////////////////////////////


            //Акселлераторы
            //NEW Ctrl+N
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.ShowShortcutKeys = true; //отображать акселераторы

            //SAVE Ctrl+S
            saveFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveFileToolStripMenuItem.ShowShortcutKeys = true;

            //OPEN Ctrl+O
            openFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openFileToolStripMenuItem.ShowShortcutKeys = true;

            //PRINT Ctrl+P
            printFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printFileToolStripMenuItem.ShowShortcutKeys = true;

            //UNDO Ctrl+Z
            undoFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoFileToolStripMenuItem.ShowShortcutKeys = true;

            //CUT Ctrl+X
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.ShowShortcutKeys = true;

            //COPY Ctrl+C
            cToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            cToolStripMenuItem.ShowShortcutKeys = true;

            //PASTE Ctrl+V
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.ShowShortcutKeys = true;

            //SELECT ALL Ctrl+A
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.ShowShortcutKeys = true;


            ///////////////////////////////////////////////////////////
            /// //REDO Ctrl+Y
            Redo.ShortcutKeys = Keys.Control | Keys.Y;
            Redo.ShowShortcutKeys = true;

            //ComboBox1, Font Styles
            ComboBox1.Items.Add("Ariel");
            ComboBox1.Items.Add("Arial Rounded MT");
            ComboBox1.Items.Add("Book Antiqua");
            ComboBox1.Items.Add("Calibri");
            ComboBox1.Items.Add("Century Gothic");
            ComboBox1.Items.Add("Tahoma");
            ComboBox1.Items.Add("Times New Roman");
            ComboBox1.Items.Add("Verdana");

            ComboBox1.SelectedIndex = 0;

            //ComboBox2, Font Size
            ComboBox2.Items.Add(8);
            ComboBox2.Items.Add(10);
            ComboBox2.Items.Add(12);
            ComboBox2.Items.Add(14);
            ComboBox2.Items.Add(16);
            ComboBox2.Items.Add(18);
            ComboBox2.Items.Add(20);
            ComboBox2.Items.Add(22);
            ComboBox2.Items.Add(24);

            ComboBox2.SelectedIndex = 0;
            //Richtetxtbox Selection Font
            //richTextBox1.SelectionFont = new Font(fontFamily, size, fontStile);

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        //сохранение файла
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(openFileDialog1.FileName);
            //запись текста в файл
            SaveFile.WriteLine(richTextBox1.Text);
            SaveFile.Close();

        }

        //сохранение файла save as
        private void saveasFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открытие диалого
            //saveFileDialog1.ShowDialog();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(saveFileDialog1.FileName);

                /////////////////////////////////////////////////////
                string name = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
                this.Text = name + " - NodePad";
                ////////////////////////////////////////////////////////////

                SaveFile.WriteLine(richTextBox1.Text);
                SaveFile.Close();
            }
        }

        //открытие файла
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открытие диалога
            openFileDialog1.ShowDialog();
            //считывание текста из файла
            System.IO.StreamReader OpenFile = new System.IO.StreamReader(openFileDialog1.FileName);
            //показ текста на форме
            richTextBox1.Text = OpenFile.ReadToEnd();
            OpenFile.Close();
        }

        //отмена действия
        private void undoFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        //печать документа
        private void printFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();
            printDialog1.AllowSomePages = true;

            // Show и help кнопки
            printDialog1.ShowHelp = true;

            printDialog1.Document = docToPrint;

            DialogResult result = printDialog1.ShowDialog();

            // Если нажата кнопка ОК
            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }

        //предварительный просмотр
        private void printpreviewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument prntDoc = new System.Drawing.Printing.PrintDocument();

            //Объявление preview как new PrintPreviewDialog
            PrintPreviewDialog preview = new PrintPreviewDialog();
            //Declare prntDoc_PrintPage as a new EventHandler for prntDoc's Print Page
            //prntDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printFileToolStripMenuItem_Click);
            //Set the PrintPreview's Document equal to prntDoc
            preview.Document = prntDoc;
            //Показ диалога
            if (preview.ShowDialog(this) == DialogResult.OK)
            {
                //Generate the PrintPreview
                prntDoc.Print();
            }
        }

        //Измение цвета
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = richTextBox1.SelectionColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = MyDialog.Color;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {


            // Initialize the dialog's PrinterSettings property to hold user// defined printer settings.
            pageSetupDialog1.PageSettings =
                new System.Drawing.Printing.PageSettings();

            // Initialize dialog's PrinterSettings property to hold user// set printer settings.
            pageSetupDialog1.PrinterSettings =
                new System.Drawing.Printing.PrinterSettings();

            //Do not show the network in the printer dialog.
            pageSetupDialog1.ShowNetwork = false;

            //Show the dialog storing the result.
            DialogResult result = pageSetupDialog1.ShowDialog();

            // If the result is OK, display selected settings in// ListBox1. These values can be used when printing the// document.
            if (result == DialogResult.OK)
            {
                object[] results = new object[]
                                       {
                                           pageSetupDialog1.PageSettings.Margins,
                                           pageSetupDialog1.PageSettings.PaperSize,
                                           pageSetupDialog1.PageSettings.Landscape,
                                           pageSetupDialog1.PrinterSettings.PrinterName,
                                           pageSetupDialog1.PrinterSettings.PrintRange
                                       };
                //ListBox1.Items.AddRange(results);  
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////      
        //Форматирование шрифтов
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the dialog.
            DialogResult result = fontDialog1.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fontDialog1.Font;
                // Set TextBox properties.
                // this.richTextBox1.Text = string.Format("Font is: {0}", font.Name);
                this.richTextBox1.SelectionFont = font;
            }
        }

        //HELP
        private void helpPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "helpfile.chm", HelpNavigator.TopicId, "1234");           
            //System.Diagnostics.Process.Start("http://en.wikipedia.org/wiki/Help");
            Help.ShowHelp(this, "faq.chm", "index0.html");
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            //открытие диалога
            openFileDialog1.ShowDialog();
            //считывание текста из файла
            System.IO.StreamReader OpenFile = new System.IO.StreamReader(openFileDialog1.FileName);
            //показ текста на форме
            richTextBox1.Text = OpenFile.ReadToEnd();
            OpenFile.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(openFileDialog1.FileName);
            //запись текста в файл
            SaveFile.WriteLine(richTextBox1.Text);
            SaveFile.Close();
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();
            printDialog1.AllowSomePages = true;
            printDialog1.ShowHelp = true;
            printDialog1.Document = docToPrint;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument prntDoc = new System.Drawing.Printing.PrintDocument();

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = prntDoc;
            if (preview.ShowDialog(this) == DialogResult.OK)
            {
                prntDoc.Print();
            }
        }


        private void LeftJustifyButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void CenterJustifyButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        //Обработка "жирный", "италик" и "подчеркнутый"
        private void BoldStyleButton_Click(object sender, EventArgs e)
        {
            if (bold==false)
            {
                if (italic == true&&underlined==false)
                fontStile = FontStyle.Bold|FontStyle.Italic;
                else if (italic == false && underlined == true)
                    fontStile = FontStyle.Bold | FontStyle.Underline;
                else if (italic == true && underlined == true)
                    fontStile = FontStyle.Bold | FontStyle.Italic|FontStyle.Underline;
                else
                    fontStile = FontStyle.Bold;

                BoldStyleButton.BackColor = Color.DimGray;
                bold = true;
            }
            else
            {
                if (italic == true && underlined == false)
                    fontStile = FontStyle.Italic;
                else if (italic == false && underlined == true)
                    fontStile = FontStyle.Underline;
                else if (italic == true && underlined == true)
                    fontStile = FontStyle.Italic | FontStyle.Underline;
                else
                    fontStile = FontStyle.Regular;

                BoldStyleButton.BackColor = Color.FromArgb(240, 240, 240);
                bold = false;
            }
            richTextBox1.SelectionFont = new Font(fontFamily, size, fontStile);

        }

        private void ItalicStyleButton_Click(object sender, EventArgs e)
        {
            if (italic==false)
            {
                if (bold == true && underlined == false)
                    fontStile = FontStyle.Bold | FontStyle.Italic;
                else if (bold == false && underlined == true)
                    fontStile = FontStyle.Underline | FontStyle.Italic;
                else if (bold == true && underlined == true)
                    fontStile = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;
                else
                    fontStile = FontStyle.Italic;

                ItalicStyleButton.BackColor = Color.DimGray;
                italic = true;
            }
            else
            {
                if (bold == true && underlined == false)
                    fontStile = FontStyle.Bold;
                else if (bold == false && underlined == true)
                    fontStile = FontStyle.Underline;
                else if (bold == true && underlined == true)
                    fontStile = FontStyle.Bold | FontStyle.Underline;
                else
                    fontStile = FontStyle.Regular;

                ItalicStyleButton.BackColor = Color.FromArgb(240, 240, 240);
                italic = false;
            }
            richTextBox1.SelectionFont = new Font(fontFamily, size, fontStile);

        }

        private void UnderlinedStyleButton_Click(object sender, EventArgs e)
        {
            if (underlined==false)
            {
                if (bold == true && italic == false)
                    fontStile = FontStyle.Bold | FontStyle.Underline;
                else if (bold == false && italic == true)
                    fontStile = FontStyle.Italic | FontStyle.Underline;
                else if (bold == true && italic == true)
                    fontStile = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;
                else
                    fontStile = FontStyle.Underline;

                UnderlinedStyleButton.BackColor = Color.DimGray;
                underlined = true;
            }
            else
            {
                if (bold == true && italic == false)
                    fontStile = FontStyle.Bold;
                else if (bold == false && italic == true)
                    fontStile = FontStyle.Italic;
                else if (bold == true && italic == true)
                    fontStile = FontStyle.Bold | FontStyle.Italic;
                else
                    fontStile = FontStyle.Regular;

                UnderlinedStyleButton.BackColor = Color.FromArgb(240, 240, 240);
                underlined = false;
            }

            richTextBox1.SelectionFont = new Font(fontFamily, size, fontStile);

        }

        //Обработка событий в комбобоксах
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = System.Convert.ToInt32(ComboBox2.Text);
            richTextBox1.SelectionFont = new Font(fontFamily, size, fontStile);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontFamily = ComboBox1.Text;
            richTextBox1.SelectionFont = new Font(fontFamily, size, fontStile);
        }

        /// <summary>
        // Для отображения сведений в статус бар! НАЧАЛО...
        /// </summary>
        /// 

        int index, line, col, vsegoSimvolov;

        private static int EM_LINEINDEX = 0xbb;
        [DllImport("user32.dll")]
        extern static int SendMessage(IntPtr hwnd, int message, int wparam, int lparam);



        private void UpdateCaretPos()
        {
            index = richTextBox1.SelectionStart;
            line = richTextBox1.GetLineFromCharIndex(index);
            col = index - SendMessage(richTextBox1.Handle, EM_LINEINDEX, -1, 0);
            vsegoSimvolov = richTextBox1.Text.Length;
            toolStripStatusLabel1.Text = "Строка - " + (line + 1) + " Столбец - " + col + " Всего символов: " + vsegoSimvolov;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateCaretPos();
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateCaretPos();
        }

        private void toolStripButtonLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString();
            ofd.Filter = "jpg files|*.jpg";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.sPathToPicture = ofd.FileName.ToString();
                //MessageBox.Show("sPathToPicture - " + sPathToPicture);
                Image img = Image.FromFile(sPathToPicture);
                Clipboard.SetImage(img);

                richTextBox1.SelectionStart = 0;
                richTextBox1.Paste();

                Clipboard.Clear();
            }
        }

        /// <summary>
        // Для отображения сведений в статус бар! ...КОНЕЦ
        /// </summary>
        /// 

        /// <summary>
        // Для поиска НАЧАЛО...
        /// </summary>
        /// 
        SearchForm Sf = new SearchForm();

        private void Search()
        {
            iNextSearchPoint = 0;
            Sf.ShowDialog();

            if (Sf.DialogResult == DialogResult.OK)
            {
                if (richTextBox1.Text.IndexOf(Sf.GetSearchString()) == -1)
                {
                    MessageBox.Show("Нет тут такого!");
                }
                else
                {
                    richTextBox1.SelectionStart = richTextBox1.Text.IndexOf(Sf.GetSearchString());
                    richTextBox1.SelectionLength = Sf.GetSearchString().Length;
                    iNextSearchPoint += (richTextBox1.SelectionStart + Sf.GetSearchString().Length + 1);
                }
            }
        }

        private void SearchAgain()
        {
            if (Sf.GetSearchString().Length <= 0)
            {
                Search();
            }
            else
            {
                if (richTextBox1.Text.IndexOf(Sf.GetSearchString()) == -1)
                {
                    MessageBox.Show("Нет тут такого!");
                }
                else
                {
                    try
                    {
                        richTextBox1.SelectionStart = richTextBox1.Text.IndexOf(Sf.GetSearchString(), iNextSearchPoint);
                    }
                    catch (SystemException se)
                    {
                        if (se.Data.ToString() == "System.Collections.ListDictionaryInternal")
                            MessageBox.Show("Достигнут конец поиска");
                        else
                            MessageBox.Show(se.Message.ToString());
                    }
                    richTextBox1.SelectionLength = Sf.GetSearchString().Length;
                    iNextSearchPoint += (richTextBox1.SelectionStart + Sf.GetSearchString().Length + 1);
                }
            }
        }

        private void toolStripButtonSearch_Click_1(object sender, EventArgs e)
        {
            Search();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                Search();
            }

            if (e.KeyCode == Keys.F3)
                SearchAgain();

            if (e.Control && e.KeyCode == Keys.R)
            {
                Replace();
            }

            int posY = Cursor.Position.Y;
            int pozX = Cursor.Position.X;

            UpdateCaretPos();
        }



        /// <summary>
        // Для поиска ...КОНЕЦ
        /// </summary>
        /// 

        /// <summary>
        // Для замены НАЧАЛО...
        /// </summary>
        /// 
        ReplaceForm Rf = new ReplaceForm();

        string sReplaceOldString = "";
        string sReplaceNewString = "";

        private bool Search(string s)
        {
            if (richTextBox1.Text.IndexOf(s) == -1)
            {
                MessageBox.Show("Нет тут такого!");
                return false;
            }
            else
            {
                richTextBox1.SelectionStart = richTextBox1.Text.IndexOf(s);
                richTextBox1.SelectionLength = s.Length;
                iNextSearchPoint += (richTextBox1.SelectionStart + s.Length + 1);
                return true;
            }

        }

        private void Replace()
        {
            Rf.ShowDialog();

            if (Rf.DialogResult == DialogResult.OK)
            {
                if (Rf.GetOldString().Length <= 0)
                    MessageBox.Show("Введите строку что менять!");
                else
                    if (Rf.GetNewString().Length <= 0)
                        MessageBox.Show("Введите строку на что менять!");
                    else
                    {
                        sReplaceOldString = Rf.GetOldString();
                        sReplaceNewString = Rf.GetNewString();

                        if (ReplaceForm.GetbReplaceAll() == false)
                        {


                            if (Search(sReplaceOldString))
                            {
                                Clipboard.SetText(sReplaceNewString);
                                richTextBox1.Paste();
                                ++iReplacesCount;
                            }
                        }
                        else
                            if (ReplaceForm.GetbReplaceAll() == true)
                            {
                                do
                                {
                                    if (Search(sReplaceOldString))
                                    {
                                        Clipboard.SetText(sReplaceNewString);
                                        richTextBox1.Paste();
                                        ++iReplacesCount;
                                    }
                                } while (iNextSearchPoint < richTextBox1.Text.Length);

                            } MessageBox.Show("Всего " + iReplacesCount + " замен.");
                    }
                //создать перегруженный метод private int Saerch(string s) без диалога с поиском строки и возращающим структуру 
                // int SearchResult
                //{
                //    int Start;
                //    int End;
                //}
                //начало и конец выделения искомого в тексте
            }
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void toolStripButtonReplace_Click_1(object sender, EventArgs e)
        {
            Replace();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sEtalon != richTextBox1.Text)
            {
                //открытие диалого
                //saveFileDialog1.ShowDialog();
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileName = saveFileDialog1.FileName;

                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(saveFileDialog1.FileName);
                    SaveFile.WriteLine(richTextBox1.Text);
                    SaveFile.Close();
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "faq.chm", "index0.html");
        }

        private void toolStripButtonDate_Click_1(object sender, EventArgs e)
        {
            this.richTextBox1.Text = this.richTextBox1.Text + DateTime.Now.Date.ToString() + DateTime.Now.TimeOfDay.ToString();
        }

        private void richTextBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                Search();
            }

            if (e.KeyCode == Keys.F3)
                SearchAgain();

            if (e.Control && e.KeyCode == Keys.R)
            {
                Replace();
            }

            int posY = Cursor.Position.Y;
            int pozX = Cursor.Position.X;

            UpdateCaretPos();
        }
        /// <summary>
        // Для замены ...КОНЕЦ
        /// </summary>
        /// 


        /// <summary>
        /// ////////////////////////// Для сохранения при выходе НАЧАЛО...
        /// </summary>
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (sEtalon != richTextBox1.Text)
            {
                //открытие диалого
                //saveFileDialog1.ShowDialog();
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileName = saveFileDialog1.FileName;

                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(saveFileDialog1.FileName);
                    SaveFile.WriteLine(richTextBox1.Text);
                    SaveFile.Close();
                }
            }
        }
        /// <summary>
        /// ////////////////////////// Для сохранения при выходе ...КОНЕЦ
        /// </summary>
        /// 

        /// <summary>
        /// ////////////////////////// Для экстрактора pdf файлов НАЧАЛО...
        /// </summary>
        public void ParsePdf(string fileName)
        {
            string text = "";

            if (!File.Exists(fileName))
                throw new FileNotFoundException(fileName);

            PdfReader reader = new PdfReader(fileName);

            StringBuilder sb = new StringBuilder();

            //ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();

            for (int page = 0; page < reader.NumberOfPages; page++)
            {
                richTextBox1.Text += PdfTextExtractor.GetTextFromPage(reader, page + 1);
            }
            //richTextBox1.Text = text;
        }

        OpenFileDialog ofdParserPDF;

        private void toolStripButtonPDF_Click(object sender, EventArgs e)
        {
            ofdParserPDF = new OpenFileDialog();
            ofdParserPDF.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
            ofdParserPDF.Filter = "pdf files|*.pdf";
            ofdParserPDF.FilterIndex = 1;
            ofdParserPDF.Multiselect = false;

            if (ofdParserPDF.ShowDialog() == DialogResult.OK)
            {
                backgroundWorker1.RunWorkerAsync();
            } 
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length == 0)
                MessageBox.Show("Нет выделенного текста");
            else
                richTextBox1.SelectedText = "";
        }

        int persantage = 0;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ParsePdf(ofdParserPDF.FileName.ToString());
 
        }

        /// <summary>
        /// ////////////////////////// Для экстрактора pdf файлов ...КОНЕЦ
        /// </summary>
        /// 


        /// <summary>
        /// ////////////////////////// Для контекстного меню НАЧАЛО...
        /// </summary>
        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Right")
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void webHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://en.wikipedia.org/wiki/WordPad");
        }      

        /// <summary>
        /// ////////////////////////// Для контекстного меню ...КОНЕЦ
        /// </summary>
        ///

        

    }
}
