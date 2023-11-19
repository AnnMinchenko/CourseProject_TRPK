using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_TRPK
{
    public partial class Departments : Form
    {

        public Departments()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns.Add("Name", "Наименование");

            Controller.getDataDep(dataGridView1);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            SpecialLists sl = new SpecialLists(cell.Value.ToString());
            Hide();
            sl.ShowDialog();
        }

    }
}
