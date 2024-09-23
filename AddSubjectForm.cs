using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace subjectmanager
{
    public partial class AddSubjectForm : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["subjectmanager.Properties.Settings.SubjectsConnectionString"].ConnectionString);
        SqlCommand cmd;
        private DataForm form;
        private string entity = "student";

        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void AddSubjectForm_Load(object sender, EventArgs e)
        {

        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            if (entity == "student")
            {
                addStudentToDatabase();
            }
            else if (entity == "parent" || entity == "teacher")
            {
                addParentOrTeacherToDatabase();
            }
            else if (entity == "group")
            {
                addGroupToDatabase();
            }
        }

        private void addStudentToDatabase()
        {
            int noOfAppointments;
            if (noOfAppointmentsTextBox.Text.Length == 0)
            {
                noOfAppointments = 0;
            }
            else
            {
                try
                {
                    noOfAppointments = int.Parse(noOfAppointmentsTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Number of appointments must be an integer!");
                    return;
                }
            }

            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(classTextBox.Text))
            {
                MessageBox.Show("Name and class fields cannot be empty!");
                return;
            }

            string query = "INSERT INTO matricole (name, classOf, motive, school, noOfAppointments) " +
                           "VALUES (@name, @classOf, @motive, @school, @noOfAppointments)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@classOf", classTextBox.Text);
                cmd.Parameters.AddWithValue("@motive", motiveTextBox.Text);
                cmd.Parameters.AddWithValue("@school", schoolTextBox.Text);
                cmd.Parameters.AddWithValue("@noOfAppointments", noOfAppointments);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data has been saved into the database!");
            }
        }
        private void addParentOrTeacherToDatabase()
        {
            int noOfAppointments;
            if (noOfAppointmentsTextBox.Text.Length == 0)
            {
                noOfAppointments = 0;
            }
            else
            {
                try
                {
                    noOfAppointments = int.Parse(noOfAppointmentsTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Number of appointments must be an integer!");
                    return;
                }
            }

            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name field cannot be empty!");
                return;
            }

            string query = "";

            if (entity == "parent")
            {
                query = "INSERT INTO parents (name, phone, email, noOfAppointments) " +
                        "VALUES (@name, @phone, @email, @noOfAppointments)";
            }
            else
            {
                query = "INSERT INTO teachers (name, phone, email, noOfAppointments) " +
                        "VALUES (@name, @phone, @email, @noOfAppointments)";
            }

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", classTextBox.Text);
                cmd.Parameters.AddWithValue("@email", motiveTextBox.Text);
                cmd.Parameters.AddWithValue("@noOfAppointments", noOfAppointments);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data has been saved into the database!");
            }
        }

        private void addGroupToDatabase()
        {
            int noOfAppointments;
            if (classTextBox.Text.Length == 0)
            {
                noOfAppointments = 0;
            }
            else
            {
                try
                {
                    noOfAppointments = int.Parse(classTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Number of appointments must be an integer!");
                    return;
                }
            }

            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name cannot be empty");
                return;
            }

            string query = "INSERT INTO groupAppointments (name, noOfAppointments) " +
                           "VALUES (@name, @noOfAppointments)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@noOfAppointments", noOfAppointments);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data has been saved into the database!");
            }
        }

        private void studentRadio_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            motiveTextBox.Visible = true;
            noOfAppointmentsTextBox.Visible = true;
            entity = "student";
            label2.Text = "Class";
            label3.Text = "Motive";
            label5.Visible = true;
            schoolTextBox.Visible = true;
        }

        private void parentRadio_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            motiveTextBox.Visible = true;
            noOfAppointmentsTextBox.Visible = true;
            entity = "parent";
            label2.Text = "Phone";
            label3.Text = "Email";
            label5.Visible = false;
            schoolTextBox.Visible = false;
        }

        private void teacherRadio_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            motiveTextBox.Visible = true;
            noOfAppointmentsTextBox.Visible = true;
            entity = "teacher";
            label2.Text = "Phone";
            label3.Text = "Email";
            label5.Visible = false;
            schoolTextBox.Visible = false;
        }

        private void groupRadio_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            motiveTextBox.Visible = false;
            noOfAppointmentsTextBox.Visible = false;
            schoolTextBox.Visible = false;
            entity = "group";

            label2.Text = "Number of appointments";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            classTextBox.Text = "";
            motiveTextBox.Text = "";
            noOfAppointmentsTextBox.Text = "";
            schoolTextBox.Text = "";
        }

        private void parentRadio_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void teacherRadio_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void studentRadio_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
