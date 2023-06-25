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
    public partial class addroute : Form
    {
        public bool islogin;
        public addroute(bool login)
        {
            InitializeComponent();
            islogin = login;
        }

        private void routeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.routeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marshirutDataSet);

        }

        private void addroute_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marshirutDataSet.Route". При необходимости она может быть перемещена или удалена.
            this.routeTableAdapter.Fill(this.marshirutDataSet.Route);
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.routeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marshirutDataSet);
            MessageBox.Show("Успешно добавили маршрут!", "Успешная операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Marshirut routes = new Marshirut(islogin);
            this.Close();
            routes.Show();
        }
    }
}
