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
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;


namespace subjectmanager
{
    public partial class AddAppointmentForm : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Robert\\source\\repos\\subjectmanager\\Subjects.mdf;Integrated Security=True");
        public AddAppointmentForm()
        {
            InitializeComponent();
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
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

                subjectsComboBox.DataSource = subjectsTable;
                subjectsComboBox.DisplayMember = "name";
                subjectsComboBox.ValueMember = "Id";
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

        private void button1_Click(object sender, EventArgs e)
        {
            int subjectId = (int)subjectsComboBox.SelectedIndex + 1;

            try
            {
                conn.Open();

                int appointmentCount;
                if (textBox1.Text.Length == 0)
                    appointmentCount = 1;
                else
                {
                    try
                    {
                        appointmentCount = int.Parse(textBox1.Text);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Number of appointments must be a integer!");
                        return;
                    }
                }

                SqlCommand cmd = new SqlCommand("UPDATE matricole SET noOfAppointments = noOfAppointments + @appointmentCount WHERE Id = @SubjectId", conn);
                cmd.Parameters.AddWithValue("@appointmentCount", appointmentCount);
                cmd.Parameters.AddWithValue("@SubjectId", subjectId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    MessageBox.Show("Appointment added successfully!");
                else
                    MessageBox.Show("Failed to add appointment!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating number of appointments!");
            }
            finally { conn.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                int appointmentCount;
                if (textBox2.Text.Length == 0)
                    appointmentCount = 1;
                else
                {
                    try
                    {
                        appointmentCount = int.Parse(textBox2.Text);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Number of appointments must be a integer!");
                        return;
                    }
                }

                SqlCommand cmd = new SqlCommand("UPDATE groupAppointments SET noOfAppointments = noOfAppointments + @appointmentCount", conn);
                cmd.Parameters.AddWithValue("@appointmentCount", appointmentCount);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    MessageBox.Show("Appointment added successfully!");
                else
                    MessageBox.Show("Failed to add appointment!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error updating number of group appointments!");
            }
            finally { conn.Close(); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
