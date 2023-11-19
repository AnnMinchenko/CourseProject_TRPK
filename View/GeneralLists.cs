using CourseProject_TRPK.View;
using System;
using System.Windows.Forms;


namespace CourseProject_TRPK
{
    public partial class GeneralLists : Form
    {
        public GeneralLists()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            dataGridViewNotEnough.Columns.Add("RequestID", "RequestID");
            dataGridViewNotEnough.Columns.Add("MedicineID", "MedicineID");
            dataGridViewNotEnough.Columns.Add("Name", "Наименование");
            dataGridViewNotEnough.Columns.Add("ReleaseForm", "Форма выпуска");
            dataGridViewNotEnough.Columns.Add("Amount", "Количество");
            dataGridViewNotEnough.Columns.Add("MeasureUnit", "Ед. изм.");

            dataGridViewEnough.Columns.Add("RequestID", "RequestID");
            dataGridViewEnough.Columns.Add("MedicineID", "MedicineID");
            dataGridViewEnough.Columns.Add("Name", "Наименование");
            dataGridViewEnough.Columns.Add("ReleaseForm", "Форма выпуска");
            dataGridViewEnough.Columns.Add("Amount", "Количество");
            dataGridViewEnough.Columns.Add("MeasureUnit", "Ед. изм.");

            dataGridViewNotEnough.RowHeadersVisible = false;
            dataGridViewEnough.RowHeadersVisible = false;

            Controller.getDataMainForm(dataGridViewEnough, dataGridViewNotEnough);
        }

        private void buttonDepList_Click(object sender, EventArgs e)
        {
            Departments dl = new Departments();
            Hide();
            dl.ShowDialog();
            Show();
        }

     
        private void buttonSend_Click(object sender, EventArgs e)
        {
            Controller.sendEmail(dataGridViewNotEnough);
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            Controller.viewExcel(dataGridViewNotEnough);
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
