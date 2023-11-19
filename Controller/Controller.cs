using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace CourseProject_TRPK
{
    static class Controller
    {
        static DataBase database = new DataBase();

        public static string Enter(string login, string password)
        {
            return database.Enter(login, password);    
        }

        public static void getDataMainForm(DataGridView dataGridViewEnough, DataGridView dataGridViewNotEnough)
        {
            string query1 = "SELECT Requests.id, Medicine.id, Medicine.name, ReleaseForms.name, amount, ReleaseForms.measureUnit from Requests " +
                "INNER JOIN Medicine ON Medicine.id = Requests.medID " +
                "INNER JOIN ReleaseForms ON ReleaseForms.id = Medicine.rfID " +
                "WHERE Requests.date = '2023-06-07' AND status = 'Ожидает выдачи' " +
                "GROUP BY Medicine.storAmount, Requests.id, Medicine.id, Requests.amount, Medicine.name, ReleaseForms.name, amount, ReleaseForms.measureUnit " +
                "HAVING(Medicine.storAmount >= Requests.amount)";

            string query2 = "SELECT Requests.id, Medicine.id, Medicine.name, ReleaseForms.name, amount, ReleaseForms.measureUnit from Requests " +
                "INNER JOIN Medicine ON Medicine.id = Requests.medID " +
                "INNER JOIN ReleaseForms ON ReleaseForms.id = Medicine.rfID " +
                "WHERE Requests.date = '2023-06-07' AND status = 'Ожидает выдачи' " +
                "GROUP BY Medicine.storAmount, Requests.id, Medicine.id, Requests.amount, Medicine.name, ReleaseForms.name, amount, ReleaseForms.measureUnit " +
                "HAVING(Medicine.storAmount < Requests.amount)";


            database.getMedList(query1, dataGridViewEnough);
            database.getMedList(query2, dataGridViewNotEnough);
        }

        public static void getDataSL(DataGridView dataGridViewEnough, string department)
        {
            string query = "SELECT Requests.id, Medicine.id, Medicine.name, ReleaseForms.name, amount, ReleaseForms.measureUnit from Requests " +
            "INNER JOIN Departments ON Departments.id = Requests.depID " +
            "INNER JOIN Medicine ON Medicine.id = Requests.medID " +
            "INNER JOIN ReleaseForms ON ReleaseForms.id = Medicine.rfID " +
            $"WHERE Requests.date = '2023-06-07' AND status = 'Ожидает выдачи' AND Departments.name = '{department}' " +
            "GROUP BY Medicine.storAmount, Requests.id, Medicine.id, Requests.amount, Medicine.name, ReleaseForms.name, amount, ReleaseForms.measureUnit " +
            "HAVING(Medicine.storAmount >= Requests.amount)";

            database.getMedList(query, dataGridViewEnough);
        }

        public static void getDataDep(DataGridView dataGridView1)
        { 
            database.getDepList(dataGridView1);
        }

        public static void sendEmail(DataGridView dgv)
        {
            try
            {
                string excelfile = @"C:\Users\Аня\Documents\excel.xlsx";

                MailMessage mail = new MailMessage("kusudamanna2@gmail.com", "grozka00@mail.ru", "Лекарства для закупки", $"Лекарства для закупки на {DateTime.Now:yyyy-MM-dd}");
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("kusudamanna2@gmail.com", "cgwuqpwcyvacngls");
                smtp.EnableSsl = true;

                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook = ExcelApp.Workbooks.Open(excelfile);
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet = ExcelWorkBook.Sheets[1];

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 2; j < dgv.ColumnCount; j++)
                    {
                        ExcelApp.Cells[i + 1, j] = dgv.Rows[i].Cells[j].Value;
                    }
                }

                ExcelWorkBook.Close(true);
                ExcelApp.Quit();

                Attachment attachment = new Attachment(excelfile);
                mail.Attachments.Add(attachment);

                smtp.Send(mail);
                MessageBox.Show("Выполнено!");
            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Проверьте соединение и попробуйте еще раз или обратитесь к системному администратору.");
            }
        }

        public static void viewExcel(DataGridView dataGridViewNotEnough)
        {
            try
            {
                Clipboard.Clear();

                dataGridViewNotEnough.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                dataGridViewNotEnough.RowHeadersVisible = false;
                dataGridViewNotEnough.MultiSelect = true;

                dataGridViewNotEnough.SelectAll();
                DataObject dataObj = dataGridViewNotEnough.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
            catch
            {
                MessageBox.Show("Таблица пуста");
            }
        }

        public static void Confirm(DataGridView dataGridViewEnough)
        {
            var res = MessageBox.Show("Вы уверены, что хотите подтвердить выдачу?", "Подверждение", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                database.updateInfo(dataGridViewEnough);
        }
    }
}

