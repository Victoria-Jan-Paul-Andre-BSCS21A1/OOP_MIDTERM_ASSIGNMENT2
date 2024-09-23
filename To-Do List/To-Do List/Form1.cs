using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form1 : Form
    {

        DataTable table = new DataTable("table");
        DoneTasks doneTasks = new DoneTasks();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputTask.Text))
            {
                MessageBox.Show("Wag kang tamad, maglagay ka!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                table.Rows.Add(inputTask.Text);
                inputTask.Text = string.Empty; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("To Do", Type.GetType("System.String"));
            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                if (MessageBox.Show("Do you want to mark the task done?", "Prompt", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow rows = dataGridView1.Rows[e.RowIndex];
                    object[] dataRows = new object[rows.Cells.Count + 1]; 

                    for (int i = 0; i < rows.Cells.Count; i++)
                    {
                        dataRows[i] = rows.Cells[i].Value;
                    }

                    dataRows[rows.Cells.Count] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    doneTasks.AddRowToDataGridView(dataRows);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }

        }

        private void dataGridView1_CancelRowEdit(object sender, QuestionEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            doneTasks.Show();

        }
    }
}
