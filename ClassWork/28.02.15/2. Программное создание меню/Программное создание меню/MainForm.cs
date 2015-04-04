using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms
{
    internal partial class MainForm :
        Form
    {
        Boolean m_aboutEnabled = false;
        Label m_label = new Label();
        MainMenu m_mainMenu = new MainMenu();
        Boolean m_mainMenuEnabled = false;
        MenuItem m_menuItemAbout = null;
        MenuItem m_menuItemEasy = null;
        MenuItem m_menuItemExit = null;
        MenuItem m_menuItemGame = null;
        MenuItem m_menuItemHard = null;
        MenuItem m_menuItemLevel = null;
        MenuItem m_menuItemMedium = null;
        MenuItem m_menuItemStart = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnClickExit(Object sender, EventArgs arguments)
        {
            Close();
        }

        private void OnClickLevel(Object sender, EventArgs arguments)
        {
            var item = sender as MenuItem;

            for (var i = 0; i < item.Parent.MenuItems.Count; ++i)
            {
                item.Parent.MenuItems[i].Checked = false;
            }

            item.Checked = true;

            MessageBox.Show(String.Format("Menu item \"{0}\"", item.Text));
        }

        private void OnClickStart(Object sender, EventArgs arguments)
        {
            MessageBox.Show("Menu item \"Start Game\"");
        }

        private void OnClickToggleAbout(Object sender, EventArgs arguments)
        {
            if (m_aboutEnabled)
            {
                button2.Text = "Disable menu item \"About\"";

                m_menuItemAbout = new MenuItem("About");
                m_menuItemAbout.Select += new EventHandler(OnSelect);

                m_mainMenu.MenuItems.Add(m_menuItemAbout);
            }
            else
            {
                button2.Text = "Enable menu item \"About\"";

                m_mainMenu.MenuItems.Remove(m_menuItemAbout);
            }

            m_aboutEnabled = !m_aboutEnabled;
        }

        private void OnClickToggleMainMenu(Object sender, EventArgs arguments)
        {
            if (m_mainMenuEnabled)
            {
                button1.Text = "Disable main menu";

                Menu = m_mainMenu;
            }
            else
            {
                button1.Text = "Enable main menu";

                Menu = null;
            }

            m_mainMenuEnabled = !m_mainMenuEnabled;
        }

        private void OnLoad(Object sender, EventArgs arguments)
        {
            m_label.BorderStyle = BorderStyle.FixedSingle;
            m_label.Height = 50;
            m_label.Location = new Point(10, 100);
            m_label.Parent = this;
            m_label.Width = 200;

            m_menuItemGame = new MenuItem("Game");
            m_menuItemGame.Select += new EventHandler(OnSelect);

            m_menuItemAbout = new MenuItem("About");
            m_menuItemAbout.Select += new EventHandler(OnSelect);

            m_menuItemStart = new MenuItem("Start Game");
            m_menuItemStart.Click += new EventHandler(OnClickStart);
            m_menuItemStart.Select += new EventHandler(OnSelect);

            m_menuItemLevel = new MenuItem("Level");
            m_menuItemLevel.Select += new EventHandler(OnSelect);

            m_menuItemEasy = new MenuItem("Easy");
            m_menuItemEasy.Checked = true;
            m_menuItemEasy.Click += new EventHandler(OnClickLevel);
            m_menuItemEasy.Select += new EventHandler(OnSelect);

            m_menuItemMedium = new MenuItem("Medium");
            m_menuItemMedium.Click += new EventHandler(OnClickLevel);
            m_menuItemMedium.Select += new EventHandler(OnSelect);

            m_menuItemHard = new MenuItem("Hard");
            m_menuItemHard.Click += new EventHandler(OnClickLevel);
            m_menuItemHard.Select += new EventHandler(OnSelect);

            m_menuItemExit = new MenuItem("Exit");
            m_menuItemExit.Click += new EventHandler(OnClickExit);
            m_menuItemExit.Select += new EventHandler(OnSelect);

            m_menuItemLevel.MenuItems.Add(m_menuItemEasy);
            m_menuItemLevel.MenuItems.Add(m_menuItemMedium);
            m_menuItemLevel.MenuItems.Add(m_menuItemHard);

            m_menuItemGame.MenuItems.Add(m_menuItemStart);
            m_menuItemGame.MenuItems.Add(m_menuItemLevel);
            m_menuItemGame.MenuItems.Add(m_menuItemExit);

            m_mainMenu.MenuItems.Add(m_menuItemGame);
            m_mainMenu.MenuItems.Add(m_menuItemAbout);

            Menu = m_mainMenu;
        }

        private void OnSelect(Object sender, EventArgs arguments)
        {
            var item = sender as MenuItem;

            m_label.Text = item.Text;
        }
    }
}