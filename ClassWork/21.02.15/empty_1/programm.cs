using System.Windows.Forms; // need reference!

// пространство System.Windows.Forms содержит набор классов, отвечающих в .Net Framework за создание графического интерфейса пользователя.
// Все типы этого пространства (классы, интерфейсы, делегаты, структуры) можно разделить на следующие категории:
// 1) Базовая инфраструктура - это типы данных, представляющие базовые операции программы. Например, Forms и Application;
// 2) Элементы управления - типы, которые применяются для создания графических пользовательских интерфейсов.
// Например, CheckBox, TextBox, Button, RadioButton. Все эти типы являются производными от класса Control;
// 3) Компоненты - типы, которые не порождены от класса Control, НО все-таки могут предоставлять визуальные возможности программы WindowsForms.
// Есть компоненты, которые не имеют визуального отображения, например, таймер;
// 4) Окна стандартных диалогов. В WinForms имеется несколько типов, предоставляющих работу со стандартными диалоговыми окнами. Например, OpenFileDialog.

// visual c# - windows - empty project
// add class file
// add references System & System.Windows.Forms!
// project properties - app type - windows application

namespace HelloWinFormsWorld
{
    class FirstWinFormApp
    {
        public static void Main()
        {
            // создание объекта класса формы
            var frm = new Form {Text = "First Windows Forms application"};


            // задаём заголовок формы

            // отображаем форму на экран пользователю 
            // для этого мы используем метод для отображения модальных диалогов
            frm.ShowDialog();
        }
    }
}