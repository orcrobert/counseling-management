using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subjectmanager
{
    public partial class DeleteSubjectForm : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Robert\\source\\repos\\subjectmanager\\Subjects.mdf;Integrated Security=True");
        public DeleteSubjectForm()
        {
            InitializeComponent();
        }
        private void LoadSubjects()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, name FROM matricole", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable subjectsTable = new DataTable();
                adapter.Fill(subjectsTable);

                subjectComboBox.DataSource = subjectsTable;
                subjectComboBox.DisplayMember = "name";
                subjectComboBox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void DeleteSubjectForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            int studentId = (int)subjectComboBox.SelectedIndex + 1;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM matricole WHERE Id = @StudentId", conn);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    MessageBox.Show("Student deleted successfully!");
                else
                    MessageBox.Show("Failed to delete student!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error finding or deleting student!");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
