using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Add this if not already present

namespace subjectmanager
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void subjectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.subjectsDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            this.matricoleTableAdapter.Fill(this.subjectsDataSet.matricole);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'subjectsDataSet1.matricole' table. You can move, or remove it, as needed.
            this.matricoleTableAdapter1.Fill(this.subjectsDataSet1.matricole);

        }

        private void matricoleBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matricoleBindingSource1.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.subjectsDataSet1);

        }
    }
}
// Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Robert\source\repos\subjectmanager\Subjects.mdf;Integrated Security=True
