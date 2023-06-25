using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        public static bool session = false;
        public Form1(bool islogin)
        {
            InitializeComponent();
            session = islogin;
        }
        public Form1()
        {
            InitializeComponent();
           
        }

        private void маршрутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marshirut  q1 = new Marshirut(session);
            q1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (session)
            {
                
                label2.Text = "Авторизованы как ADMIN";
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth(session);
            this.Hide();
            auth.ShowDialog();
        }

        private void путиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Path path = new Path(session);
           
            path.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contacts  q1 = new contacts();
            q1.Show();
        }
    }
}
