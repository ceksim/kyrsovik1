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
    public partial class Form1 : Form // Объявление класса Form1, который наследуется от Form (базовый класс для окон в Windows Forms)
    {
        public Form1() // Конструктор класса Form1
        {
            InitializeComponent(); // Инициализация компонентов формы (элементы управления, созданные в дизайнере)
            IsMdiContainer = true; // Установка свойства IsMdiContainer в true, делая форму контейнером для MDI-окон (многодокументный интерфейс)
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "New" (Создать)
        {
            ChildForm childForm = new ChildForm(); // Создание нового экземпляра дочерней формы (ChildForm)
            childForm.MdiParent = this; // Установка родительского MDI-контейнера для дочерней формы (текущая форма Form1)
            childForm.Text = "Новый файл"; // Установка заголовка окна дочерней формы
            childForm.Show(); // Отображение дочерней формы
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Open" (Открыть)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK) // Отображение диалогового окна открытия файла и проверка, что пользователь нажал "OK"
            {
                try // Блок try-catch для обработки возможных исключений
                {
                    ChildForm childForm = new ChildForm(); // Создание нового экземпляра дочерней формы (ChildForm)
                    childForm.MdiParent = this; // Установка родительского MDI-контейнера для дочерней формы (текущая форма Form1)
                    childForm.RichTextBox1.LoadFile(OpenFileDialog1.FileName); // Загрузка содержимого файла в RichTextBox дочерней формы
                    childForm.Text = OpenFileDialog1.FileName; // Установка заголовка окна дочерней формы равным имени файла
                    childForm.currentFilePath = OpenFileDialog1.FileName; // Сохранение пути к открытому файлу в дочерней форме
                    childForm.Show(); // Отображение дочерней формы
                }
                catch (Exception ex) // Перехват исключений
                {
                    MessageBox.Show("Ошибка открытия файла: " + ex.Message); // Отображение сообщения об ошибке
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Save" (Сохранить)
        {
            if (ActiveMdiChild is ChildForm childForm) // Проверка, что есть активная дочерняя форма
            {
                if (string.IsNullOrEmpty(childForm.currentFilePath)) // Проверка, был ли файл уже сохранен (есть ли путь к файлу)
                {
                    saveAsToolStripMenuItem_Click(sender, e); // Если файл не был сохранен, вызывается метод "Save As"
                }
                else // Если файл уже был сохранен
                {
                    try // Блок try-catch для обработки возможных исключений
                    {
                        childForm.RichTextBox1.SaveFile(childForm.currentFilePath); // Сохранение содержимого RichTextBox в файл
                    }
                    catch (Exception ex) // Перехват исключений
                    {
                        MessageBox.Show("Ошибка сохранения файла: " + ex.Message); // Отображение сообщения об ошибке
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Save As" (Сохранить как)
        {
            if (ActiveMdiChild is ChildForm childForm) // Проверка, что есть активная дочерняя форма
            {
                if (SaveFileDialog1.ShowDialog() == DialogResult.OK) // Отображение диалогового окна сохранения файла и проверка, что пользователь нажал "OK"
                {
                    try // Блок try-catch для обработки возможных исключений
                    {
                        childForm.RichTextBox1.SaveFile(SaveFileDialog1.FileName); // Сохранение содержимого RichTextBox в файл
                        childForm.currentFilePath = SaveFileDialog1.FileName; // Сохранение пути к файлу в дочерней форме
                        childForm.Text = System.IO.Path.GetFileName(SaveFileDialog1.FileName); // Установка заголовка окна дочерней формы равным имени файла
                    }
                    catch (Exception ex) // Перехват исключений
                    {
                        MessageBox.Show("Ошибка сохранения файла: " + ex.Message); // Отображение сообщения об ошибке
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Exit" (Выход)
        {
            Application.Exit(); // Завершение работы приложения
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Cut" (Вырезать)
        {
            if (ActiveMdiChild is ChildForm childForm) { childForm.RichTextBox1.Cut(); } // Если есть активная дочерняя форма, вызывается метод Cut() для RichTextBox
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Copy" (Копировать)
        {
            if (ActiveMdiChild is ChildForm childForm) { childForm.RichTextBox1.Copy(); } // Если есть активная дочерняя форма, вызывается метод Copy() для RichTextBox
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Paste" (Вставить)
        {
            if (ActiveMdiChild is ChildForm childForm) { childForm.RichTextBox1.Paste(); } // Если есть активная дочерняя форма, вызывается метод Paste() для RichTextBox
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Select All" (Выделить все)
        {
            if (ActiveMdiChild is ChildForm childForm) { childForm.RichTextBox1.SelectAll(); } // Если есть активная дочерняя форма, вызывается метод SelectAll() для RichTextBox
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Font" (Шрифт)
        {
            if (ActiveMdiChild is ChildForm childForm) // Проверка, что есть активная дочерняя форма
            {
                FontDialog1.Font = childForm.RichTextBox1.SelectionFont; // Установка текущего шрифта выделенного текста в FontDialog
                if (FontDialog1.ShowDialog() == DialogResult.OK) // Отображение диалогового окна выбора шрифта и проверка, что пользователь нажал "OK"
                {
                    childForm.RichTextBox1.SelectionFont = FontDialog1.Font; // Установка выбранного шрифта для выделенного текста в RichTextBox
                }
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Text Color" (Цвет текста)
        {
            if (ActiveMdiChild is ChildForm childForm) // Проверка, что есть активная дочерняя форма
            {
                ColorDialog1.Color = childForm.RichTextBox1.SelectionColor; // Установка текущего цвета выделенного текста в ColorDialog
                if (ColorDialog1.ShowDialog() == DialogResult.OK) // Отображение диалогового окна выбора цвета и проверка, что пользователь нажал "OK"
                {
                    childForm.RichTextBox1.SelectionColor = ColorDialog1.Color; // Установка выбранного цвета для выделенного текста в RichTextBox
                }
            }
        }

        private void textBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Text Background Color" (Цвет фона текста)
        {
            if (ActiveMdiChild is ChildForm childForm) // Проверка, что есть активная дочерняя форма
            {
                ColorDialog1.Color = childForm.RichTextBox1.SelectionBackColor; // Установка текущего цвета фона выделенного текста в ColorDialog
                if (ColorDialog1.ShowDialog() == DialogResult.OK) // Отображение диалогового окна выбора цвета и проверка, что пользователь нажал "OK"
                {
                    childForm.RichTextBox1.SelectionBackColor = ColorDialog1.Color; // Установка выбранного цвета фона для выделенного текста в RichTextBox
                }
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события Click для пункта меню "Background Color" (Цвет фона)
        {
            if (ActiveMdiChild is ChildForm childForm) // Проверка, что есть активная дочерняя форма
            {
                ColorDialog1.Color = childForm.BackColor; // Установка текущего цвета фона формы в ColorDialog
                if (ColorDialog1.ShowDialog() == DialogResult.OK) // Отображение диалогового окна выбора цвета и проверка, что пользователь нажал "OK"
                {
                    childForm.BackColor = ColorDialog1.Color; // Установка выбранного цвета фона для формы
                }
            }
        }
    } // Закрытие класса Form1
} // Закрытие пространства имен курсовик
