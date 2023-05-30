using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_TRPK
{
    public partial class SpecialLists : Form
    {

        string department;

        public SpecialLists(string dep)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            department = dep;
        }

        private void buttonToDeps_Click(object sender, EventArgs e)
        {
            Departments dl = new Departments();
            Hide();
            dl.ShowDialog();
            Show();
        }

        private void buttonToMain_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Hide();
            f1.ShowDialog();
            Show();
        }
    }
}
