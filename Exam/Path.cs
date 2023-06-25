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
    public partial class Path : Form
    {
        public bool session;
        public Path(bool islogin)
        {
            InitializeComponent();
            session = islogin;
        }

        private void pathBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pathBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marshirutDataSet);

        }

        private void Path_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marshirutDataSet.Path". При необходимости она может быть перемещена или удалена.
            this.pathTableAdapter.Fill(this.marshirutDataSet.Path);
            if (session)
            {
                groupBox3.Visible = true;
            }
            else
            {
                this.Size = new Size(349, 364);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start_PointTextBox.ReadOnly = false;
            end_PointTextBox.ReadOnly = false;
            distanceNumericUpDown.Enabled = true;
            bindingNavigatorAddNewItem.Visible = true;
            bindingNavigatorAddNewItem.PerformClick();
            bindingNavigatorAddNewItem.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pathBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marshirutDataSet);
            start_PointTextBox.ReadOnly = false;
            end_PointTextBox.ReadOnly = false;
            distanceNumericUpDown.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            start_PointTextBox.ReadOnly = false;
            end_PointTextBox.ReadOnly = false;
            distanceNumericUpDown.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите что хотите внести изменения?", "Редактирование!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                start_PointTextBox.ReadOnly = true;
                end_PointTextBox.ReadOnly = true;
                distanceNumericUpDown.Enabled = false;
                this.Validate();
                this.pathBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.marshirutDataSet);
                this.Validate();
                this.pathBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.marshirutDataSet);
                MessageBox.Show("Успешно!");

            }
        }
    }
}
