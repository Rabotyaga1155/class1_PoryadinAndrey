using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Work
{
    public partial class Student_work : Form
    {
        public Student_work()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Tel tel = new Tel();
                tel.days = Convert.ToInt32(textBox2.Text);
                tel.time = Convert.ToDouble(textBox3.Text);
                if (tel.Day(tel.days))
                {
                    if (tel.time > 0)
                    {
                        double money = tel.money();
                        tel.prices(tel.time);
                        MessageBox.Show(string.Format($"День недели: {tel.days} \n Время разговора: {tel.time} \n Стоимость минуты: {money} \n Цена за разговор: {tel.money()}"));
                    }
                    else MessageBox.Show("Введенно отрицательное значение времени!", "Сообщение", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Введен некорректный день недели", "Сообщение", MessageBoxButtons.OK);
            }
            catch { MessageBox.Show("Ошибка при вводе данных", "Сообщение", MessageBoxButtons.OK); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Two x = new Two();
            x.kv();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
