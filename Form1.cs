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
    public partial class Form1 : Form
    {
        DataBase database = new DataBase();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ReadSingleRow1(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetValue(1));
        }
        private void ReadSingleRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetValue(1));
        }

        private void buttonDepList_Click(object sender, EventArgs e)
        {
            Departments dl = new Departments();
            Hide();
            dl.ShowDialog();
            Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewEnough.Columns.Add("Name", "Name");
            dataGridViewEnough.Columns.Add("Dose", "Dose");

            dataGridViewNotEnough.Columns.Add("Name", "Name");
            dataGridViewNotEnough.Columns.Add("Dose", "Dose");

            dataGridViewEnough.Rows.Clear();
            dataGridViewNotEnough.Rows.Clear();

            string query1 = "SELECT Name, sum(Prescription.Dosage) as Dose from Prescription " +
"INNER JOIN Medicine ON Medicine.ID = Prescription.MedicineID "+
"INNER JOIN Patient ON Patient.ID = Prescription.PatientID " +
"GROUP BY MedicineID, Name, Medicine.Dosage, Medicine.StorAmount " +
"HAVING((Medicine.Dosage * Medicine.StorAmount) >= sum(Prescription.Dosage))";

            string query2 = "SELECT Name, sum(Prescription.Dosage) as Dose from Prescription " +
"INNER JOIN Medicine ON Medicine.ID = Prescription.MedicineID " +
"INNER JOIN Patient ON Patient.ID = Prescription.PatientID " +
"GROUP BY MedicineID, Name, Medicine.Dosage, Medicine.StorAmount " +
"HAVING((Medicine.Dosage * Medicine.StorAmount) < sum(Prescription.Dosage))";

            database.openConnection();

            SqlCommand command1 = new SqlCommand(query1, database.getConnection());
            SqlCommand command2 = new SqlCommand(query2, database.getConnection());

            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                ReadSingleRow1(dataGridViewEnough, reader1);
            }
            reader1.Close();

            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                ReadSingleRow2(dataGridViewNotEnough, reader2);
            }
            reader2.Close();

            database.closeConnection();
        }
    }
}
