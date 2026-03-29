using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace WinFormsApp1
{
    public partial class TaskForm : Form
    {
        public TaskForm(string surname, string clas, decimal count, bool isHard)
        {
            InitializeComponent();

            // включаем прокрутку
            this.AutoScroll = true;

            // информация об ученике
            labelInfo.Text = "Ученик: " + surname + "\nКласс: " + clas;

            int n = (int)count;

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                // текст вопроса
                Label question = new Label();
                question.Text = "Вопрос " + (i + 1);
                question.Location = new Point(20, 50 + i * 35);
                question.AutoSize = true;

                this.Controls.Add(question);

                if (isHard)
                {
                    // сложный вариант — ComboBox
                    ComboBox cb = new ComboBox();
                    cb.Location = new Point(150, 50 + i * 35);

                    cb.Items.Add(rnd.Next(1, 100));
                    cb.Items.Add(rnd.Next(1, 100));
                    cb.Items.Add(rnd.Next(1, 100));

                    this.Controls.Add(cb);
                }
                else
                {
                    // простой вариант — CheckBox
                    CheckBox ch = new CheckBox();
                    ch.Text = "Ответ";
                    ch.Location = new Point(150, 50 + i * 35);

                    this.Controls.Add(ch);
                }
            }
        }
    }
}