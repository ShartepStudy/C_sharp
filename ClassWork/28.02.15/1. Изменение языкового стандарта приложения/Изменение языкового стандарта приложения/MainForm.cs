using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsForms
{
    internal partial class MainForm :
        Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FillListBoxes()
        {
            var cultureName =  m_comboBox.SelectedItem.ToString();

            // Строка, передаваемая в конструктор, представляет собой идентификатор культуры (код 
            // языка + код региона/страны).
            var cultureInfo = new CultureInfo(cultureName);

            // CultureInfo служит для предоставления сведений об определенном языке и региональных 
            // параметрах. В этих сведениях содержатся имена языков и региональных параметров, 
            // система языка, используемый календарь и форматы дат.

            // Культуры, в которых указан только код языка, называются нейтральными (neutral) или 
            // только языковыми  (language-only), а культуры, в которых используется код страны, 
            // называются конкретными (specific). ѕри локализации программ важно учитывать тип 
            // культуры. Например, для вывода текстовых сообщений достаточно языка культуры. Но, 
            // если приложение будет оперировать символами валют, датами и т.п., то необходимо в 
            // этом случае использовать конкретную культуру. 

            // Определяет способ форматирования и отображения значений DateTime, зависящих от языка 
            // и региональных параметров.
            var formatInfo = new DateTimeFormatInfo();

            // Определяет формат отображения даты и времени, соответствующий языку и региональным 
            // параметрам.
            formatInfo = cultureInfo.DateTimeFormat;

            m_listBoxMonth.Items.Clear();

            for (var i = 1; i <= 12; ++i)
            {
                var dt = new DateTime(2000, i, 1);

                m_listBoxMonth.Items.Add(dt.ToString("MMMM", cultureInfo));
            }

            m_listBoxWeek.Items.Clear();

            for (var i = DayOfWeek.Sunday; i <= DayOfWeek.Saturday; ++i)
            {
                m_listBoxWeek.Items.Add(formatInfo.GetDayName(i));
            }
        }

        private void OnLoad(Object sender, EventArgs arguments)
        {
            m_comboBox.Items.Add("ru-RU");
            m_comboBox.Items.Add("en-US");
            m_comboBox.Items.Add("de-DE");
            m_comboBox.Items.Add("fr-FR");
            m_comboBox.Items.Add("uk-UA");
            m_comboBox.Items.Add("fi-FI");
            m_comboBox.Items.Add("ja-JP");

            m_comboBox.SelectedIndex = 0;
        }

        private void OnSelectedValueChanged(Object sender, EventArgs arguments)
        {
            FillListBoxes();   
        }
    }
}