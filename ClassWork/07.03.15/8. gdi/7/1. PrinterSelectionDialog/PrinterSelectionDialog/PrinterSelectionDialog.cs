//
// PrinterSelectisnDialog.cs
//
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PrinterSelectionDialog
{
    class PrinterSelectionDialog : Form
    {
        ComboBox combo;

        public PrinterSelectionDialog()
        {
            Text = "Select Printer";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;
            //ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
 
            Label label = new Label();
            label.Parent = this;
            label.Text = "Printer;";
            label.Location = new Point(8, 12);
            label.Size = new Size(40, 12);

            combo = new ComboBox();
            combo.Parent = this;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.Location = new Point(48, 8);
            combo.Size = new Size(190, 8);

            // Добавить установленные принтеры в раскрывающийся список.

            foreach (string str in PrinterSettings.InstalledPrinters)
                combo.Items.Add(str);

            // Microsoft document writer is a virtual printer. It "prints" something to a file,
            // which you can then right click on and select "print" on in windows as many times
            // as you need to in the future.

            Button btn = new Button();
            btn.Parent = this;
            btn.Text = "OK";
            btn.Location = new Point(48, 32);
            btn.Size = new Size(40, 22);
            btn.DialogResult = DialogResult.OK;
            AcceptButton = btn;

            Button btn2 = new Button();
            btn2.Parent = this;
            btn2.Text = "Cancel";
            btn2.Location = new Point(90, 32);
            btn2.Size = new Size(60, 22);
            btn2.DialogResult = DialogResult.Cancel;

            CancelButton = btn2;

            ClientSize = new Size(250, 60);
        }

        public string PrinterName
        {
            set { combo.SelectedItem = value; }
            get { return (string)combo.SelectedItem; }
        }
    }
}