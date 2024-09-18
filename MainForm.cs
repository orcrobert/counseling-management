using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subjectmanager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void viewDataFormButton_Click(object sender, EventArgs e)
        {
            DataForm form = new DataForm();
            form.ShowDialog();
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            AddSubjectForm form = new AddSubjectForm();
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void viewStatisticsFormButton_Click(object sender, EventArgs e)
        {
            StatisticsForm form = new StatisticsForm();
            form.ShowDialog();
        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            AddAppointmentForm form = new AddAppointmentForm();
            form.ShowDialog();
        }

        private void deleteSubjectButton_Click(object sender, EventArgs e)
        {
            DeleteSubjectForm form = new DeleteSubjectForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test form = new Test();
            form.ShowDialog();
        }
    }
}
