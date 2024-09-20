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
    public partial class EditRowForm : Form
    {
        string currentTable;
        int rowID;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["subjectmanager.Properties.Settings.SubjectsConnectionString"].ConnectionString);
        public EditRowForm(DataGridView row, string currentTable)
        {
            this.currentTable = currentTable;
            this.rowID = Int32.Parse(row.CurrentRow.Cells[0].Value.ToString());
            InitializeComponent();
            nameTextBox.Text = row.CurrentRow.Cells[1].Value.ToString();
            classTextBox.Text = row.CurrentRow.Cells[2].Value.ToString();
            motiveTextBox.Text = row.CurrentRow.Cells[3].Value.ToString();
            noOfAppointmentsTextBox.Text = row.CurrentRow.Cells[4].Value.ToString();

            if (currentTable == "students")
                changeToStudentLabels();
            else if (currentTable == "appointmentsDate")
                changeToAppointmentLables();
            else if (currentTable == "parents" || currentTable == "teachers")
                changeToParentTeacherLables();
        }

        private void changeToStudentLabels()
        {
            label1.Text = "Name";
            label2.Text = "Class";
            label3.Text = "Motive";
            label4.Text = "Number of appointments";
        }

        private void changeToAppointmentLables()
        {
            label1.Text = "Name";
            label2.Text = "Date";
            label3.Text = "Theme";
            label4.Text = "Type";
        }

        private void changeToParentTeacherLables()
        {
            label1.Text = "Name";
            label2.Text = "Phone";
            label3.Text = "Email";
            label4.Text = "Number of appointments";
        }

        private void EditRowForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query;
            SqlCommand cmd = new SqlCommand();

            if (this.currentTable == "matricole")
            { 
                query = "UPDATE matricole SET name = @name, classOf = @classOf, motive =  @motive, noOfAppointments = @noOfAppointments WHERE Id = @Id";
                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@classOf", classTextBox.Text);
                cmd.Parameters.AddWithValue("@motive", motiveTextBox.Text);
                cmd.Parameters.AddWithValue("@noOfAppointments", Int32.Parse(noOfAppointmentsTextBox.Text));
                cmd.Parameters.AddWithValue("@Id", rowID);
            }
            else if (this.currentTable == "appointmentsDate")
            {
                query = "UPDATE appointmentsDate SET name = @name, date = @date, theme =  @theme, type = @type WHERE Id = @Id";
                cmd = new SqlCommand(query, conn);

                DateTime temp = DateTime.Parse(classTextBox.Text);

                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@date", temp);
                cmd.Parameters.AddWithValue("@theme", motiveTextBox.Text);
                cmd.Parameters.AddWithValue("@type", Int32.Parse(noOfAppointmentsTextBox.Text));
                cmd.Parameters.AddWithValue("@Id", rowID);
            }
            else if (this.currentTable == "parents")
            {
                query = "UPDATE parents SET name = @name, phone = @phone, email =  @email, noOfAppointments = @noOfAppointments WHERE Id = @Id";
                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", classTextBox.Text);
                cmd.Parameters.AddWithValue("@email", motiveTextBox.Text);
                cmd.Parameters.AddWithValue("@noOfAppointments", Int32.Parse(noOfAppointmentsTextBox.Text));
                cmd.Parameters.AddWithValue("@Id", rowID);
            }
            else if (this.currentTable == "teachers")
            {
                query = "UPDATE teachers SET name = @name, phone = @phone, email =  @email, noOfAppointments = @noOfAppointments WHERE Id = @Id";
                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", classTextBox.Text);
                cmd.Parameters.AddWithValue("@email", motiveTextBox.Text);
                cmd.Parameters.AddWithValue("@noOfAppointments", Int32.Parse(noOfAppointmentsTextBox.Text));
                cmd.Parameters.AddWithValue("@Id", rowID);
            }

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record updated successfully!");
        }
    }
}
