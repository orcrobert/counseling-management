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

namespace subjectmanager
{
    public partial class DataForm : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["subjectmanager.Properties.Settings.SubjectsConnectionString"].ConnectionString);

        private string currentTable = "matricole";

        public DataForm()
        {
            InitializeComponent();
            showDataStudents();
            toolStripTextBox1.TextChanged += toolStripTextBox1_TextChanged;
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
        }

        public void showDataStudents(string searchQuery = "")
        {
            conn.Open();

            string query = @"SELECT * FROM matricole";
            if (!string.IsNullOrEmpty(searchQuery))
            {
                query += " WHERE name LIKE @search OR classOf LIKE @search" +
                    " OR motive LIKE @search OR noOfAppointments LIKE @search";
            }

            SqlDataAdapter show = new SqlDataAdapter(query, conn);
            if (!string.IsNullOrEmpty(searchQuery))
            {
                show.SelectCommand.Parameters.AddWithValue("@search", "%" + searchQuery + "%");
            }

            DataTable table = new DataTable();
            table.TableName = "matricole";
            show.Fill(table);

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = table;

            conn.Close();

            currentTable = "matricole";
        }

        public void showDataAppointments(string searchQuery = "")
        {
            conn.Open();

            string query = @"SELECT * FROM appointmentsDate";
            if (!string.IsNullOrEmpty(searchQuery))
            {
                query += " WHERE name LIKE @search OR date LIKE @search" +
                    " OR theme LIKE @search";
            }

            SqlDataAdapter show = new SqlDataAdapter(query, conn);
            if (!string.IsNullOrEmpty(searchQuery))
            {
                show.SelectCommand.Parameters.AddWithValue("@search", "%" + searchQuery + "%");
            }

            DataTable table = new DataTable();
            table.TableName = "appointmentsDate";
            show.Fill(table);

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = table;

            conn.Close();
            currentTable = "appointmentsDate";
        }

        public void showDataParents(string searchQuery = "")
        {
            conn.Open();

            string query = @"SELECT * FROM parents";
            if (!string.IsNullOrEmpty(searchQuery))
            {
                query += " WHERE name LIKE @search OR phone LIKE @search" +
                    " OR email LIKE @search OR noOfAppointments LIKE @search";
            }

            SqlDataAdapter show = new SqlDataAdapter(query, conn);
            if (!string.IsNullOrEmpty(searchQuery))
            {
                show.SelectCommand.Parameters.AddWithValue("@search", "%" + searchQuery + "%");
            }

            DataTable table = new DataTable();
            table.TableName = "parents";
            show.Fill(table);

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = table;

            conn.Close();
            currentTable = "parents";
        }

        public void showDataTeachers(string searchQuery = "")
        {
            conn.Open();

            string query = @"SELECT * FROM teachers";
            if (!string.IsNullOrEmpty(searchQuery))
            {
                query += " WHERE name LIKE @search OR phone LIKE @search" +
                    " OR email LIKE @search OR noOfAppointments LIKE @search";
            }

            SqlDataAdapter show = new SqlDataAdapter(query, conn);
            if (!string.IsNullOrEmpty(searchQuery))
            {
                show.SelectCommand.Parameters.AddWithValue("@search", "%" + searchQuery + "%");
            }

            DataTable table = new DataTable();
            table.TableName = "teachers";
            show.Fill(table);

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = table;

            conn.Close();
            currentTable = "teachers";
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = toolStripTextBox1.Text;
            if (toolStripTextBox1.Text == "Search")
                searchQuery = "";

            if (currentTable == "matricole")
            {
                showDataStudents(searchQuery);
            }
            else if (currentTable == "appointmentsDate")
            {
                showDataAppointments(searchQuery);
            }
            else if (currentTable == "parents")
            {
                showDataParents(searchQuery);
            }
            else if (currentTable == "teachers")
            {
                showDataTeachers(searchQuery);
            }
        }

        private void appointmentDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDataAppointments();
        }

        private void subjectDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDataStudents();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripTextBox1_Enter(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "Search") 
            {
                toolStripTextBox1.Text = "";
                toolStripTextBox1.ForeColor = Color.Black;
            }
        }

        private void toolStripTextBox1_Leave(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "Search";
            toolStripTextBox1.ForeColor = Color.Silver;
        }

        private void parentDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDataParents();
        }

        private void teacherDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDataTeachers();
        }
    }
}
