using System;
using System.Windows.Forms;

namespace CourseProject_TRPK
{
    public partial class SpecialLists : Form
    {

        public SpecialLists(string dep)
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

        private void buttonToDeps_Click(object sender, EventArgs e)
        {
            Departments dl = new Departments();
            Hide();
            dl.ShowDialog();
        }

        private void buttonToMain_Click(object sender, EventArgs e)
        {
            GeneralLists f1 = new GeneralLists();
            Hide(); 
            f1.ShowDialog();
        }

    }
}
