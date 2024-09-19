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
        }

        private void addStudentToDatabase()
        {
            int noOfAppointments;
            if (noOfAppointmentsTextBox.Text.Length == 0)
                noOfAppointments = 0;
            else
            {
                try
                {
                    noOfAppointments = int.Parse(noOfAppointmentsTextBox.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Number of appointments must be a integer!");
                    return;
                }
            }

            if (nameTextBox.Text == "" || classTextBox.Text == "")
            {
                MessageBox.Show("Name and class fields cannot be empty!");
                return;
            }

            conn.Open();
            cmd = new SqlCommand("INSERT INTO matricole values ('" + nameTextBox.Text + "', " +
                "'" + classTextBox.Text + "', '" + motiveTextBox.Text + "', '" + noOfAppointments + "')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved into the database!");
            conn.Close();
        }

        private void addParentOrTeacherToDatabase()
        {
            int noOfAppointments;
            if (noOfAppointmentsTextBox.Text.Length == 0)
                noOfAppointments = 0;
            else
            {
                try
                {
                    noOfAppointments = int.Parse(noOfAppointmentsTextBox.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Number of appointments must be a integer!");
                    return;
                }
            }

            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Name field cannot be empty!");
                return;
            }

            conn.Open();
            
            if (entity == "parent")
            {
                cmd = new SqlCommand("INSERT INTO parents values ('" + nameTextBox.Text + "', " +
               "'" + classTextBox.Text + "', '" + motiveTextBox.Text + "', '" + noOfAppointments + "')", conn);
            }
            else
            {
                cmd = new SqlCommand("INSERT INTO teachers values ('" + nameTextBox.Text + "', " +
               "'" + classTextBox.Text + "', '" + motiveTextBox.Text + "', '" + noOfAppointments + "')", conn);
            }

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved into the database!");
            conn.Close();
        }

        private void studentRadio_Click(object sender, EventArgs e)
        {
            entity = "student";
            label2.Text = "Class";
            label3.Text = "Motive";
        }

        private void parentRadio_Click(object sender, EventArgs e)
        {
            entity = "parent";
            label2.Text = "Phone";
            label3.Text = "Email";
        }

        private void teacherRadio_Click(object sender, EventArgs e)
        {
            entity = "teacher";
            label2.Text = "Phone";
            label3.Text = "Email";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            classTextBox.Text = "";
            motiveTextBox.Text = "";
            noOfAppointmentsTextBox.Text = "";
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
