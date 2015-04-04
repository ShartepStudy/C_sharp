using System;
using System.Windows.Forms;

namespace MDIExample
{
    public partial class MainMDIContainerForm : Form
    {
        public MainMDIContainerForm()
        {
            InitializeComponent();
        }

        # region Menu File

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            //Create a new instance of the MDI child template form
            ContentForm cf = new ContentForm();

            //Set parent form for the child window 
            cf.MdiParent = this;

            //Display the child window
            cf.Show();
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFileDlg = new OpenFileDialog();
            oFileDlg.CheckFileExists = true;
            oFileDlg.CheckPathExists = true;
            oFileDlg.Title = "Open File - MDI Sample";
            oFileDlg.ValidateNames = true;
            oFileDlg.Filter = "Text files (*.txt)|*.txt";

            if (oFileDlg.ShowDialog() == DialogResult.OK)
            {
                ContentForm cf = new ContentForm() { MdiParent = this };
                cf.OpenFile(oFileDlg.FileName);
                cf.Show();
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            Form cf = this.ActiveMdiChild;
            if (cf != null && cf is ContentForm) ((ContentForm)cf).SaveFile();
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            Form cf = this.ActiveMdiChild;
            if (cf != null) ((ContentForm)cf).SaveFileAs();
        }

        private void tsmiSaveAll_Click(object sender, EventArgs e)
        {
            Form[] forms = this.MdiChildren;
            foreach (ContentForm cf in forms) cf.SaveFile();
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
        }

        private void tsmiCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form fm in this.MdiChildren) fm.Close();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Menu Layout

        // Расположить окна каскадом
        private void tsmiCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        // Упорядочить
        private void tsmiArrangeIcons_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);
        }

        // Окна черепицей сверху вниз
        private void tsmiTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        // Окна черепицей слева направо
        private void tsmiTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        // Минимизировать все окна
        private void tsmiMinimazeAll_Click(object sender, EventArgs e)
        {
            // получаем все дочерние формы 
            Form[] forms = this.MdiChildren;

            // каждое дочернее окно минимизируем
            foreach (Form cf in forms) cf.WindowState = FormWindowState.Minimized;
        }

        // Максимизируем все окна
        private void tsmiMaximizeAll_Click(object sender, EventArgs e)
        {
            Form[] forms = this.MdiChildren;
            foreach (Form cf in forms) cf.WindowState = FormWindowState.Maximized;
        }

        #endregion

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm() { MdiParent = this };
            aboutForm.Show();
        }
    }
}
