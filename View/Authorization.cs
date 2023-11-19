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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            var role = Controller.Enter(textBoxLogin.Text, textBoxPassword.Text);

            if (role == "")
               MessageBox.Show("Ошибка", "Неверный логин или пароль", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            else if (role == "Больница")
            {
                GeneralLists gl = new GeneralLists();
                this.Hide();
                gl.ShowDialog();
                this.Close();

            }

            else 
            {
                Confirmation cnf = new Confirmation(role);
                this.Hide();
                cnf.ShowDialog();
                this.Close();

            }
        }
    }
}
