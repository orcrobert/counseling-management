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
        DataGridView tempDtg = new DataGridView();

        public DataForm()
        {
            InitializeComponent();
            showDataStudents();
            toolStripTextBox1.TextChanged += toolStripTextBox1_TextChanged;
            editRowButton.Enabled = false;
            hideDatePickers();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void hideDatePickers()
        {
            startDatePicker.Visible = false;
            endDatePicker.Visible = false;
            filterByDateButton.Visible = false;
            dateFilterActivityLabel.Visible = false;
        }

        private void showDatePickers()
        {
            startDatePicker.Visible = true;
            endDatePicker.Visible = true;
            filterByDateButton.Visible = true;
            dateFilterActivityLabel.Visible = true;
        }

        private void resetDatePickers()
        {
            startDatePicker.Value = DateTime.Now;
            endDatePicker.Value = DateTime.Now;
            dateFilterActivityLabel.Text = "(inactive date filter)";
            dateFilterActivityLabel.ForeColor = Color.FromArgb(192, 0, 0);
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

            hideDatePickers();
            currentTable = "matricole";
        }

        public void showDataAppointments(string searchQuery = "")
        {
            showDatePickers();
            conn.Open();

            string query = @"SELECT * FROM appointmentsDate";

            if (!string.IsNullOrEmpty(searchQuery))
            {
                query += " WHERE name LIKE @search OR date LIKE @search OR theme LIKE @search";
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

            hideDatePickers();
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

            hideDatePickers();
            currentTable = "teachers";
        }
        public void showDataGroups(string searchQuery = "")
        {
            conn.Open();

            string query = @"SELECT * FROM groupAppointments";
            if (!string.IsNullOrEmpty(searchQuery))
            {
                query += " WHERE name LIKE @search OR noOfAppointments LIKE @search";
            }

            SqlDataAdapter show = new SqlDataAdapter(query, conn);
            if (!string.IsNullOrEmpty(searchQuery))
            {
                show.SelectCommand.Parameters.AddWithValue("@search", "%" + searchQuery + "%");
            }

            DataTable table = new DataTable();
            table.TableName = "groupAppointments";
            show.Fill(table);

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = table;

            conn.Close();

            hideDatePickers();
            currentTable = "groupAppointments";
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
            else if (currentTable == "groupAppointments")
            {
                showDataGroups(searchQuery);
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

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            if (currentTable == "matricole")
            {
                showDataStudents("");
            }
            else if (currentTable == "appointmentsDate")
            {
                resetDatePickers();
                showDataAppointments("");
            }
            else if (currentTable == "parents")
            {
                showDataParents("");
            }
            else if (currentTable == "teachers")
            {
                showDataTeachers("");
            }
            else if (currentTable == "groupAppointments")
            {
                showDataGroups("");
            }
        }

        private void filterByDateButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;

            dateFilterActivityLabel.Text = "(active date filter)";
            dateFilterActivityLabel.ForeColor = Color.Green;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be after the end date.");
                return;
            }

            conn.Open();

            string query = @"SELECT * FROM appointmentsDate WHERE date BETWEEN @startDate AND @endDate";

            SqlDataAdapter show = new SqlDataAdapter(query, conn);
            show.SelectCommand.Parameters.AddWithValue("@startDate", startDate);
            show.SelectCommand.Parameters.AddWithValue("@endDate", endDate);

            DataTable table = new DataTable();
            table.TableName = "appointmentsDate";
            show.Fill(table);

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = table;

            conn.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                editRowButton.Enabled = true;
            }
            else
            {
                editRowButton.Enabled= false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tempDtg = dataGridView1;
            editRowButton.Enabled = true;
        }

        private void editRowButton_Click(object sender, EventArgs e)
        {
            EditRowForm editRowForm = new EditRowForm(tempDtg, currentTable);
            editRowForm.ShowDialog();
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDataGroups();
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubjectForm form = new AddSubjectForm();
            form.ShowDialog();
        }

        private void removeRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowID = Int32.Parse(tempDtg.CurrentRow.Cells[0].Value.ToString());
            string query = "";

            if (currentTable == "matricole")
            {
                query = "DELETE FROM matricole WHERE Id = @Id";
            }
            else if (currentTable == "appointmentsDate")
            {
                query = "DELETE FROM appointmentsDate WHERE Id = @Id";
            }
            else if (currentTable == "parents")
            {
                query = "DELETE FROM parents WHERE Id = @Id";
            }
            else if (currentTable == "teachers")
            {
                query = "DELETE FROM teachers WHERE Id = @Id";
            }
            else if (currentTable == "groupAppointments")
            {
                query = "DELETE FROM groupAppointments WHERE Id = @Id";
            }

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", rowID);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Record deleted successfully!");
        }
    }
}
