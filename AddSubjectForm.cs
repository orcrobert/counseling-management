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
        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void AddSubjectForm_Load(object sender, EventArgs e)
        {

        }

        private void addSubjectButton_Click(object sender, EventArgs e)
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
    }
}
