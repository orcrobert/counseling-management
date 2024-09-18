using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace subjectmanager
{
    public partial class DataForm : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["subjectmanager.Properties.Settings.SubjectsConnectionString"].ConnectionString);
        public DataForm()
        {
            InitializeComponent();
            showDataStudents();
        }
        public void showDataStudents()
        {
            conn.Open();
            SqlDataAdapter show = new SqlDataAdapter(@"SELECT * from matricole", conn);
            DataTable table = new DataTable();
            show.Fill(table);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = table;
            dataGridView1.DataSource = bindingSource;
            conn.Close();
        }

        public void showDataAppointments()
        {
            conn.Open();
            SqlDataAdapter show = new SqlDataAdapter(@"SELECT * from appointmentsDate", conn);
            DataTable table = new DataTable();
            show.Fill(table);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = table;
            dataGridView1.DataSource = bindingSource;
            conn.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void DataForm_Load(object sender, EventArgs e)
        {

        }

        private void appointmentDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDataAppointments();
        }

        private void subjectDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDataStudents();
        }
    }
}
