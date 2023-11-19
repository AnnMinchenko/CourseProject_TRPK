using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_TRPK.View
{
    public partial class Confirmation : Form
    {
        public Confirmation(string dep)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Text = dep + " отделение";

            dataGridViewEnough.RowHeadersVisible = false;
            dataGridViewEnough.Columns.Add("RequestID", "RequestID");
            dataGridViewEnough.Columns.Add("MedicineID", "MedicineID");
            dataGridViewEnough.Columns.Add("Name", "Наименование");
            dataGridViewEnough.Columns.Add("ReleaseForm", "Форма выпуска");
            dataGridViewEnough.Columns.Add("Amount", "Количество");
            dataGridViewEnough.Columns.Add("MeasureUnit", "Ед. изм.");
            dataGridViewEnough.Rows.Clear();

            Controller.getDataSL(dataGridViewEnough, dep);
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Controller.Confirm(dataGridViewEnough);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Authorization aut = new Authorization();
            this.Hide();
            aut.ShowDialog();
            this.Close();
        }
    }
}
