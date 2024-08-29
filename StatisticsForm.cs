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

namespace subjectmanager
{
    public partial class StatisticsForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Robert\\source\\repos\\subjectmanager\\Subjects.mdf;Integrated Security=True");

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

        private void GetStatistics()
        {
            try
            {
                conn.Open();
                countSubjects();
                countAppointments();
                countCounseled();
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
