using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Exam
{
    public partial class Marshirut : Form
    {
        public static bool session;
        public Marshirut(bool isslogin)
        {
            InitializeComponent();
            session = isslogin;
        }

        private void routeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.routeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marshirutDataSet);

        }

        private void Marshirut_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marshirutDataSet.Route". При необходимости она может быть перемещена или удалена.
            this.routeTableAdapter.Fill(this.marshirutDataSet.Route);

            if (session)
            {
                groupBox3.Visible = true;
            }
            else
            {
                this.Size = new Size(763, 508);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            routeDataGridView.Sort(routeDataGridView.Columns[3], ListSortDirection.Descending);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            routeDataGridView.Sort(routeDataGridView.Columns[3], ListSortDirection.Ascending);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string seach;
            seach = textBox1.Text;
            routeDataGridView.ClearSelection();
            foreach (DataGridViewRow row in routeDataGridView.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == seach)
                {
                    row.Selected = true;

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(Type.Missing);


            int columnIndex = 1;

            for (int i = 0; i < routeDataGridView.Columns.Count; i++)
            {
                if (routeDataGridView.Columns[i].Visible)
                {
                    excel.Cells[1, columnIndex] = routeDataGridView.Columns[i].HeaderText;
                    columnIndex++;
                }
            }

            for (int i = 0; i < routeDataGridView.Rows.Count; i++)
            {
                columnIndex = 1;
                for (int j = 0; j < routeDataGridView.Columns.Count; j++)
                {
                    if (routeDataGridView.Columns[j].Visible)
                    {
                        if (routeDataGridView.Rows[i].Cells[j].Value != null)
                        {
                            excel.Cells[i + 2, columnIndex] = routeDataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            excel.Cells[i + 2, columnIndex] = "";
                        }
                        columnIndex++;
                    }
                }
            }

            excel.Columns.AutoFit();
            excel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addroute addroute = new addroute(session);
           
            addroute.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите безвозвратно удалить выбранную строчку?", "Удаление!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (routeDataGridView.SelectedRows.Count > 0)
                {
                    int index = routeDataGridView.SelectedRows[0].Index;
                    routeDataGridView.Rows.RemoveAt(index);
                }
            }
            else
            {
                return;
            }

            this.Validate();
            this.routeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marshirutDataSet);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            editroute editroute = new editroute();
            
            editroute.Show();
        }
    }
}
