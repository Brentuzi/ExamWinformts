using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Auth : Form

    {
        private bool islogin;
        public Auth(bool sessionauth)
        {
            InitializeComponent();
            islogin = sessionauth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            if (login == "admin" && password == "admin")
            {
                islogin = true;
                MessageBox.Show($"Успешная авторизация, {login}", "Информация", MessageBoxButtons.OK);
                Form1 form1 = new Form1(islogin);
                this.Close();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Введенные данные не верны!", "Ошибка авторизации", MessageBoxButtons.OK);
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            if (islogin)
            {
                MessageBox.Show("Вы уже авторизованы!", "Информация", MessageBoxButtons.OK);
                Form1 form1 = new Form1(islogin);
                this.Close();
                form1.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            islogin = false;
            Form1 form1 = new Form1(islogin);
            this.Close();
            form1.Show();
        }
    }
}
