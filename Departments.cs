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
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonNeuro_Click(object sender, EventArgs e)
        {
            SpecialLists sl = new SpecialLists("neuro");
            Hide();
            sl.ShowDialog();
            Show();
        }

        private void buttonCardio_Click(object sender, EventArgs e)
        {
            SpecialLists sl = new SpecialLists("cardio");
            Hide();
            sl.ShowDialog();
            Show();
        }

        private void buttonSurg_Click(object sender, EventArgs e)
        {
            SpecialLists sl = new SpecialLists("surg");
            Hide();
            sl.ShowDialog();
            Show();
        }

        private void buttonOnco_Click(object sender, EventArgs e)
        {
            SpecialLists sl = new SpecialLists("onco");
            Hide();
            sl.ShowDialog();
            Show();
        }
    }
}
