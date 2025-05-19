using System; // Подключение пространства имен System (базовые классы .NET)
using System.Collections.Generic; // Подключение пространства имен для работы с коллекциями
using System.ComponentModel; // Подключение пространства имен для работы с компонентами
using System.Data; // Подключение пространства имен для работы с данными
using System.Drawing; // Подключение пространства имен для работы с графикой
using System.Linq; // Подключение пространства имен для LINQ (язык интегрированных запросов)
using System.Text; // Подключение пространства имен для работы с текстом
using System.Threading.Tasks; // Подключение пространства имен для работы с асинхронными операциями
using System.Windows.Forms; // Подключение пространства имен для работы с Windows Forms

namespace курсовик // Пространство имен вашего проекта
{
    public partial class ChildForm : Form // Объявление класса ChildForm, который наследуется от Form (базовый класс для окон в Windows Forms)
    {
        public string currentFilePath { get; set; } = null; // Свойство для хранения пути к текущему файлу (может быть null, если файл не сохранен)

        public ChildForm() // Конструктор класса ChildForm
        {
            InitializeComponent(); // Инициализация компонентов формы (элементы управления, созданные в дизайнере)
            richTextBox1.ContextMenuStrip = contextMenuStrip1; // Привязка контекстного меню (contextMenuStrip1) к элементу RichTextBox
        }

        // ---- Форматирование текста ----
        private void boldButton_Click(object sender, EventArgs e) // Обработчик события Click для кнопки "Bold" (Полужирный)
        {
            Font currentFont = richTextBox1.SelectionFont; // Получение текущего шрифта выделенного текста в RichTextBox
            if (currentFont != null) // Проверка, что шрифт существует
            {
                FontStyle newStyle = currentFont.Style ^ FontStyle.Bold; // Инвертирование стиля "Bold" (если он есть - убираем, если нет - добавляем)
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle); // Установка нового шрифта для выделенного текста
            }
        }

        private void italicButton_Click(object sender, EventArgs e) // Обработчик события Click для кнопки "Italic" (Курсив)
        {
            Font currentFont = richTextBox1.SelectionFont; // Получение текущего шрифта выделенного текста в RichTextBox
            if (currentFont != null) // Проверка, что шрифт существует
            {
                FontStyle newStyle = currentFont.Style ^ FontStyle.Italic; // Инвертирование стиля "Italic" (если он есть - убираем, если нет - добавляем)
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle); // Установка нового шрифта для выделенного текста
            }
        }

        private void underlineButton_Click(object sender, EventArgs e) // Обработчик события Click для кнопки "Underline" (Подчеркнутый)
        {
            Font currentFont = richTextBox1.SelectionFont; // Получение текущего шрифта выделенного текста в RichTextBox
            if (currentFont != null) // Проверка, что шрифт существует
            {
                FontStyle newStyle = currentFont.Style ^ FontStyle.Underline; // Инвертирование стиля "Underline" (если он есть - убираем, если нет - добавляем)
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle); // Установка нового шрифта для выделенного текста
            }
        }

        private void strikeoutButton_Click(object sender, EventArgs e) // Обработчик события Click для кнопки "Strikeout" (Зачеркнутый)
        {
            Font currentFont = richTextBox1.SelectionFont; // Получение текущего шрифта выделенного текста в RichTextBox
            if (currentFont != null) // Проверка, что шрифт существует
            {
                FontStyle newStyle = currentFont.Style ^ FontStyle.Strikeout; // Инвертирование стиля "Strikeout" (если он есть - убираем, если нет - добавляем)
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle); // Установка нового шрифта для выделенного текста
            }
        }

        // ---- Edit Menu and Context Menu ----
        private void cutToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Cut" (Вырезать) и пункта контекстного меню "Cut"
        {
            richTextBox1.Cut(); // Выполнение операции "Вырезать" для RichTextBox
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Copy" (Копировать) и пункта контекстного меню "Copy"
        {
            richTextBox1.Copy(); // Выполнение операции "Копировать" для RichTextBox
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Paste" (Вставить) и пункта контекстного меню "Paste"
        {
            richTextBox1.Paste(); // Выполнение операции "Вставить" для RichTextBox
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Select All" (Выделить все) и пункта контекстного меню "Select All"
        {
            richTextBox1.SelectAll(); // Выделение всего текста в RichTextBox
        }

        // ---- View Menu (Formatting) ----
        private void alignLeftToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Align Left" (Выровнять по левому краю)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left; // Установка выравнивания выделенного текста по левому краю
        }

        private void alignCenterToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Align Center" (Выровнять по центру)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center; // Установка выравнивания выделенного текста по центру
        }

        private void alignRightToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Align Right" (Выровнять по правому краю)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right; // Установка выравнивания выделенного текста по правому краю
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Font" (Шрифт)
        {
            Form1 mainForm = (Form1)this.MdiParent; // Получение ссылки на главную форму (Form1)
            mainForm.FontDialog1.Font = richTextBox1.SelectionFont; // Установка текущего шрифта выделенного текста в FontDialog главной формы
            if (mainForm.FontDialog1.ShowDialog() == DialogResult.OK) // Отображение диалогового окна выбора шрифта главной формы и проверка, что пользователь нажал "OK"
            {
                richTextBox1.SelectionFont = mainForm.FontDialog1.Font; // Установка выбранного шрифта для выделенного текста в RichTextBox
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Text Color" (Цвет текста)
        {
            Form1 mainForm = (Form1)this.MdiParent; // Получение ссылки на главную форму (Form1)
            mainForm.ColorDialog1.Color = richTextBox1.SelectionColor; // Установка текущего цвета выделенного текста в ColorDialog главной формы
            if (mainForm.ColorDialog1.ShowDialog() == DialogResult.OK) // Отображение диалогового окна выбора цвета главной формы и проверка, что пользователь нажал "OK"
            {
                richTextBox1.SelectionColor = mainForm.ColorDialog1.Color; // Установка выбранного цвета для выделенного текста в RichTextBox
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "New" (Создать)
        {
            richTextBox1.Clear(); // Очистка содержимого RichTextBox
            currentFilePath = null; // Сброс пути к текущему файлу
            this.Text = "Новый файл"; // Установка заголовка окна формы
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Open" (Открыть)
        {
            Form1 mainForm = (Form1)this.MdiParent; // Получение ссылки на главную форму (Form1)

            if (mainForm.OpenFileDialog1.ShowDialog() == DialogResult.OK) // Отображение диалогового окна открытия файла главной формы и проверка, что пользователь нажал "OK"
            {
                try // Блок try-catch для обработки возможных исключений
                {
                    richTextBox1.LoadFile(mainForm.OpenFileDialog1.FileName); // Загрузка содержимого файла в RichTextBox
                    currentFilePath = mainForm.OpenFileDialog1.FileName; // Сохранение пути к открытому файлу
                    this.Text = mainForm.OpenFileDialog1.FileName; // Обновление заголовка окна формы
                }
                catch (Exception ex) // Перехват исключений
                {
                    MessageBox.Show("Ошибка открытия файла: " + ex.Message); // Отображение сообщения об ошибке
                }
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Save As" (Сохранить как)
        {
            Form1 mainForm = (Form1)this.MdiParent; // Получение ссылки на главную форму (Form1)

            if (mainForm.SaveFileDialog1.ShowDialog() == DialogResult.OK) // Отображение диалогового окна сохранения файла главной формы и проверка, что пользователь нажал "OK"
            {
                try // Блок try-catch для обработки возможных исключений
                {
                    richTextBox1.SaveFile(mainForm.SaveFileDialog1.FileName); // Сохранение содержимого RichTextBox в файл
                    currentFilePath = mainForm.SaveFileDialog1.FileName; // Сохранение пути к файлу
                    this.Text = mainForm.SaveFileDialog1.FileName; // Обновление заголовка окна формы
                }
                catch (Exception ex) // Перехват исключений
                {
                    MessageBox.Show("Ошибка сохранения файла: " + ex.Message); // Отображение сообщения об ошибке
                }
            }
        }

        private void textBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Text Background Color" (Цвет фона текста)
        {
            Form1 mainForm = (Form1)this.MdiParent; // Получение ссылки на главную форму (Form1)
            mainForm.ColorDialog1.Color = richTextBox1.SelectionBackColor; // Установка текущего цвета фона выделенного текста в ColorDialog главной формы
            if (mainForm.ColorDialog1.ShowDialog() == DialogResult.OK) // Отображение диалогового окна выбора цвета главной формы и проверка, что пользователь нажал "OK"
            {
                richTextBox1.SelectionBackColor = mainForm.ColorDialog1.Color; // Установка выбранного цвета фона для выделенного текста в RichTextBox
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Background Color" (Цвет фона формы)
        {
            Form1 mainForm = (Form1)this.MdiParent; // Получение ссылки на главную форму (Form1)
            mainForm.ColorDialog1.Color = this.BackColor; // Установка текущего цвета фона формы в ColorDialog главной формы
            if (mainForm.ColorDialog1.ShowDialog() == DialogResult.OK) // Отображение диалогового окна выбора цвета главной формы и проверка, что пользователь нажал "OK"
            {
                this.BackColor = mainForm.ColorDialog1.Color; // Установка выбранного цвета фона для формы
            }

        }

        private void contextCutToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта контекстного меню "Cut" (Вырезать)
        {
            richTextBox1.Cut(); // Выполнение операции "Вырезать" для RichTextBox
        }

        private void contextCopyToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта контекстного меню "Copy" (Копировать)
        {
            richTextBox1.Copy(); // Выполнение операции "Копировать" для RichTextBox
        }

        private void contextPasteToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта контекстного меню "Paste" (Вставить)
        {
            richTextBox1.Paste(); // Выполнение операции "Вставить" для RichTextBox
        }

        private void contextSelectAllToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта контекстного меню "Select All" (Выделить все)
        {
            richTextBox1.SelectAll(); // Выделение всего текста в RichTextBox
        }

        private void contextAlignLeftToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта контекстного меню "Align Left" (Выровнять по левому краю)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left; // Установка выравнивания выделенного текста по левому краю
        }

        private void contextAlignCenterToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта контекстного меню "Align Center" (Выровнять по центру)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center; // Установка выравнивания выделенного текста по центру
        }

        private void contextAlignRightToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта контекстного меню "Align Right" (Выровнять по правому краю)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right; // Установка выравнивания выделенного текста по правому краю
        }

        private void contextFontToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта контекстного меню "Font" (Шрифт)
        {
            fontToolStripMenuItem_Click(sender, e); // Вызов обработчика события Click для пункта меню "Font"
        }

        private void contextTextColorToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта контекстного меню "Text Color" (Цвет текста)
        {
            textColorToolStripMenuItem_Click(sender, e); // Вызов обработчика события Click для пункта меню "Text Color"
        }

    } // Закрытие класса ChildForm
} // Закрытие пространства имен курсовик
