using System;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // если не число и не управляющий символ
            if(!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                // Если не запятая и если есть запятая в тексте
                if (!(e.KeyChar.ToString() == ",") && (textBox1.Text.IndexOf(",") == -1))
                    // Символ не обрабатывается
                    e.Handled = true;
            } 
        }

        private void Button2_Click(object sender, EventArgs e) 
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e) 
        {
            double k; //Курс (отношение рубля к доллару)
            double usd; // Цена в долларах
            double rub; // Цена в рублях

            label4.Text = "";

            try
            {
                // исходные данные
                usd = System.Convert.ToDouble(textBox1.Text);
                k = System.Convert.ToDouble(textBox2.Text);

                // пересчёт

                rub = usd * k;

                // вывод результата

                label4.Text = usd.ToString("N") + "USD =  " + rub.ToString("C");
            }
            catch
            {
                // ловим исключение

                if((textBox1.Text == "")||(textBox2.Text == ""))
                {
                    MessageBox.Show("Ошибка исходных данных. \n" + "Необходимо ввести данные в оба поля. ", "Конвертер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ошибка исходных данных. \n" + "Неверный формат данных в одном из полей. ", "Конвертер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ЗавершитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Автор приложения Конвертер валют:  . \n Дата релиза: 20.06.2021 г.", "Внимание!!!");
        }
    }
}
