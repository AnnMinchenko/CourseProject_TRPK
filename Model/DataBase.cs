using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_TRPK
{
    class DataBase
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data source=DESKTOP-LN1UKBQ\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

        public string Enter(string login, string password)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string query = $"select * from Authorize where login='{login}' and password='{password}'";

                SqlCommand command = new SqlCommand(query, getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

            string role = "";
                if (table.Rows.Count == 1)
                    role = table.Rows[0].Field<string>(3);
                    
            return role;
        }


        public void getMedList(string query, DataGridView dgv)
        {
              dgv.Columns["MedicineID"].Visible = false;
              dgv.Columns["RequestID"].Visible = false;
            openConnection();
            SqlCommand command = new SqlCommand(query, getConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgv.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetString(2), reader.GetString(3), reader.GetValue(4), reader.GetString(5));
            }
            reader.Close();
            closeConnection();
        }

        public void getDepList(DataGridView dgv)
        {
            string query = "SELECT name from Departments";
            openConnection();

            SqlCommand command = new SqlCommand(query, getConnection());

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgv.Rows.Add(reader.GetString(0));
            }
            reader.Close();

            closeConnection();
        }

        public void updateInfo(DataGridView dgv)
        {
            openConnection();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                string query = $"UPDATE Requests SET status = 'Выполнено' WHERE id = {dgv.Rows[i].Cells[0].Value} ";
                var command = new SqlCommand(query, getConnection());
                command.ExecuteNonQuery();

                query = $"UPDATE Medicine SET storAmount = storAmount - {dgv.Rows[i].Cells[4].Value} WHERE id = {dgv.Rows[i].Cells[1].Value}";
                command = new SqlCommand(query, getConnection());
                command.ExecuteNonQuery();
            }
            closeConnection();

            MessageBox.Show("Выдача подтверждена", "Успешно", MessageBoxButtons.OK);
        }
    }
}
