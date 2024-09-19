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
    public partial class StatisticsForm : Form

    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["subjectmanager.Properties.Settings.SubjectsConnectionString"].ConnectionString);

        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            
            GetStatistics();
        }
        
        private void countSubjects() 
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM matricole", conn);
            int subjectCount = (int)cmd.ExecuteScalar();
            numberOfSubjectsLabel.Text = subjectCount.ToString();
        }

        private void countAppointments() 
        {
            SqlCommand cmd = new SqlCommand("SELECT SUM(noOfAppointments) FROM matricole", conn);
            int appointmentCount = (int)cmd.ExecuteScalar();
            completedAppointmentsLabel.Text = appointmentCount.ToString();
        }

        private void countCounseled()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM matricole WHERE noOfAppointments IS NOT NULL AND noOfAppointments != 0", conn);
            int counseledCount = (int)cmd.ExecuteScalar();
            numberOfCounseledLabel.Text = counseledCount.ToString();
        }

        private void getGroupAppointments()
        {
            SqlCommand cmd = new SqlCommand("SElECT SUM(noOfAppointments) FROM groupAppointments", conn);
            int appointmentCount = (int)cmd.ExecuteScalar();
            numberOfGroupAppointments.Text = appointmentCount.ToString();
        }

        private void countParents()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM parents", conn);
            int parentCount = (int)cmd.ExecuteScalar();
            label13.Text = parentCount.ToString();
        }

        private void countAppointmentsParents()
        {
            SqlCommand cmd = new SqlCommand("SELECT SUM(noOfAppointments) FROM parents", conn);
            int appointmentCount = (int)cmd.ExecuteScalar();
            label12.Text = appointmentCount.ToString();

        }

        private void countCounseledParents()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM parents WHERE noOfAppointments IS NOT NULL AND noOfAppointments != 0", conn);
            int counseledCount = (int)cmd.ExecuteScalar();
            label11.Text = counseledCount.ToString();
        }

        private void GetStatistics()
        {
            try
            {
                conn.Open();
                countSubjects();
                countAppointments();
                countCounseled();
                getGroupAppointments();
                countParents();
                countAppointmentsParents();
                countCounseledParents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
