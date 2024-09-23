using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subjectmanager
{
    public partial class MainForm : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["subjectmanager.Properties.Settings.SubjectsConnectionString"].ConnectionString);
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
            DataForm form = new DataForm();
            form.ShowDialog();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                openFileDialog.Title = "Select Excel File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    ImportDataFromExcel(filePath);
                }
            }
        }

        private void ImportDataFromExcel(string filePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;

                List<Subject> matricoleList = new List<Subject>();

                for (int row = 1; row <= rowCount; row++)
                {
                    Subject subject = new Subject
                    {
                        name = worksheet.Cells[row, 2].Text,
                        classOf = worksheet.Cells[row, 3].Text,
                        motive = "",
                        school = worksheet.Cells[row, 4].Text,
                        noOfAppointments = 0
                    };

                    matricoleList.Add(subject);
                }
                UpdateMatricoleTable(matricoleList);
            }
        }

        private void UpdateMatricoleTable(List<Subject> matricoleList)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["subjectmanager.Properties.Settings.SubjectsConnectionString"].ConnectionString))
            {
                conn.Open();

                foreach (var matricola in matricoleList)
                {
                    string query = @"IF EXISTS (SELECT 1 FROM matricole WHERE name = @name)
                             BEGIN
                                UPDATE matricole
                                SET classOf = @classOf, motive = @motive, school = @school, noOfAppointments = @noOfAppointments
                                WHERE name = @name
                             END
                             ELSE
                             BEGIN
                                INSERT INTO matricole (name, classOf, motive, school, noOfAppointments)
                                VALUES (@name, @classOf, @motive, @school, @noOfAppointments)
                             END";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", matricola.name);
                        cmd.Parameters.AddWithValue("@classOf", matricola.classOf);
                        cmd.Parameters.AddWithValue("@motive", matricola.motive);
                        cmd.Parameters.AddWithValue("@school", matricola.school);
                        cmd.Parameters.AddWithValue("@noOfAppointments", matricola.noOfAppointments);

                        cmd.ExecuteNonQuery();
                    }
                }

                conn.Close();
            }

            MessageBox.Show("Data successfully imported from Excel!");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete all data from the Matricole table?",
                                         "Confirm Deletion",
                                         MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // The SQL query to delete all rows from the 'matricole' table
                string query = "DELETE FROM matricole";

                try
                {
                    conn.Open();  // Open the SQL connection
                    SqlCommand cmd = new SqlCommand(query, conn);  // Prepare the SQL command
                    cmd.ExecuteNonQuery();  // Execute the command to delete all data

                    MessageBox.Show("All data from the 'Matricole' table has been deleted.");

                    // After deleting, reload the updated (empty) table in the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting data: " + ex.Message);  // Show an error message if something goes wrong
                }
                finally
                {
                    conn.Close();  // Close the connection, whether successful or not
                }
            }
        }
    }
}
