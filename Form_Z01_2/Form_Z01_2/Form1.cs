using System;
using System.Windows.Forms;

namespace Form_Z01_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxNum.Text);

                if (n.ToString().Length == 2)
                {
                    int sum = 0;
                    while (n > 0)
                    {
                        sum = sum + n % 10;
                        n = n / 10;
                    }

                    if (sum % 2 != 0)
                    {
                        textBoxResult.Text = "Сумма цифр не четная";
                    }
                    else
                    {
                        textBoxResult.Text = "Сумма цифр четная";
                    }
                }
                else
                {
                    textBoxResult.Text = "Введите двузначное число!";
                }
            } 
            catch(Exception)
            {
                textBoxResult.Text = "Некорректный ввод данных!";
            }
        }
    }
}
