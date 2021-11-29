using System;

namespace Form_Z01
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                double V = Convert.ToDouble(textBoxV.Text);
                double result = Math.Pow(V, 1 / 3.0);
                textResult.Text = Convert.ToString(result);
            }
            catch (Exception)
            {
                textResult.Text = "Введите корректные данные!";
            }
        }
    }
}
