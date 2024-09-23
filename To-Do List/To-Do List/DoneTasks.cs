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
    public partial class DoneTasks : Form
    {


        DataTable table2 = new DataTable("table2");
        public DoneTasks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void AddRowToDataGridView(object[] dataRows)
        {
            dataGridView2.Rows.Add(dataRows);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoneTasks_Load(object sender, EventArgs e)
        {
            
        }
    }
}
